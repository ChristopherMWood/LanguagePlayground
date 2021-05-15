using System;
using SchrodingersIoC.ClassicSchrodingers;

namespace SchrodingersIoC.SchrodingersViaFramework.Cats
{
    public class HairlessCat : ClassicCat, ICat
    {
        public new bool IsAlive()
        {
            if (!this.catHasBeenChecked)
            {
                catIsAlive = new Random().Next(0, 10) < 3;
                catHasBeenChecked = true;
            }

            return catIsAlive;
        }
    }
}
