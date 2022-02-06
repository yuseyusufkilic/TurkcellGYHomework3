using System;
using System.Collections.Generic;

namespace WarSimulator
{
    class Program
    {
        /* 
        -- Birebir ve savaş modu olan 2 tipte savaş simülatörü.
        -- 
       
         */



        static void Main(string[] args)
        {
            /* Savaş modu */

            var AK47 = new AK47();
            var M4A1 = new M4A1();
            var Knife = new Knife();


            List<Soldier> ArmyYuse = new List<Soldier>();
            ArmyYuse.Add(new Soldier { SoldierID = "0", Weapon = AK47 });
            ArmyYuse.Add(new Soldier { SoldierID = "1", Weapon = M4A1 });
          
           
            

            List<Soldier> ArmyTürkay = new List<Soldier>();
            ArmyTürkay.Add(new Soldier { SoldierID = "2", Weapon = Knife });
            ArmyTürkay.Add(new Soldier { SoldierID = "3", Weapon = M4A1 });
          
            
            

            ArmyBattle BigBattle = new ArmyBattle();

            BigBattle.ArmyBattles(ArmyYuse,ArmyTürkay);



            
            /*  1v1 mode */

            //Soldier yuse = new Soldier { SoldierID = "0", Weapon = M4A1};
            //Soldier türkay = new Soldier { SoldierID = "1", Weapon=AK47 };

            //yuse.Attack(türkay);
        }
    }
}
