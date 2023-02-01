using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class Light
    {
        public static string TheLight { get; } = 
@"
  ***
 *****
  ***";
        public string GetLightArt()
        {
            return TheLight;
        }
    }

}
