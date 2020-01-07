namespace YahooNews_RSS
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.TopicSelect = new System.Windows.Forms.ComboBox();
            this.NewsView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(434, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(152, 60);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "取得";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(592, 12);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(152, 60);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "リセット";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TopicSelect
            // 
            this.TopicSelect.FormattingEnabled = true;
            this.TopicSelect.Location = new System.Drawing.Point(86, 33);
            this.TopicSelect.Name = "TopicSelect";
            this.TopicSelect.Size = new System.Drawing.Size(121, 20);
            this.TopicSelect.TabIndex = 3;
            // 
            // NewsView
            // 
            this.NewsView.Location = new System.Drawing.Point(12, 78);
            this.NewsView.Name = "NewsView";
            this.NewsView.ReadOnly = true;
            this.NewsView.Size = new System.Drawing.Size(776, 360);
            this.NewsView.TabIndex = 4;
            this.NewsView.Text = "";
            this.NewsView.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.NewsView_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewsView);
            this.Controls.Add(this.TopicSelect);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.ComboBox TopicSelect;
        private System.Windows.Forms.RichTextBox NewsView;
    }
}

