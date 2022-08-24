using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaDe_Um_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Led led1 = new Led();
            led1.color = "red";
            led1.size = 3;
            led1.isOn = true;
            led1.intensity = 255;
           // Console.WriteLine($" o led1 é {led1.color} e está com intensidade de {led1.intensity}");

            LED_Private led2 = new LED_Private();
            led2.intensityLed = -20; // Usando o Set
            //Console.WriteLine($" o led2 tem intensidade de: {led2.intensityLed}"); // Usando o Get
            led2.desligado();
        }



    }
}
