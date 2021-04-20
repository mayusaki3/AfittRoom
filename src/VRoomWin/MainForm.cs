using Jaffa;
using Jaffa.Diagnostics;
using System;
using System.Windows.Forms;
using Sansa.Model;

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

            International.ChangeCultureFromDisplayLanguageName("en-US");

            Logging.LogWriteWaiting = false;

            try
            {
                Avatar tm = new();
                GLB_File gf = new();
                gf.Load(@"mayusaki_chan.vrm");

                tm.Load(gf.ChunkList);
                

                gf.Save(@"mayusaki_chan_1.vrm");

                // ----

                gf.Load(@"白魔道士てきとうv2.04.vrm");
                tm.Load(gf.ChunkList);


            }
            catch (Exception e)
            {
                Logging.Write(Logging.ExceptionToList(e), LogType.Error);
            }

        }
    }
}
