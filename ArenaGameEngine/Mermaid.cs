using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    internal class Mermaid
    {
        public class Mermaid : Hero
        {
            public Mermaid() : this("Miss Stela") //By default, all mermaids are named 'Miss Stela'
            {

            }

            public Mermaid(string name) : base(name) //A named mermaid, we supply the name
            {
                hitCount = 0;
            }

            private int hitCount;

            public override int Attack()
            {
                hitCount = hitCount + 1;
                int baseAttack = base.Attack();
                if (hitCount == 5)
                {
                    baseAttack = baseAttack * 2;
                    hitCount = 0;
                }
                return baseAttack;
            }

            public override void TakeDamage(int incomingDamage)
            {
                int coef = Random.Shared.Next(30, 54);
                incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
                base.TakeDamage(incomingDamage);
            }
        }
    }
}
    

