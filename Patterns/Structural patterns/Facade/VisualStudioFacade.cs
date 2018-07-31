using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class VisualStudioFacade
    {
        protected TextEditor textEditor;
        protected Compiller compiller;
        protected CLR Clr;

        public VisualStudioFacade(TextEditor te, Compiller c, CLR clr)
        {
            textEditor = te;
            compiller = c;
            Clr = clr;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            Clr.Execute();
        }

        public void Stop()
        {
            Clr.Finish();
        }
    }


    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
