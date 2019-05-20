using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Venture.Clases
{
    static class ReadWrite
    {
        public static void ImprimirMenu(ref System.Windows.Forms.RichTextBox text)
        {
            string[] str = File.ReadAllLines(@"C:\Users\vcitoremmanuel\Documents\GitHub\Text-ad-Venturaxd\Text-Venture\Recursos\StartMenu.txt");
            
            foreach(string s in str)
            {
                text.AppendText(s + '\n');
            }

            text.SelectAll();
            text.SelectionAlignment = HorizontalAlignment.Center;
            text.Select(0, str[0].Length);
            text.
        }
    }
}
