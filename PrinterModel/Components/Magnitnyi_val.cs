using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Magnitnyi_val
    {
        public string RotateToGetToner()
        {
            string fullPath = Path.GetFullPath(@"../../RotateToGetToner.mp4");
            return fullPath;
        }
        public string RotateToTransferToner(Fotobaraban f,int i)
        {
            string result = "";
            if (i==1) 
                result = Path.GetFullPath(@"../../RotateToTransferToner.mp4");
            if (i==2)  
                result=f.GetTonerGeneratedImage();
            return result;
        }
    }
}
