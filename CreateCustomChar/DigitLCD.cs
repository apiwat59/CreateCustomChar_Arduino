using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCustomChar
{
    public partial class DigitLCD : UserControl
    {
        public DigitLCD()
        {
            InitializeComponent();
        }

        private Color Green_BG = Color.FromArgb(129, 199, 132);
        private Color White_BG = Color.White;

        private int _thisNumber;
        #region Properties
        [Category("Prep Data")]
        public int thisNumber
        {
            get { return _thisNumber; }
            set { _thisNumber = value; }
        }
        #endregion
        private bool chageColor(Button button)
        {
            if (button.BackColor == White_BG)
            {
                button.BackColor = this.BackColor;
                button.FlatAppearance.BorderColor = White_BG;
                return false;
            }
            else
            {
                button.BackColor = White_BG;
                button.FlatAppearance.BorderColor = BackColor;
                return true;
            }
        }

        private void setResult(bool result,int positionY, int positionX)
        {
            if (result)
            {  
                ManageOperation.digitResult[thisNumber, positionY, positionX] = true;
            }
            else {ManageOperation.digitResult[thisNumber, positionY, positionX] = false; 
            }
        }

        //Console.WriteLine(result?$"{thisNumber}:select":$"{thisNumber}:not select");
        private void digit_1_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_1_1), 1, 1);
        }

        private void digit_1_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_1_2), 1, 2);
        }

        private void digit_1_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_1_3), 1, 3);
        }

        private void digit_1_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_1_4), 1, 4);
        }

        private void digit_1_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_1_5), 1, 5);
        }

        private void digit_2_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_2_1), 2, 1);
        }

        private void digit_2_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_2_2), 2, 2);
        }

        private void digit_2_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_2_3), 2, 3);
        }

        private void digit_2_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_2_4), 2, 4);
        }

        private void digit_2_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_2_5), 2, 5);
        }

        private void digit_3_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_3_1), 3, 1);
        }

        private void digit_3_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_3_2), 3, 2);
        }

        private void digit_3_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_3_3), 3, 3);
        }

        private void digit_3_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_3_4), 3, 4);
        }

        private void digit_3_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_3_5), 3, 5); 
        }

            private void digit_4_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_4_1), 4, 1);
        }

        private void digit_4_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_4_2), 4, 2);
        }

        private void digit_4_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_4_3), 4, 3);
        }

        private void digit_4_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_4_4),4, 4);
        }

        private void digit_4_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_4_5), 4, 5);
        }

        private void digit_5_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_5_1), 5, 1);
        }

        private void digit_5_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_5_2), 5, 2);
        }

        private void digit_5_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_5_3), 5, 3);
        }

        private void digit_5_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_5_4), 5, 4);
        }

        private void digit_5_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_5_5), 5, 5);
        }

        private void digit_6_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_6_1), 6, 1);
        }

        private void digit_6_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_6_2), 6, 2);
        }

        private void digit_6_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_6_3), 6, 3);
        }

        private void digit_6_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_6_4), 6, 4);
        }

        private void digit_6_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_6_5), 6, 5);
        }

        private void digit_7_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_7_1), 7, 1);
        }

        private void digit_7_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_7_2), 7, 2);
        }

        private void digit_7_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_7_3), 7, 3);
        }

        private void digit_7_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_7_4), 7, 4);
        }

        private void digit_7_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_7_5), 7, 5);
        }

        private void digit_8_1_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_8_1), 8, 1);
        }

        private void digit_8_2_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_8_2), 8, 2);
        }

        private void digit_8_3_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_8_3), 8, 3);
        }

        private void digit_8_4_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_8_4), 8, 4);
        }

        private void digit_8_5_Click(object sender, EventArgs e)
        {
            setResult(chageColor(digit_8_5), 8, 5);
        }
    }
}
