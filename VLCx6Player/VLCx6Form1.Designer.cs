namespace VLCx6Player
{
    partial class VLCx6Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.vlcControl2 = new Vlc.DotNet.Forms.VlcControl();
            this.vlcControl3 = new Vlc.DotNet.Forms.VlcControl();
            this.vlcControl4 = new Vlc.DotNet.Forms.VlcControl();
            this.vlcControl5 = new Vlc.DotNet.Forms.VlcControl();
            this.vlcControl6 = new Vlc.DotNet.Forms.VlcControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vlcMediaStats3 = new VLCMediaStats.VLCMediaStats();
            this.vlcMediaStats4 = new VLCMediaStats.VLCMediaStats();
            this.vlcMediaStats5 = new VLCMediaStats.VLCMediaStats();
            this.vlcMediaStats6 = new VLCMediaStats.VLCMediaStats();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl6)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(49, 29);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(320, 240);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // vlcControl2
            // 
            this.vlcControl2.BackColor = System.Drawing.Color.Black;
            this.vlcControl2.Location = new System.Drawing.Point(388, 29);
            this.vlcControl2.Name = "vlcControl2";
            this.vlcControl2.Size = new System.Drawing.Size(320, 240);
            this.vlcControl2.Spu = -1;
            this.vlcControl2.TabIndex = 1;
            this.vlcControl2.Text = "vlcControl2";
            this.vlcControl2.VlcLibDirectory = null;
            this.vlcControl2.VlcMediaplayerOptions = null;
            this.vlcControl2.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // vlcControl3
            // 
            this.vlcControl3.BackColor = System.Drawing.Color.Black;
            this.vlcControl3.Location = new System.Drawing.Point(49, 286);
            this.vlcControl3.Name = "vlcControl3";
            this.vlcControl3.Size = new System.Drawing.Size(320, 240);
            this.vlcControl3.Spu = -1;
            this.vlcControl3.TabIndex = 2;
            this.vlcControl3.Text = "vlcControl3";
            this.vlcControl3.VlcLibDirectory = null;
            this.vlcControl3.VlcMediaplayerOptions = null;
            this.vlcControl3.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // vlcControl4
            // 
            this.vlcControl4.BackColor = System.Drawing.Color.Black;
            this.vlcControl4.Location = new System.Drawing.Point(388, 286);
            this.vlcControl4.Name = "vlcControl4";
            this.vlcControl4.Size = new System.Drawing.Size(320, 240);
            this.vlcControl4.Spu = -1;
            this.vlcControl4.TabIndex = 3;
            this.vlcControl4.Text = "vlcControl4";
            this.vlcControl4.VlcLibDirectory = null;
            this.vlcControl4.VlcMediaplayerOptions = null;
            this.vlcControl4.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // vlcControl5
            // 
            this.vlcControl5.BackColor = System.Drawing.Color.Black;
            this.vlcControl5.Location = new System.Drawing.Point(49, 547);
            this.vlcControl5.Name = "vlcControl5";
            this.vlcControl5.Size = new System.Drawing.Size(320, 240);
            this.vlcControl5.Spu = -1;
            this.vlcControl5.TabIndex = 5;
            this.vlcControl5.Text = "vlcControl5";
            this.vlcControl5.VlcLibDirectory = null;
            this.vlcControl5.VlcMediaplayerOptions = null;
            this.vlcControl5.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // vlcControl6
            // 
            this.vlcControl6.BackColor = System.Drawing.Color.Black;
            this.vlcControl6.Location = new System.Drawing.Point(388, 547);
            this.vlcControl6.Name = "vlcControl6";
            this.vlcControl6.Size = new System.Drawing.Size(320, 240);
            this.vlcControl6.Spu = -1;
            this.vlcControl6.TabIndex = 4;
            this.vlcControl6.Text = "vlcControl6";
            this.vlcControl6.VlcLibDirectory = null;
            this.vlcControl6.VlcMediaplayerOptions = null;
            this.vlcControl6.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vlcMediaStats3
            // 
            this.vlcMediaStats3.Location = new System.Drawing.Point(49, 521);
            this.vlcMediaStats3.Name = "vlcMediaStats3";
            this.vlcMediaStats3.Size = new System.Drawing.Size(320, 20);
            this.vlcMediaStats3.TabIndex = 10;
            // 
            // vlcMediaStats4
            // 
            this.vlcMediaStats4.Location = new System.Drawing.Point(388, 521);
            this.vlcMediaStats4.Name = "vlcMediaStats4";
            this.vlcMediaStats4.Size = new System.Drawing.Size(320, 20);
            this.vlcMediaStats4.TabIndex = 11;
            // 
            // vlcMediaStats5
            // 
            this.vlcMediaStats5.Location = new System.Drawing.Point(49, 784);
            this.vlcMediaStats5.Name = "vlcMediaStats5";
            this.vlcMediaStats5.Size = new System.Drawing.Size(320, 20);
            this.vlcMediaStats5.TabIndex = 12;
            // 
            // vlcMediaStats6
            // 
            this.vlcMediaStats6.Location = new System.Drawing.Point(388, 784);
            this.vlcMediaStats6.Name = "vlcMediaStats6";
            this.vlcMediaStats6.Size = new System.Drawing.Size(320, 20);
            this.vlcMediaStats6.TabIndex = 13;
            // 
            // VLCx6Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(745, 816);
            this.Controls.Add(this.vlcMediaStats6);
            this.Controls.Add(this.vlcMediaStats5);
            this.Controls.Add(this.vlcMediaStats4);
            this.Controls.Add(this.vlcMediaStats3);
            this.Controls.Add(this.vlcControl5);
            this.Controls.Add(this.vlcControl6);
            this.Controls.Add(this.vlcControl4);
            this.Controls.Add(this.vlcControl3);
            this.Controls.Add(this.vlcControl2);
            this.Controls.Add(this.vlcControl1);
            this.Name = "VLCx6Form1";
            this.Text = "VLC x6 Player";
            this.Load += new System.EventHandler(this.VLCx6Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private Vlc.DotNet.Forms.VlcControl vlcControl2;
        private Vlc.DotNet.Forms.VlcControl vlcControl3;
        private Vlc.DotNet.Forms.VlcControl vlcControl4;
        private Vlc.DotNet.Forms.VlcControl vlcControl5;
        private Vlc.DotNet.Forms.VlcControl vlcControl6;
        private System.Windows.Forms.Timer timer1;
        private VLCMediaStats.VLCMediaStats vlcMediaStats3;
        private VLCMediaStats.VLCMediaStats vlcMediaStats4;
        private VLCMediaStats.VLCMediaStats vlcMediaStats5;
        private VLCMediaStats.VLCMediaStats vlcMediaStats6;
    }
}

