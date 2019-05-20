using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Text_Venture.Clases.ResourcesClases;

namespace Text_Venture.Clases
{
    public class Player : Human, ICommands, ICombat
    {
        private StatusHandler status;
        public BigCity location;
        public int FoodLvl, HydrationLvl, ammo, gasoline;
        private List<Medkit> medkitsLeft;
        
        

        public Player(string name, int hp, int atk, int def, string description, string file) : base(name, hp, atk, def, description, file)
        {
            this.HealthPoints = 100;
            this.FoodLvl = 100;
            this.HydrationLvl = 100;
            medkitsLeft = new List<Medkit>();
            medkitsLeft.Add(new Medkit(EResourceSize.MEDIUM));
        }

        public void GoTo(string PlaceName)
        {
            if(this.location != null)
                this.location.playerIsHere = false;
            this.location = Game.MC.locs[PlaceName];
            Game.MC.locs[PlaceName].playerIsHere = true;//TryGetValue(PlaceName,out BigCity value);
        }

        public void use(Resource resource)
        {
            resource.onUse(resource.Value, ref Game.MC.player);
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

        public void Attack(ref Character c, int accuracy)
        {
            throw new NotImplementedException();
        }

        public int AbscondChance(EDifficulty diff)
        {
            throw new NotImplementedException();
        }

        public void take<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
