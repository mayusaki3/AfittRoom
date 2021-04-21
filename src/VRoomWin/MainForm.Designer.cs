
namespace VRoomWin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtInVrm = new System.Windows.Forms.TextBox();
            this.btnInOpn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutVrm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOutOpn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "入力VRM：";
            // 
            // txtInVrm
            // 
            this.txtInVrm.Location = new System.Drawing.Point(86, 48);
            this.txtInVrm.Name = "txtInVrm";
            this.txtInVrm.Size = new System.Drawing.Size(534, 23);
            this.txtInVrm.TabIndex = 1;
            // 
            // btnInOpn
            // 
            this.btnInOpn.Location = new System.Drawing.Point(626, 48);
            this.btnInOpn.Name = "btnInOpn";
            this.btnInOpn.Size = new System.Drawing.Size(29, 23);
            this.btnInOpn.TabIndex = 2;
            this.btnInOpn.Text = "...";
            this.btnInOpn.UseVisualStyleBackColor = true;
            this.btnInOpn.Click += new System.EventHandler(this.BtnInOpn_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(681, 47);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "ロード";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 159);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(776, 279);
            this.txtLog.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "出力VRM：";
            // 
            // txtOutVrm
            // 
            this.txtOutVrm.Location = new System.Drawing.Point(86, 79);
            this.txtOutVrm.Name = "txtOutVrm";
            this.txtOutVrm.Size = new System.Drawing.Size(534, 23);
            this.txtOutVrm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "実行ログ：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(681, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "セーブ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnOutOpn
            // 
            this.btnOutOpn.Location = new System.Drawing.Point(626, 77);
            this.btnOutOpn.Name = "btnOutOpn";
            this.btnOutOpn.Size = new System.Drawing.Size(29, 23);
            this.btnOutOpn.TabIndex = 9;
            this.btnOutOpn.Text = "...";
            this.btnOutOpn.UseVisualStyleBackColor = true;
            this.btnOutOpn.Click += new System.EventHandler(this.BtnOutOpn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnOutOpn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutVrm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnInOpn);
            this.Controls.Add(this.txtInVrm);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "TEST";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInVrm;
        private System.Windows.Forms.Button btnInOpn;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutVrm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOutOpn;
    }
}