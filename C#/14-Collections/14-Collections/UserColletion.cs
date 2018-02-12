using System.Collections;

namespace _14_Collections
{
    public class UserColletion : IEnumerable, IEnumerator
    {
        Element[] elementsArray;

        public UserColletion()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element();
            elementsArray[1] = new Element();
            elementsArray[2] = new Element();
            elementsArray[3] = new Element();
        }

        private int position = -1;


        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return elementsArray[position]; }
        }
    }

}
