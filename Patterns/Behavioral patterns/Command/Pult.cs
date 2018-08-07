using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Pult
    {
        private ICommand command;

        public Pult()
        {

        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            if (command != null)
                command.Execute();
        }

        public void PressUndo()
        {
            if (command != null)
                command.Undo();
        }

    }
}
