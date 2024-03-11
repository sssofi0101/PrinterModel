using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Zerkalo
    {
        public string MoveAndReflect()
        {
            string fullPath = Path.GetFullPath(@"../../MoveAndReflect.mp4");
            return fullPath;
        }
    }
}
