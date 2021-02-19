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
    public partial class fDelete : Form
    {
        public fDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label result = new Label();
            this.panel2.Controls.Clear();
            int flag = -1;
            for (int i = 0; i < ListWord.LWord.Count; i++)
            {
                if (ListWord.LWord[i].STu == this.textBox1.Text.ToString())
                {
                    flag = 0;
                    ListWord.LWord.RemoveAt(i);
                    break;
                }
            }

            result.Font = new System.Drawing.Font("Times New Roman", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (flag == 0)
            {
                foreach (var item in ListWord.LWord)
                {
                    //this.updateFileEnglish(item.STu);
                    //this.updateFileVietnamese(item.SNghia);
                }
                result.Text = "Successfully !!";
                //Random rd = new Random();
                result.Location = new Point(300, 4);
                panel2.Controls.Add(result);
                this.textBox1.ResetText();
            }
            else
            {
                result.Text = "Unsuccessfully !!";
                //Random rd = new Random();
                result.Location = new Point(300, 4);
                panel2.Controls.Add(result);
                this.textBox1.ResetText();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }

        private void fDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
