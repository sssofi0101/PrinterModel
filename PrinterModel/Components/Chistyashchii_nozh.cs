using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Chistyashchii_nozh
    {
        public string CleanOffExcessToner()
        {
            string fullPath = Path.GetFullPath(@"../../CleanOffExcessToner.mp4");
            return fullPath;
        }
    }
}
