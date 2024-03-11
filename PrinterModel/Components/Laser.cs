using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Laser
    {
        public string MoveAndLight()
        {
            string fullPath = Path.GetFullPath(@"../../MoveAndLight.mp4");
            return fullPath;
        }
    }
}
