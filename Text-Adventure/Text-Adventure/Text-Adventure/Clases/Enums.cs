using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure.Clases
{
    static class Enums
    {
        public enum ETypeBuilding {OXXO = 1 , HOUSE, DRUGS,
                               STORE, MECHANIC, GAS_STATION,
                               PLAZA, CAMPSITE };
        //Hola cómo estás buenos tardos
        public enum EDifficulty {EASY = 1, NORMAL = 3, HARD = 6};
        public enum ETier {LOW, MID, HIGH, SUPER };

        public enum EZombieType { NORMAL, ARMLESS, LEGLESSLEGOLEGOLASS };

        public enum EResourceSze {SMALL = 1, MEDIUM, NORMAL };

        public enum ENoisy {SILENT, AUDIBLE, LOUD};
    }
}
