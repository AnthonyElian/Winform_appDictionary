using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformDictionary_Test1
{
     static class ListWord
     {
        static private List<Word> lWord;

        public static List<Word> LWord { get => lWord; set => lWord = value; }

        static ListWord()
        {
            ListWord.lWord = new List<Word>();
        }
    }
}
