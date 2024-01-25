using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    class D
    {

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

    }

    class C
    {

        public void test()
        {
            var data = new List<D>() {
        new D() { id = 1, name = "a", age = 51},
        new D() { id = 2, name = "b", age = 19},

          new D() { id = 3, name = "c", age = 38},
        new D() { id = 4, name = "d", age = 25},
          new D() { id = 3, name = "e", age = 40},
        new D() { id = 4, name = "f", age = 2536 }

        };


            var ages = new Dictionary<int, D>();
            var top3 = new List<int>();

            //foreach(var d in data)
            //{
            //    if(top3.Count < 3)
            //    {
            //        top3.Add(d.id);
            //        ages.Add(d.id, d);
            //    }
            //    else
            //    {
            //        if(d.age < top3.Max())
            //        {
            //            ages[]
            //        }
            //    }
            //}

            //for()
        }
    }
}
