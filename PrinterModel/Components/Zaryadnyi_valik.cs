using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Zaryadnyi_valik
    {
        public string NegativCharge()
        {
            string fullPath = Path.GetFullPath(@"../../NegativCharge.mp4");
            return fullPath;
        }
    }
}
