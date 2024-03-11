using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int condition = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (condition)
            {
                case 1:
                    ProperPrint(); break;
                case 2:
                    
                       axWindowsMediaPlayer1.URL = Path.GetFullPath(@"../../состояние2.mp4");
                       axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;
                case 3:
                    axWindowsMediaPlayer1.URL = Path.GetFullPath(@"../../состояние3.mp4");
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;
                case 4:
                    axWindowsMediaPlayer1.URL = Path.GetFullPath(@"../../состояние4.mp4");
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;
                case 5: Zamyatie(); break;
                default: MessageBox.Show("Выберите моделируемую ситуацию и нажмите кнопку Установить перед печатью", "Ошибка");break;
            }
        }
        private void ProperPrint()
        {
            Bunker bunker = new Bunker();
            Chistyashchii_nozh nozh = new Chistyashchii_nozh();
            Controller controller = new Controller();
            Fotobaraban fotobaraban = new Fotobaraban();
            Laser laser = new Laser();
            Lotok lotok = new Lotok();
            Magnitnyi_val magnitnyi_val = new Magnitnyi_val();
            Pechka pechka = new Pechka();
            Rolikovyi_uzel rolikovyi_uzel = new Rolikovyi_uzel();
            Val_perenosa val_perenosa = new Val_perenosa();
            Zaryadnyi_valik zaryadnyi_valik = new Zaryadnyi_valik();
            Zerkalo zerkalo = new Zerkalo();

            Printer printer = new Printer(lotok, bunker, nozh, controller, fotobaraban, laser, magnitnyi_val, pechka, rolikovyi_uzel, val_perenosa, zaryadnyi_valik, zerkalo);
            string[] print = printer.Print();
            var pl = axWindowsMediaPlayer1.playlistCollection.newPlaylist("печать");
            for (int i = 0; i < print.GetLength(0); i++)
            {
                pl.appendItem(axWindowsMediaPlayer1.newMedia(@print[i]));
            }
            axWindowsMediaPlayer1.currentPlaylist = pl;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void Zamyatie()
        {
            Bunker bunker = new Bunker();
            Chistyashchii_nozh nozh = new Chistyashchii_nozh();
            Controller controller = new Controller();
            Fotobaraban fotobaraban = new Fotobaraban();
            Laser laser = new Laser();
            Lotok lotok = new Lotok();
            Magnitnyi_val magnitnyi_val = new Magnitnyi_val();
            Pechka pechka = new Pechka();
            Rolikovyi_uzel rolikovyi_uzel = new Rolikovyi_uzel();
            Val_perenosa val_perenosa = new Val_perenosa();
            Zaryadnyi_valik zaryadnyi_valik = new Zaryadnyi_valik();
            Zerkalo zerkalo = new Zerkalo();

            Printer printer = new Printer(lotok, bunker, nozh, controller, fotobaraban, laser, magnitnyi_val, pechka, rolikovyi_uzel, val_perenosa, zaryadnyi_valik, zerkalo);
            string[] print = printer.Print();
            string[] z = new string[14];
            var pl = axWindowsMediaPlayer1.playlistCollection.newPlaylist("печать");
            for (int i = 0; i < z.GetLength(0) - 1; i++)
            {
                pl.appendItem(axWindowsMediaPlayer1.newMedia(@print[i]));
            }
            pl.appendItem(axWindowsMediaPlayer1.newMedia(Path.GetFullPath(@"../../Zamyatie.mp4")));
            axWindowsMediaPlayer1.currentPlaylist = pl;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                condition = 1;
            }
            else
            {
                if (radioButton2.Checked)
                {
                    condition = 2;
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        condition = 3;
                    }
                    else
                    {
                        if (radioButton4.Checked)
                        {
                            condition = 4;
                        }
                        else
                        {
                            if (radioButton5.Checked)
                            {
                                condition = 5;
                            }
                            else { MessageBox.Show("Выберите моделируемую ситуацию", "Ошибка"); return; }
                        }
                    }
                }
            }
            MessageBox.Show("Для демонстрации нажмите на кнопку Печать"); return;
        }
    }
}

