namespace SchrodingersIoC.SchrodingersViaFramework
{
    public class CardboardBox : IBox
    {
        private ICat cat;

        public CardboardBox(ICat cat)
        {
            this.cat = cat;
        }

        public bool IsCatAlive()
        {
            return cat.IsAlive();
        }
    }
}
