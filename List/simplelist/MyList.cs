using System;

namespace simplelist
{
    class MyList<T>
    {
        private int Capacity { get; set; }
        private Object[] Items;
        public MyList()
        {
            Items = new Object[10];
        }
        private void EnsureCapacity()
        {
            int newSize = Items.Length * 2;
            Array.Copy(Items, Items, newSize);

        }
        public void Add(T data)
        {
            if(Capacity==Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = data;
        }
        public T GetData(int id)
        {
            if(id>=Capacity || id<0)
            {
                throw new IndexOutOfRangeException("Index: " + id + ", Capacity: " + Capacity);
            }
            return (T)Items[id];
        }
    }    
}
