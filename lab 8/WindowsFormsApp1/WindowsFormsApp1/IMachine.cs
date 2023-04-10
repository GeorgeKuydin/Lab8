using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public interface IMachine
    {
        void Operate();
    }

    // Concrete component class
    public class BasicMachine : IMachine
    {
        public void Operate()
        {
            MessageBox.Show("Basic machine is operating.");
        }  
    }

    // Base decorator class
    public abstract class MachineDecorator : IMachine
    {
        private readonly IMachine _machine;

        protected MachineDecorator(IMachine machine)
        {
            _machine = machine;
        }

        public virtual void Operate()
        {
            _machine.Operate();
        }
    }

    // Concrete decorator classes
    public class EnhancedMachine : MachineDecorator
    {
        public EnhancedMachine(IMachine machine) : base(machine)
        {
        }

        public override void Operate()
        {
            base.Operate();
           MessageBox.Show("Enhanced machine is operating.");
        }
    }

    public class UpgradedMachine : MachineDecorator
    {
        public UpgradedMachine(IMachine machine) : base(machine)
        {
        }

        public override void Operate()
        {
            base.Operate();
            MessageBox.Show("Upgraded machine is operating.");
        }
    }
}
