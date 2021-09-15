
namespace hashcatGUI
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_hash = new System.Windows.Forms.TextBox();
            this.btn_crack = new System.Windows.Forms.Button();
            this.tb_exe = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_hash = new System.Windows.Forms.Label();
            this.lbl_exe = new System.Windows.Forms.Label();
            this.pn_top = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.pic_github = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.lbl_github = new System.Windows.Forms.LinkLabel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pn_output = new System.Windows.Forms.Panel();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_output_new = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.pr_pw_lenght = new System.Windows.Forms.ProgressBar();
            this.pn_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_github)).BeginInit();
            this.pn_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Source Code Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(215, 151);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(433, 38);
            this.tb_password.TabIndex = 0;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // tb_hash
            // 
            this.tb_hash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_hash.Font = new System.Drawing.Font("Source Code Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hash.Location = new System.Drawing.Point(215, 241);
            this.tb_hash.Name = "tb_hash";
            this.tb_hash.ReadOnly = true;
            this.tb_hash.Size = new System.Drawing.Size(433, 38);
            this.tb_hash.TabIndex = 2;
            // 
            // btn_crack
            // 
            this.btn_crack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crack.Font = new System.Drawing.Font("Source Code Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crack.Location = new System.Drawing.Point(215, 316);
            this.btn_crack.Name = "btn_crack";
            this.btn_crack.Size = new System.Drawing.Size(433, 58);
            this.btn_crack.TabIndex = 5;
            this.btn_crack.Text = "Crack Hash";
            this.btn_crack.UseVisualStyleBackColor = true;
            this.btn_crack.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_exe
            // 
            this.tb_exe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_exe.CausesValidation = false;
            this.tb_exe.Font = new System.Drawing.Font("Source Code Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_exe.Location = new System.Drawing.Point(215, 75);
            this.tb_exe.Name = "tb_exe";
            this.tb_exe.Size = new System.Drawing.Size(433, 38);
            this.tb_exe.TabIndex = 6;
            this.tb_exe.Text = "C:\\Users\\lohseben\\Downloads\\hashcat-6.2.4";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.lbl_password.Location = new System.Drawing.Point(68, 154);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(126, 31);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            // 
            // lbl_hash
            // 
            this.lbl_hash.AutoSize = true;
            this.lbl_hash.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.lbl_hash.Location = new System.Drawing.Point(68, 248);
            this.lbl_hash.Name = "lbl_hash";
            this.lbl_hash.Size = new System.Drawing.Size(126, 31);
            this.lbl_hash.TabIndex = 8;
            this.lbl_hash.Text = "MD5 Hash";
            // 
            // lbl_exe
            // 
            this.lbl_exe.AutoSize = true;
            this.lbl_exe.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.lbl_exe.Location = new System.Drawing.Point(12, 78);
            this.lbl_exe.Name = "lbl_exe";
            this.lbl_exe.Size = new System.Drawing.Size(182, 31);
            this.lbl_exe.TabIndex = 9;
            this.lbl_exe.Text = "Hash Cat exe";
            // 
            // pn_top
            // 
            this.pn_top.Controls.Add(this.btn_settings);
            this.pn_top.Controls.Add(this.pic_github);
            this.pn_top.Controls.Add(this.btn_minimize);
            this.pn_top.Controls.Add(this.lbl_github);
            this.pn_top.Controls.Add(this.btn_close);
            this.pn_top.Location = new System.Drawing.Point(0, -2);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1260, 46);
            this.pn_top.TabIndex = 10;
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Location = new System.Drawing.Point(12, 5);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(103, 36);
            this.btn_settings.TabIndex = 14;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pic_github
            // 
            this.pic_github.BackColor = System.Drawing.SystemColors.Window;
            this.pic_github.Image = global::hashcatGUI.Properties.Resources.github;
            this.pic_github.Location = new System.Drawing.Point(675, 4);
            this.pic_github.Name = "pic_github";
            this.pic_github.Size = new System.Drawing.Size(41, 37);
            this.pic_github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_github.TabIndex = 15;
            this.pic_github.TabStop = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Location = new System.Drawing.Point(1065, 6);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(91, 32);
            this.btn_minimize.TabIndex = 12;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // lbl_github
            // 
            this.lbl_github.AutoSize = true;
            this.lbl_github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_github.Font = new System.Drawing.Font("Source Code Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_github.LinkColor = System.Drawing.Color.White;
            this.lbl_github.Location = new System.Drawing.Point(725, 7);
            this.lbl_github.Name = "lbl_github";
            this.lbl_github.Size = new System.Drawing.Size(98, 31);
            this.lbl_github.TabIndex = 14;
            this.lbl_github.TabStop = true;
            this.lbl_github.Text = "GitHub";
            this.lbl_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_github_LinkClicked);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(1162, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 32);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_output
            // 
            this.pn_output.AutoScroll = true;
            this.pn_output.Controls.Add(this.lbl_output);
            this.pn_output.Location = new System.Drawing.Point(674, 75);
            this.pn_output.Name = "pn_output";
            this.pn_output.Size = new System.Drawing.Size(555, 344);
            this.pn_output.TabIndex = 11;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Source Code Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(15, 11);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(0, 19);
            this.lbl_output.TabIndex = 0;
            // 
            // btn_output_new
            // 
            this.btn_output_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_output_new.Font = new System.Drawing.Font("Source Code Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_output_new.Location = new System.Drawing.Point(674, 425);
            this.btn_output_new.Name = "btn_output_new";
            this.btn_output_new.Size = new System.Drawing.Size(555, 36);
            this.btn_output_new.TabIndex = 12;
            this.btn_output_new.Text = "Open Output in New Window";
            this.btn_output_new.UseVisualStyleBackColor = true;
            this.btn_output_new.Click += new System.EventHandler(this.btn_output_new_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.lbl_msg.Location = new System.Drawing.Point(68, 472);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 31);
            this.lbl_msg.TabIndex = 13;
            // 
            // pr_pw_lenght
            // 
            this.pr_pw_lenght.Location = new System.Drawing.Point(215, 189);
            this.pr_pw_lenght.Name = "pr_pw_lenght";
            this.pr_pw_lenght.Size = new System.Drawing.Size(433, 23);
            this.pr_pw_lenght.TabIndex = 14;
            // 
            // frm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1260, 545);
            this.Controls.Add(this.pr_pw_lenght);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_output_new);
            this.Controls.Add(this.pn_output);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.lbl_exe);
            this.Controls.Add(this.lbl_hash);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_exe);
            this.Controls.Add(this.btn_crack);
            this.Controls.Add(this.tb_hash);
            this.Controls.Add(this.tb_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.Text = "hash Cat GUI";
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_github)).EndInit();
            this.pn_output.ResumeLayout(false);
            this.pn_output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_hash;
        private System.Windows.Forms.Button btn_crack;
        private System.Windows.Forms.TextBox tb_exe;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_hash;
        private System.Windows.Forms.Label lbl_exe;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel pn_output;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_output_new;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.LinkLabel lbl_github;
        private System.Windows.Forms.PictureBox pic_github;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.ProgressBar pr_pw_lenght;
    }
}

