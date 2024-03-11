using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Bunker
    {
        public string CoverWithToner(Magnitnyi_val m, int i)
        {
            string result = "";
            if (i==1) 
                result=m.RotateToGetToner();
            if (i == 2)
                result = Path.GetFullPath(@"../../CoverWithToner.mp4");
            
            return result;
           
        }
    }
}
