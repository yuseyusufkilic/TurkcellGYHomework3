using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarSimulator
{
    public class Weapon
    {
        public string Type { get; set; }
        public int Damage { get; set; }

        

    }

    public class AK47 : Weapon
    {
        public AK47()
        {
            
            
                Random random = new Random();

                Damage = random.Next(7,13);
                Type = "Rifle";
        }
    }

    public class M4A1:Weapon
    {
        public M4A1()
        {
            
            Random random = new Random();

            Type = "Rifle";
            Damage = random.Next(2,7);

        }
    }

    public class Knife:Weapon
    {

        public Knife ()
        {
            Random random = new Random();

            Type = "Melee";
            Damage = random.Next(1, 3);
        }
    }
}
