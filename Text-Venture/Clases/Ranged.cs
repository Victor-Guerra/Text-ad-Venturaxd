using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    class Ranged : Weapon
    {
        private int defaultAmmo;
        private bool isGun;

        public Ranged(string name, string description, string imgFilePath, int atk, int acc, bool isGun) : base(name, description, imgFilePath, atk, acc)
        {
            this.NoiseLvl = isGun ? ENoisy.LOUD : ENoisy.SILENT;
            DefaultAmmo(MasterControl.difficulty);
        }

        private void DefaultAmmo(EDifficulty diff)
        {
            switch ((int)diff)
            {
                case 1:
                    this.defaultAmmo = 10;
                    break;
                case 3:
                    this.defaultAmmo = 6;
                    break;
                case 6:
                    this.defaultAmmo = 3;
                    break;
            }
        }
        //private int SetAmmoMax(EDifficulty diff)
        //{
        //    int w = 0;
        //    switch ((int)diff)
        //    {
        //        case 1:
        //            w = 20;
        //            break;
        //        case 3:
        //            w = 15;
        //            break;
        //        case 6:
        //            w = 10;
        //            break;
        //    }
        //    return w;
        //}
    }
}
