//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.

namespace _05_07.Generics
{
    using System;
    using System.Collections.Generic;

    public class GenericList<T>
        where T: IComparable<T>
    {
        private const int defaultCapacity = 16;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList()
            :this(defaultCapacity)
        {
        }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index] 
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException("Index too big");
                }

                if (index<0)
                {
                    throw new IndexOutOfRangeException("Index cannot be negative");
                }

                return elements[index];
            }
        }

        private void CheckAndIncreaseCapacity(int index)
        {
            if (index < 0) //check for negative index
            {
                throw new IndexOutOfRangeException("Index cannot be negative");
            }

            if (index > this.elements.Length - 1) //enlarge the list!
            {
                T[] newElements = new T[this.elements.Length * 2];

                for (int i = 0; i < this.elements.Length; i++)
                {
                    newElements[i] = this.elements[i];
                }

                this.elements = newElements;//refernce
            }

            if (index > count) //check for too big index
            {
                throw new IndexOutOfRangeException(string.Format("Index should be not bigger than {0}!", count));
            }

        }

        public void Add(T element) 
        {
            CheckAndIncreaseCapacity(count);

            if (count>= elements.Length)
            {
                throw new IndexOutOfRangeException("Index exceed the list capacity");
            }

            this.elements[count] = element;
            count++;
        }

        public void AddAtPosition(T element, int index)
        {
            CheckAndIncreaseCapacity(index);

            if (index < count)
            {
                for (int i = count; i > index; i--)
                {
                    this.elements[count] = this.elements[count-1];
                }
            }

            this.elements[index] = element;

            count++;
        }

        public void Remove(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException("Such element does not exist!");
            }

            if (index < 0)
            {
                throw new IndexOutOfRangeException("Cannot have negative index!");
            }

            if (index <= count) //overwrite all the elements from pos we should delete with the next one
            {
                for (int i = index; i < count-1; i++)
                {
                    this.elements[index] = this.elements[index + 1];
                }
            }

            count--; // the last element stay with the value as the element befere the last, but it's not accessible from outside!
        }

        public void Clear()
        {
            count = 0; //in this way all the elements are not accessible!
        }

        public int FindFirst(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (element.Equals(this.elements[i]))
                {
                    return (i);
                }
            }

            return -1;
        }

        public T Min()
        {
            T min = elements[0];
            for (int i = 0; i < count; i++)
            {
                if (min.CompareTo(elements[i]) > 0)
                {
                    min = elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = elements[0];
            for (int i = 0; i < count; i++)
            {
                if (max.CompareTo(elements[i]) < 0)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            string result = "";

            if (count == 0)
            {
                return "Empty";
            }

            for (int i = 0; i < count; i++)
            {
                result += "[" + this.elements[i].ToString() + "] ";
            }
            return result;
        }
    }
}
