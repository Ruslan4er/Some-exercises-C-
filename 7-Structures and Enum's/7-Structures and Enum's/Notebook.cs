using System;

namespace _7_Structures_and_Enum_s
{
    public struct Notebook
    {
        private string model;
        private string producer;
        private int cost;

        public void ShowNotebook()
        {
            Console.WriteLine("Ноутбук модели:{0}, произведен:{1}, цена: {2}",model,producer,cost);
        }

        public Notebook(string model, string producer, int cost)
        {
            this.model = model;
            this.producer = producer;
            this.cost = cost;
        }

    }
}