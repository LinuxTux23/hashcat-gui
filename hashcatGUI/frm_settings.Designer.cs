
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
            this.rb_apu = new System.Windows.Forms.RadioButton();
            this.rb_gpu = new System.Windows.Forms.RadioButton();
            this.rb_cpu = new System.Windows.Forms.RadioButton();
            this.rb_straight = new System.Windows.Forms.RadioButton();
            this.pn_top.SuspendLayout();
            this.gb_attackmode.SuspendLayout();
            this.gb_useddevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_minimize
            // 
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
            this.pn_top.Size = new System.Drawing.Size(760, 47);
            this.pn_top.TabIndex = 12;
            // 
            // gb_attackmode
            // 
            this.gb_attackmode.Controls.Add(this.rb_straight);
            this.gb_attackmode.Controls.Add(this.rb_bruteforce);
            this.gb_attackmode.Controls.Add(this.rb_wordlist);
            this.gb_attackmode.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.gb_attackmode.Location = new System.Drawing.Point(49, 64);
            this.gb_attackmode.Name = "gb_attackmode";
            this.gb_attackmode.Size = new System.Drawing.Size(292, 416);
            this.gb_attackmode.TabIndex = 16;
            this.gb_attackmode.TabStop = false;
            this.gb_attackmode.Text = "Attack Mode";
            // 
            // rb_bruteforce
            // 
            this.rb_bruteforce.AutoSize = true;
            this.rb_bruteforce.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_bruteforce.Location = new System.Drawing.Point(35, 291);
            this.rb_bruteforce.Name = "rb_bruteforce";
            this.rb_bruteforce.Size = new System.Drawing.Size(186, 35);
            this.rb_bruteforce.TabIndex = 15;
            this.rb_bruteforce.TabStop = true;
            this.rb_bruteforce.Text = "Brute Force";
            this.rb_bruteforce.UseVisualStyleBackColor = true;
            // 
            // rb_wordlist
            // 
            this.rb_wordlist.AutoSize = true;
            this.rb_wordlist.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_wordlist.Location = new System.Drawing.Point(35, 163);
            this.rb_wordlist.Name = "rb_wordlist";
            this.rb_wordlist.Size = new System.Drawing.Size(158, 35);
            this.rb_wordlist.TabIndex = 14;
            this.rb_wordlist.TabStop = true;
            this.rb_wordlist.Text = "Word List";
            this.rb_wordlist.UseVisualStyleBackColor = true;
            // 
            // gb_useddevice
            // 
            this.gb_useddevice.Controls.Add(this.rb_apu);
            this.gb_useddevice.Controls.Add(this.rb_gpu);
            this.gb_useddevice.Controls.Add(this.rb_cpu);
            this.gb_useddevice.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.gb_useddevice.Location = new System.Drawing.Point(414, 64);
            this.gb_useddevice.Name = "gb_useddevice";
            this.gb_useddevice.Size = new System.Drawing.Size(292, 416);
            this.gb_useddevice.TabIndex = 17;
            this.gb_useddevice.TabStop = false;
            this.gb_useddevice.Text = "Used Device";
            // 
            // rb_apu
            // 
            this.rb_apu.AutoSize = true;
            this.rb_apu.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_apu.Location = new System.Drawing.Point(35, 291);
            this.rb_apu.Name = "rb_apu";
            this.rb_apu.Size = new System.Drawing.Size(74, 35);
            this.rb_apu.TabIndex = 15;
            this.rb_apu.TabStop = true;
            this.rb_apu.Text = "APU";
            this.rb_apu.UseVisualStyleBackColor = true;
            // 
            // rb_gpu
            // 
            this.rb_gpu.AutoSize = true;
            this.rb_gpu.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_gpu.Location = new System.Drawing.Point(35, 163);
            this.rb_gpu.Name = "rb_gpu";
            this.rb_gpu.Size = new System.Drawing.Size(74, 35);
            this.rb_gpu.TabIndex = 14;
            this.rb_gpu.TabStop = true;
            this.rb_gpu.Text = "GPU";
            this.rb_gpu.UseVisualStyleBackColor = true;
            // 
            // rb_cpu
            // 
            this.rb_cpu.AutoSize = true;
            this.rb_cpu.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_cpu.Location = new System.Drawing.Point(35, 51);
            this.rb_cpu.Name = "rb_cpu";
            this.rb_cpu.Size = new System.Drawing.Size(74, 35);
            this.rb_cpu.TabIndex = 13;
            this.rb_cpu.TabStop = true;
            this.rb_cpu.Text = "CPU";
            this.rb_cpu.UseVisualStyleBackColor = true;
            // 
            // rb_straight
            // 
            this.rb_straight.AutoSize = true;
            this.rb_straight.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.rb_straight.Location = new System.Drawing.Point(35, 51);
            this.rb_straight.Name = "rb_straight";
            this.rb_straight.Size = new System.Drawing.Size(144, 35);
            this.rb_straight.TabIndex = 16;
            this.rb_straight.TabStop = true;
            this.rb_straight.Text = "Straight";
            this.rb_straight.UseVisualStyleBackColor = true;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 507);
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
        private System.Windows.Forms.RadioButton rb_apu;
        private System.Windows.Forms.RadioButton rb_gpu;
        private System.Windows.Forms.RadioButton rb_cpu;
        private System.Windows.Forms.RadioButton rb_straight;
    }
}