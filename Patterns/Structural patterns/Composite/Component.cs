using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        protected string name;

        protected Component(string name)
        {
            this.name = name;
        }

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }

    class Directory : Component
    {
        private List<Component> components = new List<Component>();

        public Directory(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Узел " + name);
            Console.WriteLine("Подузлы: ");
            foreach (Component t in components)
            {
                t.Print();
            }
        }
    }

    class File : Component
    {
        public File(string name) : base(name)
        {
        }
    }
}

