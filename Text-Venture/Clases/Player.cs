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
        public Location location;
        public int FoodLvl, HydrationLvl, ammo, gasoline;
        private List<Medkit> medkitsLeft;
        
        

        public Player(string name, int hp, string description, string file) : base(name, hp, description, file)
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
            try
            {
                this.location = Game.MC.locs[PlaceName];
            }
            catch (NullReferenceException)
            {
                this.location = Game.MC.locs[this.location.NAME].buildings[PlaceName];
            }
            Game.MC.locs[PlaceName].playerIsHere = true;
            //Game.MC.locs[location.NAME].buildings[PlaceName].playerIsHere = true;
        }

        public void use(Resource resource)
        {
            resource.onUse(resource.Value, ref Game.MC.player);
        }

        public void examine<T>(T item, ref RichTextBox consola)
        {
            throw new NotImplementedException();
        }
        
        public void look_around()
        {
            return;
        }

        public void Attack(ref Character c, int accuracy)
        {
            throw new NotImplementedException();
        }

        public int AbscondChance(EDifficulty diff)
        {
            throw new NotImplementedException();
        }

        public void take<T>(T item)where T: Resource
        {
            item.onUse(item.Value, ref Game.MC.player);
        }
    }
}
