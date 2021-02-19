using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinformDictionary_Test1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Program.DataTrans();
            Application.Run(new fIntro());
        }

        //static public void DataTrans()
        //{
        //    System.IO.FileStream fs1 = new System.IO.FileStream(@"C:\ProjectVisualStudio2019\WinformDictionary_Test1\dataE.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.None);
        //    StreamReader sw1 = new StreamReader(fs1);
        //    System.IO.FileStream fs2 = new System.IO.FileStream(@"C:\ProjectVisualStudio2019\WinformDictionary_Test1\dataV.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.None);
        //    StreamReader sw2 = new StreamReader(fs2);

        //    string Tu = sw1.ReadLine();
        //    string Nghia = sw2.ReadLine();

        //    while (Tu != null && Nghia != null)
        //    {
        //        Word a = new Word(Tu, Nghia);
        //        ListWord.LWord.Add(a);
        //    }
            
        //    sw1.Close();
        //    fs1.Close();
        //    sw2.Close();
        //    fs2.Close();
        //}
    }
}
