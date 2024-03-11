using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Fotobaraban
    {
        public string ChangeElectroconductivity()
        {
            string fullPath = Path.GetFullPath(@"../../ChangeElectroconductivity.mp4");
            return fullPath;
        }
        public string GetTonerGeneratedImage()
        {
            string fullPath = Path.GetFullPath(@"../../GetTonerGeneratedImage.mp4");
            return fullPath;
        }
        public string GiveTonerToPaper()
        {
            string fullPath = Path.GetFullPath(@"../../GiveTonerToPaper.mp4");
            return fullPath;
        }
    }
}
