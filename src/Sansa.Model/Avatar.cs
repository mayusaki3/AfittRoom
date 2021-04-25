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
            avatarTF.Parse(ChunkList[0]);


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
            avatarTF.ToChunk(out GLB_Chunk chunk0);

            ChunkList.Add(chunk0);
        }

        #endregion
 

        #endregion

        #region



        #endregion

        #region




        #endregion

        #region プロパティ

        #region アバター

        public AvatarTF avatarTF { get; } = new();

        #endregion

        #endregion

        #region




        #endregion
    }
}
