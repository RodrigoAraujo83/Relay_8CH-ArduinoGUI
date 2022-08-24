using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaDe_Um_Form
{
    internal class LED_Private
    {
        private string Color;
        private bool isOn;
        private bool size;
        private int intensity;

        // Prorpiedade Get e Set para acesso a atributos privados

        public int intensityLed{ 
            get 
            { 
                return this.intensity; 
            } 
            set 
            {
                if (value < 0)
                {
                    this.intensity = 0;
                }
                else if (value > 255)
                {
                    this.intensity = 255;
                }
                else
                {
                    this.intensity = value;
                }
            } 
        }

        public string Color1 { get => Color; set => Color = value; }
        public bool IsOn { get => isOn; set => isOn = value; }
        public bool Size { get => size; set => size = value; }

        public void ligar()
        {
            this.isOn = true;
            MessageBox.Show("O Led foi Ligado!");
        }
        public void desligado()
        {
            this.isOn = false;
            MessageBox.Show("O led foi desligado!");
        }
    }
}
