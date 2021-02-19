using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDictionary_Test1
{
    public partial class fADD : Form
    {
        public fADD()
        {
            InitializeComponent();
        }

        public void ghiFileEnglish(string data)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"C:\ProjectVisualStudio2019\WinformDictionary_Test1\dataE.txt", System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(data);
            //sw.WriteLine(data.SNghia);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void ghiFileVietnamese(string data)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"C:\ProjectVisualStudio2019\WinformDictionary_Test1\dataV.txt", System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(data);
            //sw.WriteLine(data.SNghia);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word a = new Word();
            a.STu = this.textBox1.Text.ToString();
            a.SNghia = this.textBox2.Text.ToString();   
            if (a.STu == "" || a.SNghia == "")
            {
                MessageBox.Show("Unsuccessfully !!", "Status");
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox1.Focus();
            }
            else if(!this.KiemTraInput(a.STu))
            {
                MessageBox.Show("Word already existed !!", "Status");
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox1.Focus();
            }
            else
            {                
                ListWord.LWord.Add(a);
                this.ghiFileEnglish(a.STu);
                this.ghiFileVietnamese(a.SNghia);
                MessageBox.Show("Successfully !!", "Status");
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox1.Focus();
            }
        }

        public bool KiemTraInput(string Tu)
        {
            foreach (var item in ListWord.LWord)
            {
                if (item.STu == Tu)
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }    
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.textBox2.Focus();
            }
        }

        private void fADD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
