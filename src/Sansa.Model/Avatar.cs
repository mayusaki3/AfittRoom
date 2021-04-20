using Jaffa.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Sansa.Model
{
    /// <summary>
    /// アバター
    /// </summary>
    public class Avatar
    {
        #region メソッド

        #region メソッド

        public void Load(List<GLB_Chunk> ChunkList)
        {
            // チャンク0を処理
            using (var ms = new MemoryStream(ChunkList[0].ChunkData, 0, (int)ChunkList[0].ChunkLength))
            {
                using (var rd = new StreamReader(ms, Encoding.UTF8))
                {
                    string js = rd.ReadToEnd();

                    AvatarTF avaTF = JsonSerializer.Deserialize<AvatarTF>(js);

                    Logging.Write("\r\n" + js);
                }
            }



        }

        #endregion

        #region メソッド


        public void Save(out List<GLB_Chunk> ChunkList)
        {
            ChunkList = new();







        }

        #endregion

        #endregion

        #region



        #endregion

        #region




        #endregion

        #region




        #endregion

        #region




        #endregion
    }

    /*
    public class Rootobject
    {
        public string[] extensionsUsed { get; set; }
        public Extensions extensions { get; set; }
        public Asset asset { get; set; }
        public Buffer[] buffers { get; set; }
        public Bufferview[] bufferViews { get; set; }
        public Accessor[] accessors { get; set; }
        public Image[] images { get; set; }
        public Sampler[] samplers { get; set; }
        public Texture[] textures { get; set; }
        public Material[] materials { get; set; }
        public Mesh[] meshes { get; set; }
        public Skin[] skins { get; set; }
        public Node[] nodes { get; set; }
    }

    public class Extensions
    {
        public VRM VRM { get; set; }
    }

    public class VRM
    {
        public string exporterVersion { get; set; }
        public Meta meta { get; set; }
        public Humanoid humanoid { get; set; }
        public Firstperson firstPerson { get; set; }
        public Blendshapemaster blendShapeMaster { get; set; }
        public Secondaryanimation secondaryAnimation { get; set; }
        public Materialproperty[] materialProperties { get; set; }
    }

    public class Meta
    {
        public string version { get; set; }
        public string author { get; set; }
        public string contactInformation { get; set; }
        public string reference { get; set; }
        public string title { get; set; }
        public int texture { get; set; }
        public string allowedUserName { get; set; }
        public string violentUssageName { get; set; }
        public string sexualUssageName { get; set; }
        public string commercialUssageName { get; set; }
        public string otherPermissionUrl { get; set; }
        public string licenseName { get; set; }
        public string otherLicenseUrl { get; set; }
    }

    public class Humanoid
    {
        public Humanbone[] humanBones { get; set; }
        public float armStretch { get; set; }
        public float legStretch { get; set; }
        public float upperArmTwist { get; set; }
        public float lowerArmTwist { get; set; }
        public float upperLegTwist { get; set; }
        public float lowerLegTwist { get; set; }
        public int feetSpacing { get; set; }
        public bool hasTranslationDoF { get; set; }
    }

    public class Humanbone
    {
        public string bone { get; set; }
        public int node { get; set; }
        public bool useDefaultValues { get; set; }
    }

    public class Firstperson
    {
        public int firstPersonBone { get; set; }
        public Firstpersonboneoffset firstPersonBoneOffset { get; set; }
        public object[] meshAnnotations { get; set; }
        public string lookAtTypeName { get; set; }
        public Lookathorizontalinner lookAtHorizontalInner { get; set; }
        public Lookathorizontalouter lookAtHorizontalOuter { get; set; }
        public Lookatverticaldown lookAtVerticalDown { get; set; }
        public Lookatverticalup lookAtVerticalUp { get; set; }
    }

    public class Firstpersonboneoffset
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

    public class Lookathorizontalinner
    {
        public int xRange { get; set; }
        public int yRange { get; set; }
    }

    public class Lookathorizontalouter
    {
        public int xRange { get; set; }
        public int yRange { get; set; }
    }

    public class Lookatverticaldown
    {
        public int xRange { get; set; }
        public int yRange { get; set; }
    }

    public class Lookatverticalup
    {
        public int xRange { get; set; }
        public int yRange { get; set; }
    }

    public class Blendshapemaster
    {
        public Blendshapegroup[] blendShapeGroups { get; set; }
    }

    public class Blendshapegroup
    {
        public string name { get; set; }
        public string presetName { get; set; }
        public Bind[] binds { get; set; }
        public object[] materialValues { get; set; }
    }

    public class Bind
    {
        public int mesh { get; set; }
        public int index { get; set; }
        public int weight { get; set; }
    }

    public class Secondaryanimation
    {
        public Bonegroup[] boneGroups { get; set; }
        public Collidergroup[] colliderGroups { get; set; }
    }

    public class Bonegroup
    {
        public string comment { get; set; }
        public int stiffiness { get; set; }
        public int gravityPower { get; set; }
        public Gravitydir gravityDir { get; set; }
        public float dragForce { get; set; }
        public int center { get; set; }
        public float hitRadius { get; set; }
        public int[] bones { get; set; }
        public object[] colliderGroups { get; set; }
    }

    public class Gravitydir
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

    public class Collidergroup
    {
        public int node { get; set; }
        public Collider[] colliders { get; set; }
    }

    public class Collider
    {
        public Offset offset { get; set; }
        public float radius { get; set; }
    }

    public class Offset
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Materialproperty
    {
        public string name { get; set; }
        public int renderQueue { get; set; }
        public string shader { get; set; }
        public Floatproperties floatProperties { get; set; }
        public Vectorproperties vectorProperties { get; set; }
        public Textureproperties textureProperties { get; set; }
        public Keywordmap keywordMap { get; set; }
        public Tagmap tagMap { get; set; }
    }

    public class Floatproperties
    {
        public int _SrcBlend { get; set; }
        public int _DstBlend { get; set; }
        public int _ZWrite { get; set; }
        public float _Cutoff { get; set; }
        public int _BumpScale { get; set; }
        public int _ReceiveShadowRate { get; set; }
        public int _ShadingGradeRate { get; set; }
        public float _ShadeShift { get; set; }
        public float _ShadeToony { get; set; }
        public int _LightColorAttenuation { get; set; }
        public float _IndirectLightIntensity { get; set; }
        public float _OutlineWidth { get; set; }
        public int _OutlineScaledMaxDistance { get; set; }
        public int _OutlineLightingMix { get; set; }
        public int _DebugMode { get; set; }
        public int _BlendMode { get; set; }
        public int _OutlineWidthMode { get; set; }
        public int _OutlineColorMode { get; set; }
        public int _CullMode { get; set; }
        public int _OutlineCullMode { get; set; }
    }

    public class Vectorproperties
    {
        public float[] _Color { get; set; }
        public int[] _EmissionColor { get; set; }
        public float[] _ShadeColor { get; set; }
        public int[] _OutlineColor { get; set; }
        public int[] _MainTex { get; set; }
        public int[] _MetallicGlossMap { get; set; }
        public int[] _BumpMap { get; set; }
        public int[] _ParallaxMap { get; set; }
        public int[] _OcclusionMap { get; set; }
        public int[] _EmissionMap { get; set; }
        public int[] _DetailMask { get; set; }
        public int[] _DetailAlbedoMap { get; set; }
        public int[] _DetailNormalMap { get; set; }
        public int[] _LightTexture0 { get; set; }
        public int[] _LightTextureB0 { get; set; }
        public int[] _ShadowMapTexture { get; set; }
        public int[] _FrontTex { get; set; }
        public int[] _BackTex { get; set; }
        public int[] _LeftTex { get; set; }
        public int[] _RightTex { get; set; }
        public int[] _UpTex { get; set; }
        public int[] _DownTex { get; set; }
        public int[] _SecondTex { get; set; }
        public int[] _ThirdTex { get; set; }
        public int[] _ShadeTexture { get; set; }
        public int[] _ReceiveShadowTexture { get; set; }
        public int[] _ShadingGradeTexture { get; set; }
        public int[] _SphereAdd { get; set; }
        public int[] _OutlineWidthTexture { get; set; }
    }

    public class Textureproperties
    {
        public int _MainTex { get; set; }
        public int _ShadeTexture { get; set; }
    }

    public class Keywordmap
    {
        public bool _ALPHABLEND_ON { get; set; }
        public bool _ALPHATEST_ON { get; set; }
    }

    public class Tagmap
    {
        public string RenderType { get; set; }
    }

    public class Asset
    {
        public string generator { get; set; }
        public string version { get; set; }
    }

    public class Buffer
    {
        public int byteLength { get; set; }
    }

    public class Bufferview
    {
        public int buffer { get; set; }
        public int byteOffset { get; set; }
        public int byteLength { get; set; }
        public int target { get; set; }
    }

    public class Accessor
    {
        public int bufferView { get; set; }
        public int byteOffset { get; set; }
        public string type { get; set; }
        public int componentType { get; set; }
        public int count { get; set; }
        public float[] max { get; set; }
        public float[] min { get; set; }
        public bool normalized { get; set; }
    }

    public class Image
    {
        public string name { get; set; }
        public int bufferView { get; set; }
        public string mimeType { get; set; }
    }

    public class Sampler
    {
        public int magFilter { get; set; }
        public int minFilter { get; set; }
        public int wrapS { get; set; }
        public int wrapT { get; set; }
    }

    public class Texture
    {
        public int sampler { get; set; }
        public int source { get; set; }
    }

    public class Material
    {
        public string name { get; set; }
        public Pbrmetallicroughness pbrMetallicRoughness { get; set; }
        public int[] emissiveFactor { get; set; }
        public bool doubleSided { get; set; }
        public string alphaMode { get; set; }
        public Extensions1 extensions { get; set; }
    }

    public class Pbrmetallicroughness
    {
        public Basecolortexture baseColorTexture { get; set; }
        public float[] baseColorFactor { get; set; }
        public int metallicFactor { get; set; }
        public float roughnessFactor { get; set; }
    }

    public class Basecolortexture
    {
        public int index { get; set; }
        public int texCoord { get; set; }
    }

    public class Extensions1
    {
        public KHR_Materials_Unlit KHR_materials_unlit { get; set; }
    }

    public class KHR_Materials_Unlit
    {
    }

    public class Mesh
    {
        public string name { get; set; }
        public Primitive[] primitives { get; set; }
    }

    public class Primitive
    {
        public int mode { get; set; }
        public int indices { get; set; }
        public Attributes attributes { get; set; }
        public int material { get; set; }
        public Target[] targets { get; set; }
        public Extras extras { get; set; }
    }

    public class Attributes
    {
        public int POSITION { get; set; }
        public int NORMAL { get; set; }
        public int TEXCOORD_0 { get; set; }
        public int JOINTS_0 { get; set; }
        public int WEIGHTS_0 { get; set; }
        public int COLOR_0 { get; set; }
    }

    public class Extras
    {
        public string[] targetNames { get; set; }
    }

    public class Target
    {
        public int POSITION { get; set; }
        public int NORMAL { get; set; }
    }

    public class Skin
    {
        public int inverseBindMatrices { get; set; }
        public int[] joints { get; set; }
        public int skeleton { get; set; }
    }


    */
}
