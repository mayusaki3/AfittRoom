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

        #region アバターロード (Load)

        /// <summary>
        /// GLBチャンクリストからアバターをロードする。
        /// </summary>
        /// <param name="ChunkList">GLBチャンクリスト</param>
        public void Load(List<GLB_Chunk> ChunkList)
        {
            // チャンク0を処理
            using var ms = new MemoryStream(ChunkList[0].ChunkData, 0, (int)ChunkList[0].ChunkLength);
            using var rd = new StreamReader(ms, Encoding.UTF8);
            string js = rd.ReadToEnd();

            using (StreamWriter sw = new(@"C:\WORKPLACE\VRoom\LOAD.txt"))
            {
                sw.WriteLine(js.Replace(",", ",\r\n"));
            }

            AvaterTF = JsonSerializer.Deserialize<AvatarTF>(js);



        }

        #endregion

        #region アバターセーブ (Save)

        /// <summary>
        /// GLBチャンクリストにアバターをセーブする。
        /// </summary>
        /// <param name="ChunkList"></param>
        public void Save(out List<GLB_Chunk> ChunkList)
        {
            ChunkList = new();

            // GLBチャンク0作成
            GLB_Chunk chunk0 = new();
            chunk0.ChunkType = GLB_Chunk.ChankType.JSON;
            JsonSerializerOptions opt = new()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            };
            string js = JsonSerializer.Serialize(AvaterTF, opt);

            using (StreamWriter sw = new(@"C:\WORKPLACE\VRoom\SAVE.txt"))
            {
                sw.WriteLine(js.Replace(",",",\r\n"));
            }

            js = JsonSerializer.Serialize(new Sansa.Model.AvatarTF(), opt);

            using (StreamWriter sw = new(@"C:\WORKPLACE\VRoom\SAVE_NEW.txt"))
            {
                sw.WriteLine(js.Replace(",", ",\r\n"));
            }

        }

        #endregion

        #endregion

        #region



        #endregion

        #region




        #endregion

        #region プロパティ

        #region アバター

        public AvatarTF AvaterTF { get; set; } = null;

        #endregion

        #endregion

        #region




        #endregion
    }
}
