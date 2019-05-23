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
        public StatusHandler Status {get => status; }
        public Location location;
        public int FoodLvl, HydrationLvl, ammo, gasoline;
        private List<Resource> Inventory;
        
        

        public Player(string name, int hp, string description, string file) : base(name, hp, description, file)
        {
            this.HealthPoints = 100;
            this.FoodLvl = 100;
            this.HydrationLvl = 100;
            status = new StatusHandler(ref ammo,ref gasoline, ref FoodLvl, ref HydrationLvl, ref this.HealthPoints, ref this.location);
            Inventory = new List<Resource>(10);
            Inventory.Add(new Medkit(EResourceSize.MEDIUM));
        }

        [Commandos("go to")]
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
            if(Game.MC.locs[PlaceName].playerIsHere == true)
            {
                Game.MC.locs[location.NAME].buildings[PlaceName].playerIsHere = true;
            }
            else
            {
                Game.MC.locs[PlaceName].playerIsHere = true;
            }
            //        
        }

        [Commandos("use")]
        public void use(Resource resource)
        {
        resource.onUse(resource.Value, ref Game.MC.player);
        }

        [Commandos("examine")]
        public void examine<T>(T item, ref RichTextBox consola)
        {
            throw new NotImplementedException();
        }
        
        [Commandos("look around")]
        public void look_around()
        {
            return;
        }

        [Commandos("attack")]
        public new void Attack(ref Character c, int accuracy)
        {
            throw new NotImplementedException();
        }

        [Commandos("abscond")]
        public new int AbscondChance(EDifficulty diff)
        {
            throw new NotImplementedException();
        }

        [Commandos("take")]
        public void take<T>(T item)where T: Resource
        {
            item.onUse(item.Value, ref Game.MC.player);
        }
    }
}
