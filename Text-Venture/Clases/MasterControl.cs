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
        public static RichTextBox displayStatus;
        public static RichTextBox consolaxd;
        public static TextBox input;
        public ReadWrite IOC;
        public Player player;
        public Dictionary<string,BigCity> locs;

        public MasterControl(ref PictureBox picBx, ref RichTextBox lst, ref RichTextBox rtbx, ref TextBox nput)
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
            this.player = new Player("", 100, "It's you!", "");
            player.Status.SetTextoBox(ref displayStatus);
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
            //IList<Newtonsoft.Json.Linq.JToken> exits = bigcities["data"]["city"]["possExits"].Children().ToList();
            foreach (Newtonsoft.Json.Linq.JToken res in results)
            {
                BigCity bc = res.ToObject<BigCity>();
                //foreach (Newtonsoft.Json.Linq.JToken[] exit in results)
                //{
                //    bc.possExits.Add(exit.ToString());
                //}
                locs.Add(bc.NAME, bc);
            }
            locs["los angeles"].SetFilePath(@"..\..\Recursos\LosAngeles.jpg");
            locs["san antonio"].SetFilePath(@"..\..\Recursos\SanAntonio.jpg");
            locs["new orleans"].SetFilePath(@"..\..\Recursos\NewOrleans.jpg");
        }
    }
}
