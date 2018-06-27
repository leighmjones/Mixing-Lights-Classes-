using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightHueForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
                LightColors FirstLight = new LightColors();
                LightColors SecondLight = new LightColors();
                LightColors Result = new LightColors();
                //LightColors FinalColor = new LightColors();
           
                FirstLight.Hue = textBox1.Text;
                SecondLight.Hue = textBox2.Text;

                Result = FirstLight + SecondLight;

            switch (Result.Hue)
            {
                case "YELLOW":
                    colorBox.BackColor = Color.Yellow;
                    colorBox.ForeColor = Color.Yellow; break;
                case "RED":
                    colorBox.BackColor = Color.Red;
                    colorBox.ForeColor = Color.Red; break;
                case "MAGENTA":
                    colorBox.BackColor = Color.Magenta;
                    colorBox.ForeColor = Color.Magenta; break;
                case "VIOLET":
                    colorBox.BackColor = Color.Violet;
                    colorBox.ForeColor = Color.Violet; break;
                case "ROSE":
                    colorBox.BackColor = Color.MistyRose;
                    colorBox.ForeColor = Color.MistyRose; break;
                case "GREEN":
                    colorBox.BackColor = Color.ForestGreen;
                    colorBox.ForeColor = Color.ForestGreen; break;
                case "CYAN":
                    colorBox.BackColor = Color.Cyan;
                    colorBox.ForeColor = Color.Cyan; break;
                case "BLUE":
                    colorBox.BackColor = Color.Blue;
                    colorBox.ForeColor = Color.Blue; break;
                case "AZURE":
                    colorBox.BackColor = Color.Azure;
                    colorBox.ForeColor = Color.Azure; break;
                case "SPRING GREEN":
                    colorBox.BackColor = Color.SpringGreen;
                    colorBox.ForeColor = Color.SpringGreen; break;
                case "CHARTREUSE GREEN":
                    colorBox.BackColor = Color.Chartreuse;
                    colorBox.ForeColor = Color.Chartreuse; break;


            }
            
        }
    }
}
