using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Design_Patterns.Decorators
{
    public abstract class IceCream
    {
        public int NumCopies { get; set; }

        public abstract void Display();
    }

    public class ChocoBar : IceCream
    {
        public override void Display()
        {
        }
    }

    public class Cup : IceCream {
        public override void Display() 
        { 
        }
    }

    public abstract class Decorator : IceCream
    {
        private IceCream libraryItem;

        public Decorator(IceCream item) {
            libraryItem = item;
        }

        public override void Display()
        {
            this.libraryItem.Display(); 
        }
    }

    public class ChocoCup : Decorator
    {
        public ChocoCup(IceCream item) : base(item)
        {
        }

        public override void Display()
        {
            base.Display();

        }
    }
}
