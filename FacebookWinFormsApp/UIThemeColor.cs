using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class UIThemeColor
    {
        public static Color PrimaryColor { get; set; }

        public static Color SecondaryColor { get; set; }

        public static List<string> MenuColorsList { get; } = new List<string>() 
        {
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#00B0AD",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#364D5B",
            "#C7DC5B",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#7BCFE9",
            "#B71C46"
        };

        public static Color ChangeColorBrightness(Color i_Color, double i_CorrectionFactor)
        {
            double red = i_Color.R;
            double green = i_Color.G;
            double blue = i_Color.B;

            if(i_CorrectionFactor < 0)
            {
                i_CorrectionFactor = 1 + i_CorrectionFactor;
                red *= i_CorrectionFactor;
                green *= i_CorrectionFactor;
                blue *= i_CorrectionFactor;
            }
            else
            {
                red = ((255 - red) * i_CorrectionFactor) + red;
                green = ((255 - green) * i_CorrectionFactor) + green;
                blue = ((255 - blue) * i_CorrectionFactor) + blue;
            }

            return Color.FromArgb(i_Color.A, (byte)red, (byte)green, (byte)blue);
        }

        public static void LoadTheme(Panel i_CurrentPanel)
        {
            Button currentButton;
            Label currentLabel;

            foreach (Control currentControl in i_CurrentPanel.Controls)
            {
                if (currentControl.GetType() == typeof(Button))
                {
                    currentButton = (Button)currentControl;
                    currentButton.BackColor = UIThemeColor.PrimaryColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.FlatAppearance.BorderColor = UIThemeColor.SecondaryColor;
                }

                if (currentControl.GetType() == typeof(Label))
                {
                    currentLabel = (Label)currentControl;
                    currentLabel.ForeColor = UIThemeColor.PrimaryColor;
                }
            }
        }
    }
}
