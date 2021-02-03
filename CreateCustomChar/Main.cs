using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace CreateCustomChar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Color Green_BG = Color.FromArgb(129, 199, 132);
        private Color Blue_BG = Color.RoyalBlue;

        private dynamic Json = JsonConvert.DeserializeObject(File.ReadAllText("Config.json"));
        private string jsonPreDisplay { get; set; }
        
        private void Main_Load(object sender, EventArgs e)
        {
           CB_ChangeColor_Green.Checked = true;
           CB_TypeInterfac_Parallel.Checked = true;
           CB_DataType_Binary.Checked = true;
           LoadItems(32);


        }

        private void LoadItems(int many)
        {
            for (int i = 0; i < many; i++)
            {
                DigitLCD listitems_all = new DigitLCD();

                if (CB_ChangeColor_Green.Checked)
                {
                    listitems_all.BackColor = Green_BG;
                }
                else
                {
                    listitems_all.BackColor = Blue_BG;
                }
                listitems_all.thisNumber = i+1;
                FlowLayout_Digit_LCD.Controls.Add(listitems_all);
            }
        }

        private void Clear_Items()
        {
            FlowLayout_Digit_LCD.Controls.Clear();
        }

        private void CB_ChangeColor_Green_CheckedChanged(object sender, EventArgs e)
        {
            for (int z = 1; z <= 32; z++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    for (int x = 1; x <= 5; x++)
                    {
                        ManageOperation.digitResult[z, y, x] = false;
                    }
                }
            }
            if (CB_ChangeColor_Green.Checked)
            {
                Clear_Items();
                CB_ChangeColor_Blue.Checked = false;
                LoadItems(32);
            }
        }

        private void CB_ChangeColor_Blue_CheckedChanged(object sender, EventArgs e)
        {
            for (int z = 1; z <= 32; z++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    for (int x = 1; x <= 5; x++)
                    {
                        ManageOperation.digitResult[z, y, x] = false;
                    }
                }
            }

            if (CB_ChangeColor_Blue.Checked)
            {
                Clear_Items();
                CB_ChangeColor_Green.Checked = false;
                LoadItems(32);
            }
        }

        private void BTN_GenarateCode_Click(object sender, EventArgs e)
        {
            if (TB_VarialbleName.TextLength > 0)
            {
                TB_Log.Text = string.Empty;

                if (CB_TypeInterfac_I2C.Checked)
                {
                    jsonPreDisplay = Json["Interfacing_I2C"];
                }
                else
                {
                    jsonPreDisplay = Json["Interfacing_Parallel"];
                }
               
                TB_Log.Text = jsonPreDisplay.Replace("\n", System.Environment.NewLine);

                for (int i = 0; i <= 32; i++)
                {
                    ManageOperation.digitAssigned[i] = false;
                }

                for (int z = 1; z <= 32; z++)
                {
                    for (int y = 1; y <= 8; y++)
                    {
                        for (int x = 1; x <= 5; x++)
                        {
                                if (CB_DataType_Binary.Checked)
                                {
                                    if (ManageOperation.digitResult[z, y, x])
                                    {
                                        if (!ManageOperation.digitAssigned[z])
                                        {
                                            string s = TB_Log.Text;
                                            s = s.Replace("//Variable", $"byte {TB_VarialbleName.Text}{z}[8] = {(char)123}" + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 1)}," + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 2)}," + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 3)}," + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 4)}," + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 5)}," + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 6)}," + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 7)}," + Environment.NewLine +
                                                $"0b{getBinaryfromArray(z, 8)}{(char)125};" + Environment.NewLine + "//Variable");
                                            TB_Log.Text = s;
                                            ManageOperation.digitAssigned[z] = true;
                                      }
                                   }
                                }
                                else
                                {
                                    if (ManageOperation.digitResult[z, y, x])
                                    {
                                        if (!ManageOperation.digitAssigned[z])
                                        {
                                            string s = TB_Log.Text;
                                            s = s.Replace("//Variable", $"byte {TB_VarialbleName.Text}{z}[8] = {(char)123}" + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 1))}," + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 2))}," + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 3))}," + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 4))}," + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 5))}," + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 6))}," + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 7))}," + Environment.NewLine +
                                                $"0x{BinaryStringToHexString(getBinaryfromArray(z, 8))}{(char)125};" + Environment.NewLine + "//Variable");
                                            TB_Log.Text = s;
                                            ManageOperation.digitAssigned[z] = true;
                                        }
                                    }
                                }  
                        }
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Please specify a variable name!!!!","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private string BinaryStringToHexString(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return binary;

            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
        private string getBinaryfromArray(int z ,int y)
        {
            string result = string.Empty;
            for (int x = 1; x <= 5; x++)
            {
                result += FormatBinaryToNumber(z, y, x);
            }
            return result;
        }
        private string FormatBinaryToNumber(int z,int y,int x)
        {
            return ManageOperation.digitResult[z, y, x] ? "1" : "0";
        }
        private void CB_TypeInterfac_Parallel_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_TypeInterfac_Parallel.Checked)
            {
                CB_TypeInterfac_I2C.Checked = false;
            }
        }

        private void CB_TypeInterfac_I2C_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_TypeInterfac_I2C.Checked)
            {
                CB_TypeInterfac_Parallel.Checked = false;
            }
        }

        private void cb_MlType_CheckedChanged(object sender, EventArgs e)
        {
            cb_MlType.Checked = true;
        }

        private void CB_DataType_Binary_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_DataType_Binary.Checked)
            {
                CB_DataType_Hex.Checked = false;
            }
        }

        private void CB_DataType_Hex_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_DataType_Hex.Checked)
            {
                CB_DataType_Binary.Checked = false;
            }
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_VarialbleName.Text = string.Empty;
        }

        private void BTN_Clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TB_Log.Text.Length > 0 ? TB_Log.Text:"Gapz@Thailand");
        }
    }

    public class ManageOperation
    {
        public static bool[,,] digitResult = new bool[33, 9, 6];
        public static bool[] digitAssigned = new bool[33];
    }
}
