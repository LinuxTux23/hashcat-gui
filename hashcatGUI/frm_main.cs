using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MiscUtil.IO;


namespace hashcatGUI
{
    public partial class frm_main : Form
    {

        public string output;
        private string hash;
        private string crackedHash;

        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            var md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                this.hash = sb.ToString();
                return sb.ToString();
        }

        public frm_main()
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

            // btn_crack Style
            btn_crack.ForeColor = Color.FromArgb(72, 127, 72);
            btn_crack.BackColor = Color.FromArgb(0, 0, 0);
            btn_crack.FlatStyle = FlatStyle.Flat;
            btn_crack.FlatAppearance.BorderSize = 1;

            // btn_output_new Style
            btn_output_new.ForeColor = Color.FromArgb(72, 127, 72);
            btn_output_new.BackColor = Color.FromArgb(0, 0, 0);
            btn_output_new.FlatStyle = FlatStyle.Flat;
            btn_output_new.FlatAppearance.BorderSize = 1;

            // tb_exe Style
            tb_exe.ForeColor = Color.FromArgb(72, 127, 72);
            tb_exe.BackColor = Color.FromArgb(0, 0, 0);

            // tb_hash Style
            tb_hash.ForeColor = Color.FromArgb(72, 127, 72);
            tb_hash.BackColor = Color.FromArgb(0, 0, 0);

            // tb_password Style
            tb_password.ForeColor = Color.FromArgb(72, 127, 72);
            tb_password.BackColor = Color.FromArgb(0, 0, 0);

            // lbl_exe Style
            lbl_exe.ForeColor = Color.FromArgb(72, 127, 72);

            // lbl_hash Style
            lbl_hash.ForeColor = Color.FromArgb(72, 127, 72);

            // lbl_password Style
            lbl_password.ForeColor = Color.FromArgb(72, 127, 72);

            // pn_output Style
            pn_output.ForeColor = Color.FromArgb(72, 127, 72);
            pn_output.BackColor = Color.FromArgb(0, 0, 0);

            // lbl_msg Style
            lbl_msg.ForeColor = Color.FromArgb(72, 127, 72);

            // pic_github Style
            pic_github.BackColor = Color.FromArgb(72, 127, 72);

            // lbl_github Style
            lbl_github.ForeColor = Color.FromArgb(72, 127, 72);

            // btn_settings Style
            btn_settings.ForeColor = Color.FromArgb(0, 0, 0);
            btn_settings.BackColor = Color.FromArgb(72, 127, 72);
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.FlatAppearance.BorderSize = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == string.Empty)
            {
                var errorForm = new frm_error("Please insert a Password!");
                errorForm.Show();
            }
            else
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.WorkingDirectory = tb_exe.Text;
                //MessageBox.Show(psi.FileName);
                psi.Arguments = "/c hashcat.exe " + tb_hash.Text + " example.dict -m 0 --attack-mode 0 --potfile-disable -d 1 example.dict";
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                p.StartInfo = psi;

                p.Start();
                string error = p.StandardError.ReadToEnd();
                string output = p.StandardOutput.ReadToEnd();
                this.output = output;
                lbl_output.Text = output;


                p.WaitForExit();

                foreach (string line in new LineReader(() => new StringReader(this.output)))
                {
                    if (line.StartsWith(tb_hash.Text))
                    {
                        this.crackedHash = line;
                    }
                }

                lbl_msg.Text = this.crackedHash;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_output_new_Click(object sender, EventArgs e)
        {
            var outputWindow = new frm_result(this.output);
            outputWindow.Show();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_hash.Text = this.CreateMD5(tb_password.Text).ToLower();
        }

        private void lbl_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string githubLink = "https://github.com/LinuxTux23";

            try
            {
                System.Diagnostics.Process.Start("Msedge", githubLink);
            }
            catch
            {
                var errorForm = new frm_error("Legacy Mode");
                errorForm.Show();
                System.Diagnostics.Process.Start("IExplore", githubLink);
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new frm_settings();
            settingsForm.Show();
        }
    }
}
