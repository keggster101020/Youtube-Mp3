namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.youtube_url = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.download = new System.Windows.Forms.Button();
            this.downloadBrowser = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // youtube_url
            // 
            this.youtube_url.Location = new System.Drawing.Point(78, 195);
            this.youtube_url.Name = "youtube_url";
            this.youtube_url.Size = new System.Drawing.Size(484, 20);
            this.youtube_url.TabIndex = 0;
            this.youtube_url.Text = "Enter Youtube URL (note, no videos longer than 20min)";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(568, 193);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 1;
            this.Convert.Text = "&Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(78, 221);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(121, 86);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // download
            // 
            this.download.Enabled = false;
            this.download.Location = new System.Drawing.Point(660, 193);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 4;
            this.download.Text = "&Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // downloadBrowser
            // 
            this.downloadBrowser.Location = new System.Drawing.Point(587, 240);
            this.downloadBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.downloadBrowser.Name = "downloadBrowser";
            this.downloadBrowser.Size = new System.Drawing.Size(172, 200);
            this.downloadBrowser.TabIndex = 5;
            this.downloadBrowser.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(739, 193);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 7;
            this.New.Text = "&New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 485);
            this.Controls.Add(this.New);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadBrowser);
            this.Controls.Add(this.download);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.youtube_url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox youtube_url;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.WebBrowser downloadBrowser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button New;
    }
}

