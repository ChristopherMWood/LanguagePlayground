namespace SchrodingersIoC.ClassicSchrodingers
{
    public class ClassicBox
    {
        private ClassicCat cat;

        public ClassicBox()
        {
            cat = new ClassicCat();
        }

        public bool IsCatAlive()
        {
            return cat.IsAlive();
        }
    }
}
