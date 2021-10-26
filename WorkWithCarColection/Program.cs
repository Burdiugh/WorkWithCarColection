using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithCarColection
{
    static class Program
    {
      [Serializable]
       public class Car
        {
            public string  Model { get; set; }
            public decimal  Year { get; set; }
            public string Color { get; set; }
            public decimal Probeg { get; set; }
            public decimal EngVol { get; set; }
            public string PlateNumber { get; set; }
            public string VinNumber { get; set; }

            public Car(string n, decimal y,string c, decimal p, decimal eng,string plt,string v)
            {
                Model = n;
                Year = y;
                Color = c;
                Probeg = p;
                EngVol = eng;
                PlateNumber = plt;
                VinNumber = v;
            }
            public string Show() {
                return $"Model: {Model}\n" +
                    $"Year: {Year}\n" +
                    $"Colot: {Color}\n" +
                    $"Probeg: {Probeg}\n" +
                    $"Engine Volume: {EngVol}\n" +
                    $"Plate number: {PlateNumber}\n" +
                    $"Vin-Code: {VinNumber}\n\n";
            }
            public override string ToString()
            {
                return $"{Model} - Volume: {EngVol}";
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
