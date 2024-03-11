using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Rolikovyi_uzel
    {
        public string TransferPaper()
        {
            string fullPath = Path.GetFullPath(@"../../Ru_TransferPaper.mp4");
            return fullPath;
        }
    }
}
