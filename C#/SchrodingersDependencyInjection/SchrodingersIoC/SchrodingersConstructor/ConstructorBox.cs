using SchrodingersIoC.ClassicSchrodingers;

namespace SchrodingersIoC.SchrodingersConstructor
{
    public class ConstructorBox
    {
        private ClassicCat cat;

        public ConstructorBox(ClassicCat cat)
        {
            this.cat = cat;
        }

        public bool IsCatAlive()
        {
            return cat.IsAlive();
        }
    }
}
