using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterModel
{
    public class Printer
    {
        private Bunker bunker;
        private Chistyashchii_nozh nozh;
        private Controller controller;
        private Fotobaraban fotobaraban;
        private Laser laser;
        private Lotok lotok;
        private Magnitnyi_val magnitnyi_val;
        private Pechka pechka;
        private Rolikovyi_uzel rolikovyi_uzel;
        private Val_perenosa val_perenosa;
        private Zaryadnyi_valik zaryadnyi_valik;
        private Zerkalo zerkalo;
        public Printer(Lotok lot, Bunker b, Chistyashchii_nozh chn, Controller c, Fotobaraban f, Laser l, Magnitnyi_val mv, Pechka p, Rolikovyi_uzel ru, Val_perenosa vp, Zaryadnyi_valik zv, Zerkalo z)
        {
            lotok = lot;
            bunker = b;
            nozh=chn;
            controller = c;
            fotobaraban = f;
            laser = l;
            magnitnyi_val = mv;
            pechka = p;
            rolikovyi_uzel = ru;
            val_perenosa = vp;
            zaryadnyi_valik = zv;
            zerkalo = z;

        }
        public string[] Print() 
        {
            string[] printing = new string[18];
            printing[0] = Path.GetFullPath(@"../../состояние1.mp4");
            printing[1]=controller.GetData();
            printing[2] = controller.ConvertToMatrix();
            printing[3] = zaryadnyi_valik.NegativCharge();
            printing[4] = controller.LightUpAreas(laser,fotobaraban,zerkalo,1);
            printing[5] = controller.LightUpAreas(laser, fotobaraban, zerkalo, 2);
            printing[6] = controller.LightUpAreas(laser, fotobaraban, zerkalo, 3);
            printing[7] = bunker.CoverWithToner(magnitnyi_val,1);
            printing[8] = bunker.CoverWithToner(magnitnyi_val, 2);
            printing[9] = magnitnyi_val.RotateToTransferToner(fotobaraban,1);
            printing[10] = magnitnyi_val.RotateToTransferToner(fotobaraban, 2);
            printing[11] = lotok.SendPaper();
            printing[12] = rolikovyi_uzel.TransferPaper();
            printing[13] = val_perenosa.PositivCharge();
            printing[14] = fotobaraban.GiveTonerToPaper();
            printing[15] = nozh.CleanOffExcessToner();
            printing[16] = pechka.FixToner();
            printing[17]= Path.GetFullPath(@"../../TransferPaper.mp4");
            return printing;
        }
        
    }
}
