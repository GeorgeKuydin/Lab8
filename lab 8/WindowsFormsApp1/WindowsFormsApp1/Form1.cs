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
            IMachine espressoWithMilk = new MilkDecorator(new EspressoMachine());
            textBox1.Text = $"{espressoWithMilk.GetDescription()}: {espressoWithMilk.GetCost()}";

            IMachine dripCoffeeWithSugarAndMilk = new SugarDecorator(new MilkDecorator(new DripCoffeeMachine()));
            textBox1.Text += $"\r\n{dripCoffeeWithSugarAndMilk.GetDescription()}: {dripCoffeeWithSugarAndMilk.GetCost()}";
        }
    }
}
