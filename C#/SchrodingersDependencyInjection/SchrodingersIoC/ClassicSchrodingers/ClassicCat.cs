using System;

namespace SchrodingersIoC.ClassicSchrodingers
{
    public class ClassicCat
    {
        protected bool catHasBeenChecked = false;
        protected bool catIsAlive;

        public bool IsAlive()
        {
            if (!catHasBeenChecked)
            {
                catIsAlive = new Random().Next(0, 2) == 1;
                catHasBeenChecked = true;
            }

            return catIsAlive;
        }
    }
}
