using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Pechka
    {
        public string FixToner()
        {
            string fullPath = Path.GetFullPath(@"../../FixToner.mp4");
            return fullPath;
        }
    }
}
