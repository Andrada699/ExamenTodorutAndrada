using System;

namespace Exam

{
    internal class Stiva
    {
        private int[] data;
        private int capacity;
        private int size = 0;

        public int Capacity
        {
            get {
                return Capacity;
            }
        }

        public int Peek
        {
            get
            {
                if (size > 0)
                {
                    return data[size - 1];


                }
                else
                    throw new StackEmptyException("stiva nu are elemente");
            }
        }

        public Stiva(): this(8)
        {
            //data = new int[capacity];
        }

        public Stiva(int capacity)
        {
            this.capacity = capacity;
            data = new int[capacity];
        }

        public int Pop()
        {
            int returnValue;
            if (size > 0)
            {
                returnValue = data[size - 1];
                size--;
                if (size == capacity / 4)
                {
                    resize(capacity / 2);
                }
                return returnValue;
            }
            else
                throw new StackEmptyException();

        }

        public void Push(int value)
        {
            if(size==capacity)
            {
                resize(capacity * 2);
            }
            data[size++] = value;
        }

        public bool Empty()
        {
            return size == 0;


        }

        private void resize(int newCapacity)
        {
            Console.WriteLine("Stiva a fost redimensionata before {0} after{1}", capacity, newCapacity);
            int[] data2 = new int[newCapacity];

            for (int i=0;i<size;i++)
            {
                data2[i] = data[i];
            }
            capacity = newCapacity;
            data = data2;
        }




    }
    
}
