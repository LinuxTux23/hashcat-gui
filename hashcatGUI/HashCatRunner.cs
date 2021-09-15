using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using MiscUtil.IO;

namespace hashcatGUI
{
    class HashCatRunner
    {

        public byte? AttackMode { get; set; }
        public byte? Device { get; set; }

        public HashCatRunner() { }

        public string BuildString()
        {
            return "";
        }

        //Process p = new Process();
        //ProcessStartInfo psi = new ProcessStartInfo();
        //psi.FileName = "cmd.exe";
        //psi.WorkingDirectory = tb_exe.Text;
        ////MessageBox.Show(psi.FileName);
        //psi.Arguments = "/c hashcat.exe " + tb_hash.Text + " example.dict -m 0 --attack-mode 0 --potfile-disable -d 1 example.dict";
        //psi.RedirectStandardError = true;
        //psi.RedirectStandardOutput = true;
        //psi.UseShellExecute = false;
        //p.StartInfo = psi;

        //p.Start();
        //string error = p.StandardError.ReadToEnd();
        //string output = p.StandardOutput.ReadToEnd();
        //this.output = output;
        //lbl_output.Text = output;


        //p.WaitForExit();

        //foreach (string line in new LineReader(() => new StringReader(this.output)))
        //{
        //    if (line.StartsWith(tb_hash.Text))
        //    {
        //        this.crackedHash = line;
        //    }
        //}
    }
}
