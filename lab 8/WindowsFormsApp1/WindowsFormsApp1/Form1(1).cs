using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var basicMachine = new BasicMachine();
            basicMachine.Operate(); // Output: Basic machine is operating.

            var enhancedMachine = new EnhancedMachine(basicMachine);
            enhancedMachine.Operate(); // Output: Basic machine is operating. Enhanced machine is operating.

            var upgradedMachine = new UpgradedMachine(enhancedMachine);
            upgradedMachine.Operate(); 
        }
    }
}
