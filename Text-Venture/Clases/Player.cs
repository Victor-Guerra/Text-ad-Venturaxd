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

        

        public Player(string name, int hp, int atk, int def, string description, string file) : base(name, hp, atk, def, description, file)
        {
            this.HealthPoints = 100;
            this.FoodLvl = 100;
            this.HydrationLvl = 100;

        }

        public void drink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public void eat(Food food)
        {
            throw new NotImplementedException();
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
    }
}
