using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformDictionary_Test1
{
    public class Word
    {
        private string sTu;
        private string sNghia;

        public string STu { get => sTu; set => sTu = value; }
        public string SNghia { get => sNghia; set => sNghia = value; }
        
        public Word() { }

        public Word(string Tu, string Nghia)
        {
            this.sTu = Tu;
            this.sNghia = Nghia;
        }
    }
}
