using System;
using SchrodingersIoC.ClassicSchrodingers;

namespace SchrodingersIoC.SchrodingersViaFramework.Cats
{
    public class MountainCat : ClassicCat, ICat
    {
        public new bool IsAlive()
        {
            if (!this.catHasBeenChecked)
            {
                catIsAlive = new Random().Next(0, 10) < 8;
                catHasBeenChecked = true;
            }

            return catIsAlive;
        }
    }
}
