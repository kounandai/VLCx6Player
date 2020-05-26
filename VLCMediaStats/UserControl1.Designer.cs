namespace VLCMediaStats
{
    partial class VLCMediaStats
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_value_lost = new System.Windows.Forms.Label();
            this.label_lost = new System.Windows.Forms.Label();
            this.label_bitrate = new System.Windows.Forms.Label();
            this.label_value_bitrate = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_value_lost
            // 
            this.label_value_lost.AutoSize = true;
            this.label_value_lost.Location = new System.Drawing.Point(292, 5);
            this.label_value_lost.Name = "label_value_lost";
            this.label_value_lost.Size = new System.Drawing.Size(11, 12);
            this.label_value_lost.TabIndex = 0;
            this.label_value_lost.Text = "0";
            this.label_value_lost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_lost
            // 
            this.label_lost.AutoSize = true;
            this.label_lost.Location = new System.Drawing.Point(247, 5);
            this.label_lost.Name = "label_lost";
            this.label_lost.Size = new System.Drawing.Size(26, 12);
            this.label_lost.TabIndex = 1;
            this.label_lost.Text = "lost:";
            // 
            // label_bitrate
            // 
            this.label_bitrate.AutoSize = true;
            this.label_bitrate.Location = new System.Drawing.Point(132, 4);
            this.label_bitrate.Name = "label_bitrate";
            this.label_bitrate.Size = new System.Drawing.Size(40, 12);
            this.label_bitrate.TabIndex = 3;
            this.label_bitrate.Text = "bitrate:";
            // 
            // label_value_bitrate
            // 
            this.label_value_bitrate.AutoSize = true;
            this.label_value_bitrate.Location = new System.Drawing.Point(177, 4);
            this.label_value_bitrate.Name = "label_value_bitrate";
            this.label_value_bitrate.Size = new System.Drawing.Size(11, 12);
            this.label_value_bitrate.TabIndex = 2;
            this.label_value_bitrate.Text = "0";
            this.label_value_bitrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(48, 5);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(23, 12);
            this.label_size.TabIndex = 4;
            this.label_size.Text = "0x0";
            this.label_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VLCMediaStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_bitrate);
            this.Controls.Add(this.label_value_bitrate);
            this.Controls.Add(this.label_lost);
            this.Controls.Add(this.label_value_lost);
            this.Name = "VLCMediaStats";
            this.Size = new System.Drawing.Size(320, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_value_lost;
        private System.Windows.Forms.Label label_lost;
        private System.Windows.Forms.Label label_bitrate;
        private System.Windows.Forms.Label label_value_bitrate;
        private System.Windows.Forms.Label label_size;
    }
}
