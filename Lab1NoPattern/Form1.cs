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

namespace Lab1NoPattern
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btRussia_Click(object sender, EventArgs e)
        {
            ShowRandomCar("Russia");
        }

        private void btEurope_Click(object sender, EventArgs e)
        {
            ShowRandomCar("Europe");
        }

        private void btAsia_Click(object sender, EventArgs e)
        {
            ShowRandomCar("Asia");
        }
        private void ShowRandomCar(string region)
        {
            List<Car> cars = null;

            if (region == "Russia")
            {
                cars = new List<Car>
                {
                    new Car("VinFast VF3 (Russia)",
                        "For Russia:\n- Optimized engine for cold climate\n- Heated seats and steering wheel",
                        Application.StartupPath + @"\Images\VF3.png"),
                    new Car("VinFast VF5 (Russia)",
                        "Compact SUV for Russia:\n- Emission standard for Russia\n- Suitable for icy roads",
                        Application.StartupPath + @"\Images\VF5.png"),
                    new Car("VinFast Lux A2.0 (Russia)",
                        "Premium sedan for Russia:\n- Heated seats and mirrors\n- Russian language support",
                        Application.StartupPath + @"\Images\LuxA.png")
                };
            }
            else if (region == "Europe")
            {
                cars = new List<Car>
                {
                    new Car("VinFast Lux SA2.0 (Europe)",
                        "Premium SUV for Europe:\n- 7-seater with Euro 6 emission standards\n- Multi-language support",
                        Application.StartupPath + @"\Images\LuxSA.jpg"),
                    new Car("VinFast President (Europe)",
                        "Luxury SUV for Europe:\n- Powerful V8 engine\n- Advanced safety systems",
                        Application.StartupPath + @"\Images\President.png"),
                    new Car("VinFast VF8 (Europe)",
                        "Electric SUV for Europe:\n- 400+ km range per charge\n- CCS charging standard",
                        Application.StartupPath + @"\Images\VF8.jpg")
                };
            }
            else if (region == "Asia")
            {
                cars = new List<Car>
                {
                    new Car("VinFast VF e34 (Asia)",
                        "Compact electric SUV for Asia:\n- Range of 285 km\n- Fast charging stations",
                        Application.StartupPath + @"\Images\VFe34.jpg"),
                    new Car("VinFast VF6 (Asia)",
                        "Compact electric SUV for Asia:\n- Designed for urban streets\n- Smart infotainment in Vietnamese",
                        Application.StartupPath + @"\Images\VF6.jpg"),
                    new Car("VinFast VF9 (Asia)",
                        "Full-size electric SUV for Asia:\n- 7-seater with premium comfort\n- Long-range battery capacity",
                        Application.StartupPath + @"\Images\VF9.jpg")
                };
            }

            if (cars == null) return;

            // Randomly select one car
            int index = _random.Next(cars.Count);
            var chosenCar = cars[index];

            lblCarName.Text = chosenCar.Name;
            rtbSpec.Text = chosenCar.Specification;

            try
            {
                pictureBoxCar.Image = Image.FromFile(chosenCar.ImagePath);
            }
            catch (FileNotFoundException)
            {
                pictureBoxCar.Image = null;
            }
        }
    }
}
