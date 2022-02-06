using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarSimulator
{
    public class Soldier
    {
        public string SoldierID { get; set; }
        public int LifePoint { get; set; } = 30;
        public Weapon Weapon { get; set; }
        public bool IsAlive { get; set; } = true;

        public void Attack(Soldier soldier) {

            while (IsAlive)
            {
                LifePoint = LifePoint - soldier.Weapon.Damage;
                Console.WriteLine($"Life Point Remains for soldier {SoldierID} : {LifePoint}");
                System.Threading.Thread.Sleep(1000);

                soldier.LifePoint = soldier.LifePoint - Weapon.Damage;
                Console.WriteLine($"Life Point Remains for soldier {soldier.SoldierID} : {soldier.LifePoint}");
                System.Threading.Thread.Sleep(1000);

                if (soldier.LifePoint <= 0)
                {
                    IsAlive = false;
                    Console.WriteLine($"{SoldierID} numaralı asker kazandı.");
                }
                else if (LifePoint <= 0)
                {
                    IsAlive = false;
                    Console.WriteLine($"{soldier.SoldierID} numaralı asker kazandı.");
                }
            }


        }


    }
}
