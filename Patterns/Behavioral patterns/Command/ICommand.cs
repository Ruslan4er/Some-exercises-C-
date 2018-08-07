using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class TVOnCommand :ICommand
    {
        private TV tv;

        public TVOnCommand(TV tvset)
        {
            tv = tvset;
        }

        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }

    class MicrowaveCommand : ICommand
    {
        private Microwave microwave;
        private int time;

        public MicrowaveCommand(Microwave microwave,int time)
        {
            this.microwave = microwave;
        }
        public void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }

        public void Undo()
        {
            microwave.StopCooking();
        }
    }
}
