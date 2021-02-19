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
    public partial class fPRINT : Form
    {
        Button btnTu = new Button();
        public fPRINT()
        {
            InitializeComponent();

            //WebBrowser wbEng = new WebBrowser();
            //wbEng.Width = 0;
            //wbEng.Height = 0;
            //wbEng.Visible = false;
            //wbEng.ScriptErrorsSuppressed = true;
            //wbEng.Navigate(Cons.EnglishLink);

            //this.Controls.Add(wbEng);

          //  Speak = new SpeakText(wbEng);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListWord.LWord.Count == 0)
            {
                MessageBox.Show("No Data !!");
            }
            else
            {
                foreach (var item in ListWord.LWord)
                {
                    //this.ghiFileEnglish(item.STu);
                    //this.ghiFileVietnamese(item.SNghia);
                    Button btnTu = new Button();
                    Button btnNghia = new Button();
                    btnTu.Text = item.STu;
                    btnNghia.Text = item.SNghia;
                    this.flowLayoutPanel1.Controls.Add(btnTu);
                    this.flowLayoutPanel2.Controls.Add(btnNghia);
                    //this.button1.Hide();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel2.Controls.Clear();
        }

        private void fPRINT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
