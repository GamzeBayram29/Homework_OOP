using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    internal class Princess_Anna
    {
        public class Princess : Hero
        {
            public Princess() : this("Miss Anna") //By default, all princesses are named 'Miss Anna'
            {

            }

            public Princess(string name) : base(name) //A named princess, we supply the name
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
                int coef = Random.Shared.Next(40, 67);
                incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
                base.TakeDamage(incomingDamage);
            }
        }
    }
}
    

