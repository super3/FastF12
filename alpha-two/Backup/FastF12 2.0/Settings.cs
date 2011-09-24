using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastF12_2._0
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //Resize Border Labels
            border.Height = 2;
            border2.Height = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Close the Settings
            this.Close();
        }
    }
}
