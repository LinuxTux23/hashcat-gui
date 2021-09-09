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
    public partial class frm_error : Form
    {
        public frm_error(string error)
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
            lbl_error.Text = error;

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
