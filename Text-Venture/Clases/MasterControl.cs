using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Venture.Clases
{
    class MasterControl
    {
        public static EDifficulty difficulty;
        public static PictureBox displayImg;
        public static ListBox displayStatus;
        public static RichTextBox consolaxd;
        public static TextBox input;
        private int DayCount;
        public ReadWrite IOC;

        public MasterControl(ref PictureBox picBx, ref ListBox lst, ref RichTextBox rtbx, ref TextBox nput)
        {
            displayImg = picBx;
            displayStatus = lst;
            consolaxd = rtbx;
            input = nput; 
        }
        
        public void Startup()
        {
            IOC = new ReadWrite(ref consolaxd, ref input);
            Menu();
        }

        private void Menu()
        {
            ReadWrite.ImprimirMenu();
        }

    }
}
