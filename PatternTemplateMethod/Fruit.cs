using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplateMethod
{
    public abstract class Fruit
    {

        public abstract void GetJuice();
        public abstract void AddWater();

        // Шаблонный метод
        public void TemplateMethod()
        {
            GetJuice();
            AddWater();
        }
    }
}
