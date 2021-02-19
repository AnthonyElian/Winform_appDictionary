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

namespace WinformDictionary_Test1
{
    public partial class fIntro : Form
    {
        public fIntro()
        {
            //this.ListTu = new List<string>();
            //this.Listnghia = new List<string>();
            InitializeComponent();
            //this.getListTu();
            this.DataTrans();
           
        }

        public List<string> ListTu = new List<string>();
        public List<string> Listnghia = new List<string>();

        public void DataTrans()
        {
            this.getListNghia();
            this.getListTu();
            for (int i = 0; i < this.ListTu.Count; i++)
            {
                Word a = new Word(this.ListTu[i], this.Listnghia[i]);
                ListWord.LWord.Add(a);
            }
        }

        public void getListNghia()
        {
            System.IO.FileStream fs1 = new System.IO.FileStream(@"C:\ProjectVisualStudio2019\WinformDictionary_Test1\dataV.txt", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read, System.IO.FileShare.None);
            StreamReader sw1 = new StreamReader(fs1);

            string Nghia = sw1.ReadLine();

            while (Nghia != null)
            {
                this.Listnghia.Add(Nghia);
                Nghia = sw1.ReadLine();
            }

            sw1.Close();
            fs1.Close();
        }

        public void getListTu()
        {
            System.IO.FileStream fs1 = new System.IO.FileStream(@"C:\ProjectVisualStudio2019\WinformDictionary_Test1\dataE.txt", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read, System.IO.FileShare.None);
            StreamReader sw1 = new StreamReader(fs1);

            string Tu = sw1.ReadLine();

            while (Tu != null)
            {
                this.ListTu.Add(Tu);
                Tu = sw1.ReadLine();
            }

            sw1.Close();
            fs1.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.oxfordlearnersdictionaries.com/");
        }

       

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fIntro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ?!?", "Warning",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fADD formADD = new fADD();
            this.Hide();
            formADD.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fDelete formDEL = new fDelete();
            this.Hide();
            formDEL.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            fSEEK formSEEK = new fSEEK();
            this.Hide();
            formSEEK.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fPRINT formPrint = new fPRINT();
            this.Hide();
            formPrint.ShowDialog();
            this.Show();
        }

        private void fIntro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
