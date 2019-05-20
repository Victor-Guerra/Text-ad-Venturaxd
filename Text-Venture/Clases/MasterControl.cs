using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using Newtonsoft.Json;

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
        public Dictionary<string,BigCity> locs;

        public MasterControl(ref PictureBox picBx, ref ListBox lst, ref RichTextBox rtbx, ref TextBox nput)
        {
            displayImg = picBx;
            displayStatus = lst;
            consolaxd = rtbx;
            input = nput;
            locs = new Dictionary<string, BigCity>();
        }
        
        public void Startup()
        {
            IOC = new ReadWrite(ref consolaxd, ref input);
            Menu();
            LoadLocations();
            this.player = new Player("", 100, 1, 1, "It's you!", "");
        }

        private void Menu()
        {
            ReadWrite.ImprimirMenu();
        }

        public void LoadLocations()
        {
            string file = System.IO.File.ReadAllText(@"..\..\Recursos\Data.json");
            Newtonsoft.Json.Linq.JObject bigcities = Newtonsoft.Json.Linq.JObject.Parse(file);
            IList<Newtonsoft.Json.Linq.JToken> results = bigcities["data"]["city"].Children().ToList();
            foreach(Newtonsoft.Json.Linq.JToken res in results)
            {
                BigCity bc = res.ToObject<BigCity>();
                locs.Add(bc.NAME, bc);
            }
        }
    }
}
