using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Text_Venture.Clases
{
    public class StatusHandler : IStatus
    {
        private static System.Windows.Forms.RichTextBox Status;
        
        
        private Dictionary<string, int> Bars;
        private Location location;
        public StatusHandler(ref int ammo, ref int gasoline, ref int hunger, ref int thirst, ref int HP, ref Location location)
        {
            Bars = new Dictionary<string, int>()
            {
                {"ammo", ammo },
                {"gas", gasoline },
                { "food", hunger},
                { "water", thirst},
                { "hp", HP}
            };

            this.location = location;
        }

        private string ToBarra(string name)
        {
            int fuera;
            Bars.TryGetValue(name, out fuera);
            fuera /= 10;
            return "[" + '>' * (fuera) + (10 - fuera) * ' ' + "]";
        }
      

        public void SetTextoBox(ref RichTextBox rt)
        {
            Status = rt;
        }
        public void CheckAlive(ref bool isAlive)
        {
            throw new NotImplementedException();
        }

        private void Print(Color color, string str)
        {
            Status.AppendText(str + '\n');
            Status.SelectAll();
            Status.SelectionAlignment = HorizontalAlignment.Left;
            Status.SelectionColor = color;
        }

        public void UpdateStatus()
        {
            Status.Clear();
            Print(Color.White, location.NAME);
            Print(Color.LemonChiffon, "HP : <" + Bars["hp"] + "/100>");
            Print(Color.LemonChiffon, ToBarra("hp"));

            Print(Color.Tomato, "FOOD : <" + Bars["food"] + "/100>");
            Print(Color.Tomato, ToBarra("food"));

            Print(Color.LightBlue, "WATER : <" + Bars["water"] + "/100>");
            Print(Color.LightBlue, ToBarra("water"));

            Print(Color.Wheat, "GAS : <" + Bars["gas"] + "/100>");
            Print(Color.Wheat, ToBarra("gas"));

            Print(Color.Silver, "AMMO : <" + Bars["ammo"] + "/100>");
            Print(Color.Silver, ToBarra("ammo"));
        }
    }
}
