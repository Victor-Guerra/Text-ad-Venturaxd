using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Text_Venture.Clases
{
    public class MasterControl
    {
        public static EDifficulty difficulty;
        public static PictureBox displayImg;
        public static ListBox displayStatus;
        public static RichTextBox consolaxd;
        public static TextBox input;
        private int DayCount;
        public ReadWrite IOC;
        public Player player;
        private List<Location> locations;

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

        public void LoadLocations()
        {
            
        }
    }
}
