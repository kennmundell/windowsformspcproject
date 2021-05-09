using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcSpecBuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoLaptop_CheckedChanged(object sender, EventArgs e)
        {
            txtBASE.Text = "Laptop";
            txtRAM.Text = "4gb";
            txtCPU.Text = "Intel i3 2.2ghz";
            tbKeyboard.Text = "Internal keyboard";
            tbHDD.Text = "500GB SATA 5400rpm";
            tbBATTERY.Text = "6 cell 48whr Li-on";
            tbGPU.Text = "Intel HD 3000";
            tbOPTICAL.Text = "8x DVDRW";
            tbWIFI.Text = "Intel N 1030, blutooth v3";
            tbLCD.Text = "15.6 in HD 1366x768 WLED";
            tbWARRANTY.Text = "1 yr Collect&Return";
        }

        private void rdoPC50_CheckedChanged(object sender, EventArgs e)
        {
            txtBASE.Text = "PC50";
            txtRAM.Text = "4gb";
            txtCPU.Text = "Intel i5-2320 3.0GHZ";
            tbHDD.Text = "500GB 7200rpm SATA";
            tbKeyboard.Text = "";
            tbBATTERY.Text = "";
            tbGPU.Text = "AMD Radeon 6450 1gb";
            tbOPTICAL.Text = "DVDRW with software";
            tbWIFI.Text = "Intel N 1030, bluetooth v3";
            tbLCD.Text = "";
            tbWARRANTY.Text = "1 yr Collect&Return";

        }

        private void tbKeyboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoPC60_CheckedChanged(object sender, EventArgs e)
        {
            txtBASE.Text = "PC60";
            txtRAM.Text = "6gb";
            txtCPU.Text = "Intel i7-2600 3.4GHZ";
            tbHDD.Text = "500GB 7200rpm SATA";
            tbKeyboard.Text = "";
            tbBATTERY.Text = "";
            tbGPU.Text = "NVIDIA Geoforce GT530 1gb";
            tbOPTICAL.Text = "DVDRW with software";
            tbWIFI.Text = "Intel N 1030, bluetooth v3";
            tbLCD.Text = "";
            tbWARRANTY.Text = "1 yr Collect&Return";
        }
    }
}
