using System;
using Autofac;
using SchrodingersIoC.ClassicSchrodingers;
using SchrodingersIoC.SchrodingersConstructor;
using SchrodingersIoC.SchrodingersSetter;
using SchrodingersIoC.SchrodingersViaFramework;
using SchrodingersIoC.SchrodingersViaFramework.Cats;

namespace SchrodingersIoC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Classic Schrodingers Cat Example
            //Console.WriteLine("Classic Schrodingers Cat");
            //var box = new ClassicBox();
            //Console.WriteLine("Is the cat dead?: " + (box.IsCatAlive() ? "Yes" : "No"));

            //Setter Schrodingers Cat Example
            //var box = new SetterBox();
            //var cat = new ClassicCat();
            //box.PutCatInBox(cat);
            //Console.WriteLine("Ask the box, is the cat dead?: " + (box.IsCatAlive() ? "Yes" : "No"));
            //Console.WriteLine("Are you dead cat?: " + (cat.IsAlive() ? "Yes" : "No"));

            //Constructor Schrodingers Cat Example
            //var cat = new ClassicCat();
            //var box = new ConstructorBox(cat);
            //Console.WriteLine("Ask the box, is the cat dead?: " + (box.IsCatAlive() ? "Yes" : "No"));
            //Console.WriteLine("Are you dead cat?: " + (cat.IsAlive() ? "Yes" : "No"));


            //Full Framework Schrodingers Cat Example
            //Bootstrap Framework Setup
            var builder = new ContainerBuilder();
            builder.RegisterType<CardboardBox>().As<IBox>();
            builder.RegisterType<HairlessCat>().As<ICat>();
            var container = builder.Build();




            var box = container.Resolve<IBox>();
            Console.WriteLine("Is the cat dead?: " + (box.IsCatAlive() ? "Yes" : "No"));
        }
    }
}
