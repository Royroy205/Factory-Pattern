using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
      public void Drive() 
      {
            Console.WriteLine($"The Big_Rig 18 wheeler!!!"!);
            Console.WriteLine($"18 Tires Rolling");
      }
    
    
    }
}
