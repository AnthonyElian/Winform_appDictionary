//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WinformDictionary_Test1
//{
//    public class SpeakText
//    {
//        private WebBrowser wbWeb;

//        public WebBrowser WbWeb
//        {
//            get { return this.wbWeb; }
//            set { this.wbWeb = value; }
//        }

//        public SpeakText(WebBrowser wb)
//        {
//            this.wbWeb = wb;
//        }

//        private void SetText(string data)
//        {
//            HtmlElement element = WbWeb.Document.GetElementById("text");
//            element.SetAttribute("value", data);
//        }

//        private void Speak()
//        {
//            HtmlElement element = wbWeb.Document.GetElementById("playbutton");
//            element.InvokeMember("click");
//        }

//        public void Speak(string data)
//        {
//            SetText(data);
//            Speak();
//        }
//    }
//}
