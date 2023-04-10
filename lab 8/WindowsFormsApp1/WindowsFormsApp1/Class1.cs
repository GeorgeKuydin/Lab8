using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IMachine
    {
        string GetDescription();
        decimal GetCost();
    }
    public class EspressoMachine : IMachine
    {
        public string GetDescription()
        {
            return "Espresso Machine";
        }

        public decimal GetCost()
        {
            return 100m;
        }
    }

    public class DripCoffeeMachine : IMachine
    {
        public string GetDescription()
        {
            return "Drip Coffee Machine";
        }

        public decimal GetCost()
        {
            return 50m;
        }
    }
    public abstract class MachineDecorator : IMachine
    {
        protected IMachine _machine;

        public MachineDecorator(IMachine machine)
        {
            _machine = machine;
        }

        public virtual string GetDescription()
        {
            return _machine.GetDescription();
        }

        public virtual decimal GetCost()
        {
            return _machine.GetCost();
        }
    }

    public class MilkDecorator : MachineDecorator
    {
        public MilkDecorator(IMachine machine) : base(machine) { }

        public override string GetDescription()
        {
            return $"{_machine.GetDescription()} + Milk";
        }

        public override decimal GetCost()
        {
            return _machine.GetCost() + 5m;
        }
    }

    public class SugarDecorator : MachineDecorator
    {
        public SugarDecorator(IMachine machine) : base(machine) { }

        public override string GetDescription()
        {
            return $"{_machine.GetDescription()} + Sugar";
        }

        public override decimal GetCost()
        {
            return _machine.GetCost() + 2m;
        }
    }
}
