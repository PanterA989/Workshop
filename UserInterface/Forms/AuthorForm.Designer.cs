
namespace Workshop.UserInterface.Forms
{
    partial class AuthorForm
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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelGithub = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.linkMail = new System.Windows.Forms.LinkLabel();
            this.linkGit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(13, 13);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(35, 13);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Autor:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(13, 30);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(38, 13);
            this.labelMail.TabIndex = 1;
            this.labelMail.Text = "E-mail:";
            // 
            // labelGithub
            // 
            this.labelGithub.AutoSize = true;
            this.labelGithub.Location = new System.Drawing.Point(13, 47);
            this.labelGithub.Name = "labelGithub";
            this.labelGithub.Size = new System.Drawing.Size(23, 13);
            this.labelGithub.TabIndex = 2;
            this.labelGithub.Text = "Git:";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(55, 13);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(79, 13);
            this.labelAuthorName.TabIndex = 3;
            this.labelAuthorName.Text = "Krzysztof Kania";
            // 
            // linkMail
            // 
            this.linkMail.AutoSize = true;
            this.linkMail.Location = new System.Drawing.Point(55, 30);
            this.linkMail.Name = "linkMail";
            this.linkMail.Size = new System.Drawing.Size(147, 13);
            this.linkMail.TabIndex = 4;
            this.linkMail.TabStop = true;
            this.linkMail.Text = "krzysztof.kania98@gmail.com";
            this.linkMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMail_LinkClicked);
            // 
            // linkGit
            // 
            this.linkGit.AutoSize = true;
            this.linkGit.Location = new System.Drawing.Point(55, 47);
            this.linkGit.Name = "linkGit";
            this.linkGit.Size = new System.Drawing.Size(156, 13);
            this.linkGit.TabIndex = 5;
            this.linkGit.TabStop = true;
            this.linkGit.Text = "https://github.com/PanterA989";
            this.linkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGit_LinkClicked);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 74);
            this.Controls.Add(this.linkGit);
            this.Controls.Add(this.linkMail);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelGithub);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(239, 113);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(239, 113);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelGithub;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.LinkLabel linkMail;
        private System.Windows.Forms.LinkLabel linkGit;
    }
}