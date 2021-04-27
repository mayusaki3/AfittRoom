using Jaffa;
using Jaffa.Diagnostics;
using System;
using System.Windows.Forms;
using Sansa.Model;
using System.Collections.Generic;
using System.IO;

namespace VRoomWin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoggingSettings.Folder = @"C:\WORKPLACE\VRoom\Log\";
            LoggingSettings.FileName = @"applog[@].txt";
            LoggingSettings.LoggingMode = LoggingMode.Week;

            Logging.Write("実行ログを " + LoggingSettings.Folder + " に出力します。");
            Logging.Write(@"JSON部分の入力/出力結果を C:\WORKPLACE\VRoom に出力します。");
            Logging.Write("定義に出力順は、検証用にglFT/VRMのスキーマ定義ではなく、VRoid Studioに合わせています。");
            Logging.Write("現状、float値の出力時に、値が丸められます。また指数がEで出力されます。");

            //    International.ChangeCultureFromDisplayLanguageName("en-US");

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Logging.LogWriting += Logging_LogWriting;
            Logging.LogWriteWaiting = false;

        }

        private void BtnInOpn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();
            dlg.Filter = "VRMファイル(*.vrm)|*.vrm|GLBファイル(*.glb)|*.glb|glTFファイル(*.gltf;*.glt)|*.vrm;*.glt|すべてのファイル(*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.Title = "対象のファイルを選択してください。";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtInVrm.Text = dlg.FileName;
                txtOutVrm.Text = txtInVrm.Text.Replace(".vrm", "_save.vrm");
            }
        }

        private void BtnOutOpn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new();
            dlg.FileName = txtOutVrm.Text;
            dlg.Filter = "VRMファイル(*.vrm)|*.vrm|GLBファイル(*.glb)|*.glb|glTFファイル(*.gltf;*.glt)|*.vrm;*.glt";
            dlg.FilterIndex = 1;
            dlg.Title = "保存先のファイルを指定してください。";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtOutVrm.Text = dlg.FileName;
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = txtInVrm.Text;
                switch (Path.GetExtension(filename).ToLower())
                {
                    case ".vrm":
                    case ".glb":
                        glb.Load(filename);
                        ava.Load(glb.ChunkList);
                        break;
                
                }
                propertyGrid1.SelectedObject = ava.avatarTF.schema;
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ExceptionToList(ex), LogType.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = txtInVrm.Text;
                switch (Path.GetExtension(filename).ToLower())
                {
                    case ".vrm":
                    case ".glb":
                        ava.Save(out List<GLB_Chunk> clst);
                        glb.ChunkList[0] = clst[0];
                        glb.Save(txtOutVrm.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ExceptionToList(ex), LogType.Error);
            }
        }

        private void Logging_LogWriting(object sender, LogWritingEventArgs e)
        {
            foreach (string msg in e.Messages)
            {
                txtLog.Text += msg + "\r\n";
            }
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        readonly GLB_File glb = new();
        readonly Avatar ava = new();

    }
}
