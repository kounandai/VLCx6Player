namespace VlcTest2
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRate2 = new System.Windows.Forms.Button();
            this.btnRate1 = new System.Windows.Forms.Button();
            this.btnRate05 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(12, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(776, 328);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(324, 393);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 45);
            this.stop.TabIndex = 1;
            this.stop.Text = "PLAY";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(405, 393);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 45);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(702, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRate2
            // 
            this.btnRate2.Location = new System.Drawing.Point(523, 356);
            this.btnRate2.Name = "btnRate2";
            this.btnRate2.Size = new System.Drawing.Size(60, 23);
            this.btnRate2.TabIndex = 4;
            this.btnRate2.Text = "x2";
            this.btnRate2.UseVisualStyleBackColor = true;
            this.btnRate2.Click += new System.EventHandler(this.btnRate2_Click);
            // 
            // btnRate1
            // 
            this.btnRate1.Location = new System.Drawing.Point(523, 385);
            this.btnRate1.Name = "btnRate1";
            this.btnRate1.Size = new System.Drawing.Size(60, 23);
            this.btnRate1.TabIndex = 5;
            this.btnRate1.Text = "x1";
            this.btnRate1.UseVisualStyleBackColor = true;
            this.btnRate1.Click += new System.EventHandler(this.btnRate1_Click);
            // 
            // btnRate05
            // 
            this.btnRate05.Location = new System.Drawing.Point(523, 414);
            this.btnRate05.Name = "btnRate05";
            this.btnRate05.Size = new System.Drawing.Size(60, 23);
            this.btnRate05.TabIndex = 6;
            this.btnRate05.Text = "x1/2";
            this.btnRate05.UseVisualStyleBackColor = true;
            this.btnRate05.Click += new System.EventHandler(this.btnRate05_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRate05);
            this.Controls.Add(this.btnRate1);
            this.Controls.Add(this.btnRate2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.vlcControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRate2;
        private System.Windows.Forms.Button btnRate1;
        private System.Windows.Forms.Button btnRate05;
    }
}

