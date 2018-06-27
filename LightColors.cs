using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHueForm
{
    class LightColors
    {

        public string Hue { get; set; }

        //Constructor
        public  LightColors()
        {
            Hue = "WHITE";
        }

        //Define action for the + operator
        public static LightColors operator +(LightColors L1, LightColors L2)
        {
            LightColors MixedColor = new LightColors();
            string Light1 = L1.Hue.ToUpper();
            string Light2 = L2.Hue.ToUpper();

            #region RED
            if (Light1 == "RED")
            {
                if (Light2 == "RED")
                {
                    MixedColor.Hue = "RED";
                }
                else if (Light2 == "GREEN")
                {
                    MixedColor.Hue = "YELLOW";
                }
                else if (Light2 == "BLUE")
                {
                    MixedColor.Hue = "MAGENTA";
                }
                else if (Light2 == "MAGENTA")
                {
                    MixedColor.Hue = "ROSE";
                }
                else if (Light2 == "YELLOW")
                {
                    MixedColor.Hue = "ORANGE";
                }
                else
                {
                    MixedColor.Hue = Light1 + "-" + Light2;
                }
            }//end if 
            #endregion

            #region GREEN
            else if (Light1 == "GREEN")
            {
                if (Light2 == "GREEN")
                {
                    MixedColor.Hue = "GREEN";
                }
                else if (Light2 == "BLUE")
                {
                    MixedColor.Hue = "CYAN";
                }
                else if (Light2 == "RED")
                {
                    MixedColor.Hue = "MAGENTA";
                }
                else if (Light2 == "CYAN")
                {
                    MixedColor.Hue = "SPRING GREEN";
                }
                else if (Light2 == "YELLOW")
                {
                    MixedColor.Hue = "CHARTREUSE GREEN";
                }
                else
                {
                    MixedColor.Hue = Light1 + "-" + Light2;
                }
            }//end iff
            #endregion

            #region BLUE
            else if (Light1 == "BLUE")
            {
                if (Light2 == "BLUE")
                {
                    MixedColor.Hue = "BLUE";
                }
                else if (Light2 == "RED")
                {
                    MixedColor.Hue = "MAGENTA";
                }
                else if (Light2 == "GREEN")
                {
                    MixedColor.Hue = "CYAN";
                }
                else if (Light2 == "CYAN")
                {
                    MixedColor.Hue = "AZURE";
                }
                else if (Light2 == "MAGENTA")
                {
                    MixedColor.Hue = "VIOLET";
                }
                else
                {
                    MixedColor.Hue = Light1 + "-" + Light2;
                }
            }//end if
            #endregion

            #region MAGENTA
            if (Light1 == "MAGENTA")
            {
                 if (Light2 == "BLUE")
                 {
                     MixedColor.Hue = "VIOLET";
                 }
                 else if (Light2 == "RED")
                 {
                     MixedColor.Hue = "ROSE";
                 }
                 else
                 {
                     MixedColor.Hue = Light1 + "-" + Light2;
                 }
             }
            #endregion

            #region CYAN
            if (Light1 == "CYAN")
            {
                if (Light2 == "BLUE")
                {
                    MixedColor.Hue = "AZURE";
                }
                else if (Light2 == "GREEN")
                {
                    MixedColor.Hue = "SPRING GREEN";
                }
            }
            #endregion

            #region YELLOW
            if (Light1 == "YELLOW")
            {
                if (Light2 == "GREEN")
                {
                    MixedColor.Hue = "CHARTREUSE";
                }
                else if (Light2 == "RED")
                {
                    MixedColor.Hue = "ORANGE";
                }
            }
            #endregion      

            return MixedColor;
        }
    }
}
