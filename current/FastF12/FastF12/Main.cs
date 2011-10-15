using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastF12
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Open Wizard 
            Wizard_Start wizard = new Wizard_Start(); // Need to Pass Empty Object Here
            wizard.Show(); // Needs to Return a Value   
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // Open Wizard 
            Wizard_Start wizard = new Wizard_Start(); // Need to Pass Object Here
            wizard.Show(); // Needs to Return a Value
        }
    }
}
