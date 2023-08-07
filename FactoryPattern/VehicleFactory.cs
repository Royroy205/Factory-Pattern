using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount) 
        { 

          switch (wheelCount) 
          {
                case 4:
                    return new Car();
                case 18:
                    return new BigRig();
                case 2:
                    return new Motorcycle();
                default:
                    return new Car();
          }
        
        
        }
    
    
    
    
    }
}
