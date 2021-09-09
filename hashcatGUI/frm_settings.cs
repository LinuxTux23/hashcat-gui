using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashcatGUI
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.BackColor = Color.FromArgb(51, 51, 51);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // pn_top Style
            pn_top.ForeColor = Color.FromArgb(72, 127, 72);
            pn_top.BackColor = Color.FromArgb(0, 0, 0);

            // btn_close Style
            btn_close.ForeColor = Color.FromArgb(0, 0, 0);
            btn_close.BackColor = Color.FromArgb(89, 51, 51);
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.FlatAppearance.BorderSize = 1;

            // btn_minimize Style
            btn_minimize.ForeColor = Color.FromArgb(0, 0, 0);
            btn_minimize.BackColor = Color.FromArgb(72, 127, 72);
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 1;

            // rb_bruteforce Style
            rb_bruteforce.ForeColor = Color.FromArgb(72, 127, 72);

            // rb_gpu Style
            rb_gpu.ForeColor = Color.FromArgb(72, 127, 72);

            // rb_apu Style
            rb_apu.ForeColor = Color.FromArgb(72, 127, 72);

            // rb_cpu Style
            rb_cpu.ForeColor = Color.FromArgb(72, 127, 72);

            // rb_straight Style
            rb_straight.ForeColor = Color.FromArgb(72, 127, 72);

            // rb_wordlist Style
            rb_wordlist.ForeColor = Color.FromArgb(72, 127, 72);

            // gb_attackmode Style
            gb_attackmode.ForeColor = Color.FromArgb(72, 127, 72);

            // gb_useddevice Style
            gb_useddevice.ForeColor = Color.FromArgb(72, 127, 72);


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
