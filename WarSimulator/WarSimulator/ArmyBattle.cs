using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarSimulator
{
    class ArmyBattle:Soldier
    {
        public List<Soldier> Army { get; set; }


        public void ArmyBattles(List<Soldier> army, List<Soldier> army2)
        {

            for (int i = 0; i < army.Count; i++)
            {
                for (int j = 0; j < army2.Count; j++)
                {
                    if (army[i].Weapon.Damage > army2[j].Weapon.Damage && army2[j].Weapon.Damage < army[i].LifePoint)
                    {


                        army[i].LifePoint = army[i].LifePoint - army2[j].Weapon.Damage;
                        Console.WriteLine($"{army[i].SoldierID} wins and Health : {army[i].LifePoint}");
                        army2.RemoveAt(j);
                        j--;
                    }

                    else if (army[i].Weapon.Damage < army2[j].Weapon.Damage || army2[j].Weapon.Damage > army[i].LifePoint)
                    {

                        army2[j].LifePoint = army2[j].LifePoint - army[i].Weapon.Damage;
                        Console.WriteLine($"{army2[j].SoldierID} wins and Health : {army2[j].LifePoint}");
                        army.RemoveAt(i);
                        i--;
                    }

                    else
                    {
                        army[i].LifePoint = army[i].LifePoint - army2[j].Weapon.Damage;
                        army2[j].LifePoint = army2[j].LifePoint - army[i].Weapon.Damage;
                    }

                }

            }



        }

    }

}

