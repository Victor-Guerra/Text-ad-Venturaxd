using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Text_Venture.Clases.ResourcesClases;

namespace Text_Venture.Clases
{
    class Player : Human, ICommands
    {
        private StatusHandler status;
        private Location location;
        public int FoodLvl, HydrationLvl, ammo, gasoline;
        private List<string> Historial;
        private List<Medkit> medkitsLeft;
        

        public Player(string name, int hp, int atk, int def, string description, string file) : base(name, hp, atk, def, description, file)
        {
            this.HealthPoints = 100;
            this.FoodLvl = 100;
            this.HydrationLvl = 100;
            medkitsLeft = new List<Medkit>().Add(new Medkit((EResourceSize)2);

        }

        public void GoTo(string PlaceName)
        {
            throw new NotImplementedException();
        }

        public void heal(Medkit med)
        {
            throw new NotImplementedException();
        }

        public void examine<T>(T item, ref RichTextBox consola)
        {
            throw new NotImplementedException();
        }

        public void scavenge()
        {
            throw new NotImplementedException();
        }

        public void take(Item item)
        {
            throw new NotImplementedException();
        }

        public void look_around()
        {
            throw new NotImplementedException();
        }
    }
}
