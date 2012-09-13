namespace twClient
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
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_tweet = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_tweet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(55, 35);
            this.txt_login.Multiline = true;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(137, 46);
            this.txt_login.TabIndex = 0;
            // 
            // txt_tweet
            // 
            this.txt_tweet.Location = new System.Drawing.Point(55, 106);
            this.txt_tweet.Multiline = true;
            this.txt_tweet.Name = "txt_tweet";
            this.txt_tweet.Size = new System.Drawing.Size(137, 68);
            this.txt_tweet.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(198, 44);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_tweet
            // 
            this.btn_tweet.Location = new System.Drawing.Point(198, 151);
            this.btn_tweet.Name = "btn_tweet";
            this.btn_tweet.Size = new System.Drawing.Size(75, 23);
            this.btn_tweet.TabIndex = 3;
            this.btn_tweet.Text = "tweet";
            this.btn_tweet.UseVisualStyleBackColor = true;
            this.btn_tweet.Click += new System.EventHandler(this.btn_tweet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 223);
            this.Controls.Add(this.btn_tweet);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_tweet);
            this.Controls.Add(this.txt_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_tweet;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_tweet;
    }
}

