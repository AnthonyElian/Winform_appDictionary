using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDictionary_Test1
{
    public partial class fSEEK : Form
    {
        public fSEEK()
        {
            InitializeComponent();
            this.comboBox1.DataSource = ListWord.LWord;
            this.comboBox1.DisplayMember = "sTu";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Word a = cb.SelectedValue as Word;
                this.textBox1.Text = a.SNghia.ToString();
            }
        }

        private void fSEEK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
