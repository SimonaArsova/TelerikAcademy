using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class GenericList<T>
        where T: IComparable
    {
        private T[] elements;

        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return elements.Length;
            }
        }

        public GenericList(int initialCapacity)
        {
            this.elements = new T[initialCapacity];
            this.Count = 0;
        }

        public void Add(T item)
        {
            if(this.Count == this.Capacity)
            {
                Expand();
            }
            elements[this.Count] = item;
            this.Count++;
        }

        public void AddAtGivenPosition(T item, int index)
        {
            if (this.Count == this.Capacity)
            {
                Expand();
            }

            for (int i = this.Count; i > index; i--)
            {
                this.elements[i] = this.elements[i-1];
            }
            this.elements[index] = item;
            this.Count++;
        }

        private void Expand()
        {
            var newElements = new T[2 * this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

        public void RemoveAtGivenPosition(int index)
        {
            
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        public void RemoveAll()
        {
            for (int i = 0; i < this.Count; i++)
            {
                elements[i] = default(T);
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                this.elements[index] = value;
            }
        }

        public T Min()
        {
            T min = elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].CompareTo(min)==-1)
                {
                    min = elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].CompareTo(max)==1)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(elements[i]);
                if(i != this.Count - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }
    }
}
