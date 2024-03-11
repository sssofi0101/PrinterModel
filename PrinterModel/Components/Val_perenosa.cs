using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Val_perenosa
    {
        public string PositivCharge()
        {
            string fullPath = Path.GetFullPath(@"../../PositivCharge.mp4");
            return fullPath;
        }
    }
}
