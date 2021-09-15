
namespace hashcatGUI
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pn_top = new System.Windows.Forms.Panel();
            this.gb_attackmode = new System.Windows.Forms.GroupBox();
            this.rb_bruteforce = new System.Windows.Forms.RadioButton();
            this.rb_wordlist = new System.Windows.Forms.RadioButton();
            this.gb_useddevice = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_desCpu = new System.Windows.Forms.Label();
            this.rb_gpu = new System.Windows.Forms.RadioButton();
            this.rb_cpu = new System.Windows.Forms.RadioButton();
            this.btn_apply = new System.Windows.Forms.Button();
            this.pn_top.SuspendLayout();
            this.gb_attackmode.SuspendLayout();
            this.gb_useddevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_minimize
            // 
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Location = new System.Drawing.Point(561, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(91, 32);
            this.btn_minimize.TabIndex = 12;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(658, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 32);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_top
            // 
            this.pn_top.Controls.Add(this.btn_minimize);
            this.pn_top.Controls.Add(this.btn_close);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(762, 47);
            this.pn_top.TabIndex = 12;
            // 
            // gb_attackmode
            // 
            this.gb_attackmode.Controls.Add(this.rb_bruteforce);
            this.gb_attackmode.Controls.Add(this.rb_wordlist);
            this.gb_attackmode.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.gb_attackmode.Location = new System.Drawing.Point(49, 64);
            this.gb_attackmode.Name = "gb_attackmode";
            this.gb_attackmode.Size = new System.Drawing.Size(292, 262);
            this.gb_attackmode.TabIndex = 16;
            this.gb_attackmode.TabStop = false;
            this.gb_attackmode.Text = "Attack Mode";
            // 
            // rb_bruteforce
            // 
            this.rb_bruteforce.AutoSize = true;
            this.rb_bruteforce.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_bruteforce.Location = new System.Drawing.Point(35, 187);
            this.rb_bruteforce.Name = "rb_bruteforce";
            this.rb_bruteforce.Size = new System.Drawing.Size(186, 35);
            this.rb_bruteforce.TabIndex = 15;
            this.rb_bruteforce.Text = "Brute Force";
            this.rb_bruteforce.UseVisualStyleBackColor = true;
            this.rb_bruteforce.CheckedChanged += new System.EventHandler(this.attackMode_Changed);
            // 
            // rb_wordlist
            // 
            this.rb_wordlist.AutoSize = true;
            this.rb_wordlist.Checked = true;
            this.rb_wordlist.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_wordlist.Location = new System.Drawing.Point(35, 59);
            this.rb_wordlist.Name = "rb_wordlist";
            this.rb_wordlist.Size = new System.Drawing.Size(158, 35);
            this.rb_wordlist.TabIndex = 14;
            this.rb_wordlist.TabStop = true;
            this.rb_wordlist.Text = "Word List";
            this.rb_wordlist.UseVisualStyleBackColor = true;
            this.rb_wordlist.CheckedChanged += new System.EventHandler(this.attackMode_Changed);
            // 
            // gb_useddevice
            // 
            this.gb_useddevice.Controls.Add(this.label1);
            this.gb_useddevice.Controls.Add(this.lbl_desCpu);
            this.gb_useddevice.Controls.Add(this.rb_gpu);
            this.gb_useddevice.Controls.Add(this.rb_cpu);
            this.gb_useddevice.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.gb_useddevice.Location = new System.Drawing.Point(414, 64);
            this.gb_useddevice.Name = "gb_useddevice";
            this.gb_useddevice.Size = new System.Drawing.Size(292, 262);
            this.gb_useddevice.TabIndex = 17;
            this.gb_useddevice.TabStop = false;
            this.gb_useddevice.Text = "Used Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Recommended for HIGH profile PCs";
            // 
            // lbl_desCpu
            // 
            this.lbl_desCpu.AutoSize = true;
            this.lbl_desCpu.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desCpu.Location = new System.Drawing.Point(18, 89);
            this.lbl_desCpu.Name = "lbl_desCpu";
            this.lbl_desCpu.Size = new System.Drawing.Size(256, 17);
            this.lbl_desCpu.TabIndex = 15;
            this.lbl_desCpu.Text = "Recommended for LOW profile PCs";
            // 
            // rb_gpu
            // 
            this.rb_gpu.AutoSize = true;
            this.rb_gpu.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_gpu.Location = new System.Drawing.Point(35, 163);
            this.rb_gpu.Name = "rb_gpu";
            this.rb_gpu.Size = new System.Drawing.Size(74, 35);
            this.rb_gpu.TabIndex = 14;
            this.rb_gpu.Text = "GPU";
            this.rb_gpu.UseVisualStyleBackColor = true;
            this.rb_gpu.CheckedChanged += new System.EventHandler(this.usedDevice_Changed);
            // 
            // rb_cpu
            // 
            this.rb_cpu.AutoSize = true;
            this.rb_cpu.Checked = true;
            this.rb_cpu.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_cpu.Location = new System.Drawing.Point(35, 51);
            this.rb_cpu.Name = "rb_cpu";
            this.rb_cpu.Size = new System.Drawing.Size(74, 35);
            this.rb_cpu.TabIndex = 13;
            this.rb_cpu.TabStop = true;
            this.rb_cpu.Text = "CPU";
            this.rb_cpu.UseVisualStyleBackColor = true;
            this.rb_cpu.CheckedChanged += new System.EventHandler(this.usedDevice_Changed);
            // 
            // btn_apply
            // 
            this.btn_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apply.Font = new System.Drawing.Font("Source Code Pro", 18F, System.Drawing.FontStyle.Bold);
            this.btn_apply.Location = new System.Drawing.Point(303, 367);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(159, 44);
            this.btn_apply.TabIndex = 18;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 448);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.gb_useddevice);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.gb_attackmode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_settings";
            this.Text = "Settings";
            this.pn_top.ResumeLayout(false);
            this.gb_attackmode.ResumeLayout(false);
            this.gb_attackmode.PerformLayout();
            this.gb_useddevice.ResumeLayout(false);
            this.gb_useddevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.GroupBox gb_attackmode;
        private System.Windows.Forms.RadioButton rb_bruteforce;
        private System.Windows.Forms.RadioButton rb_wordlist;
        private System.Windows.Forms.GroupBox gb_useddevice;
        private System.Windows.Forms.RadioButton rb_gpu;
        private System.Windows.Forms.RadioButton rb_cpu;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_desCpu;
        private System.Windows.Forms.Label label1;
    }
}