using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    class MasterControl
    {
        public static EDifficulty difficulty;
        public System.Windows.Forms.PictureBox displayImg;
        public System.Windows.Forms.ListBox displayStatus;
        public System.Windows.Forms.RichTextBox consolaxd;
        public System.Windows.Forms.TextBox input;
        private int DayCount;

        public MasterControl(ref System.Windows.Forms.PictureBox picBx, ref System.Windows.Forms.ListBox lst, ref System.Windows.Forms.RichTextBox rtbx, ref System.Windows.Forms.TextBox input)
        {
            displayImg = picBx;
            displayStatus = lst;
            consolaxd = rtbx;
            this.input = input; 
        }
        
        public void Startup()
        {
            ReadWrite.ImprimirMenu(ref consolaxd);
        }


    }
}
