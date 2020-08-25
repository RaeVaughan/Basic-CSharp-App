using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
}
