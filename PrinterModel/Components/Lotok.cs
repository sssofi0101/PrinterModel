using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Lotok
    {
        public string SendPaper()
        {
            string fullPath = Path.GetFullPath(@"../../SendPaper.mp4");
            return fullPath;
        }
    }
}
