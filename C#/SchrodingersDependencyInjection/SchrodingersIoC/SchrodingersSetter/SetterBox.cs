using SchrodingersIoC.ClassicSchrodingers;

namespace SchrodingersIoC.SchrodingersSetter
{
    public class SetterBox
    {
        private ClassicCat cat;

        public void PutCatInBox(ClassicCat cat)
        {
            this.cat = cat;
        }

        public bool IsCatAlive()
        {
            return cat.IsAlive();
        }
    }
}
