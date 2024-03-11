using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace PrinterModel

{
    public class Controller
    {
        /// <summary>
    /// Метод, демонстрирующий получение текста или изображения контроллером
    /// </summary>
        public string GetData()
        {
            string fullPath = Path.GetFullPath(@"../../GetData.mp4");
            return fullPath;
        }
        /// <summary>
        /// Метод, демонстрирующий преобразование контроллером полученных данных в матрицу точек 
        /// </summary>
        public string ConvertToMatrix()
        {
            string fullPath = Path.GetFullPath(@"../../ConvertToMatrix.mp4");
            return fullPath;
        }
        /// <summary>
        /// Контроллер управляет лазером, включая и выключая его в нужных местах, согласно сформированной матрице.
        /// Благодаря этому засвечиваются участки поверхности фотобарабана, на которые нужно нанести тонер для печати. 
        /// Под воздействием света они теряют свой заряд.
        /// </summary>
        /// <param name="laser">лазер</param>
        /// <param name="f">фотобарабан</param>
        public string LightUpAreas(Laser laser, Fotobaraban f,Zerkalo z,int i)
        {
            string result="";
           if (i==1) 
                result=z.MoveAndReflect();
           if (i==2) 
                result=laser.MoveAndLight();
           if (i==3) 
                result=f.ChangeElectroconductivity();
           return result;
        }
    }
}
