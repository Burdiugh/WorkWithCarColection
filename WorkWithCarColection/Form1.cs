using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WorkWithCarColection.Program;

namespace WorkWithCarColection
{
    
    public partial class Form1 : Form
    {
        string platePat = @"[A-Z]{2}[0-9]{4}[A-Z]{2}$";
        string vinPat = @"[A-HJ-NPR-Z0-9]{17}";

        List<Car> cars = new List<Car>();
        BinaryFormatter objBinaryFormatter = new BinaryFormatter();
        string path = "Cars.dat";
        public Form1()
        {
            InitializeComponent();
            Load();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            string model = modelBox.Text;
            decimal year = yearNumeric.Value;
            string color = colorBox.Text;
            decimal probeg = probegNum.Value;
            decimal volume = volNum.Value;
            string plate = plateTextBox.Text;
            string vin = vinCodeBox.Text;
            if (Regex.IsMatch(plate, platePat)&& Regex.IsMatch(vin, vinPat))
            {
                cars.Add(new Car(model, year, color, probeg, volume, plate, vin));
                Update();
            }
            else
            {
                MessageBox.Show("Something went wrong! Enter the valid info!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Update()
        {
            carsBox.DataSource = null;
            carsBox.DataSource = cars;
            carlistBox.DataSource = null;
            carlistBox.DataSource = cars;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (carsBox.SelectedIndex==-1&&carlistBox.SelectedIndex==-1)
            {
                return;
            }
            cars.Remove((Car)carsBox.SelectedItem);
            cars.Remove((Car)carlistBox.SelectedItem);
            Update();
        }

        private void showCarbtn_Click(object sender, EventArgs e)
        {
            if (carsBox.SelectedIndex==-1&&carlistBox.SelectedIndex==-1)
            {
                return;
            }
            Car car = carsBox.SelectedItem as Car;
            MessageBox.Show(car.Show(),"Info!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void Load()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                cars = (List<Car>)objBinaryFormatter.Deserialize(fs);
            }
            Update();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (Stream obj = new FileStream(path,FileMode.OpenOrCreate))
            {
                objBinaryFormatter.Serialize(obj, cars);
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(path,FileMode.Open))
            {
                cars = (List<Car>)objBinaryFormatter.Deserialize(fs);
            }
            Update();
        }

    }
}
