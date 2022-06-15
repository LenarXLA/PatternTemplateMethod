using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplateMethod
{
    public class Apple : Fruit
    {
        public override void AddWater()
        {
            Console.WriteLine("Add some water in apple tree");
        }

        public override void GetJuice()
        {
            Console.WriteLine("Get apple tree juice");
        }
    }
}
