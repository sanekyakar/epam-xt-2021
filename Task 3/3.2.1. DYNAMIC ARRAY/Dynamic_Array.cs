using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._1.DYNAMIC_ARRAY
{
    public class Dynamic_Array<T>: IEnumerable<T>, ICloneable
    {
        //поля
        private int count = 0;
        private T[] mass;

        //свойства
        public int Length => count;

        public int Capacity
        {
            get
            {
                return mass.Length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity connot be negative");
                }

                if (value < Length)
                {
                    Array.Resize(ref mass, value);
                    count = value;
                }
                else if (value > Length)
                {
                    T[] arr = new T[value];
                    Array.Copy(mass, 0, arr, 0, count);
                    mass = arr;
                    arr = null;
                }
                else { return; }

            }
        }

        //конструкторы
        public Dynamic_Array()
        {

            mass = new T[8];
        }

        public Dynamic_Array(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Capacity connot be negative");
            }
            else
            {
                mass = new T[value];
            }
        }

        public Dynamic_Array(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            else
            {

                count = collection.Count();
                if (count == 0)
                {
                    mass = new T[8];
                }
                else
                {
                    mass = new T[collection.Count()];
                    collection.ToArray<T>().CopyTo(mass, 0);
                }
            }
        }

        //индексатор
        public T this[int index]
        {
            get
            {
                if (index < mass.Length && index > -1)
                {
                    return mass[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
                }
            }
            set
            {
                if (index < mass.Length && index > -1)
                {
                    mass[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
                }
            }
        }

        //методы
        public void Add(T item)
        {
            if (Length == Capacity)
            {
                T[] arr;

                if (Capacity == 0)
                {
                    arr = new T[8];
                }
                else
                { 
                    arr = new T[Capacity * 2];
                }

                Array.Copy(mass, 0, arr, 0, Length);
                arr[Length] = item;
                ++count;
                mass = arr;
                arr = null;
            }
            else 
            {
                mass[Length] = item;
                ++count;
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if ((collection.Count() + Length) > Capacity)
            {
                T[] arr = new T[(collection.Count() + Length) * 2];
                mass.CopyTo(arr, 0);
                collection.ToArray<T>().CopyTo(arr, Length);
                mass = arr;
                arr = null;
                count += collection.Count();
            }
            else 
            {
                collection.ToArray<T>().CopyTo(mass, Length);
                count += collection.Count();
            }
        }

        public bool Remove(T item) 
        {
            int index = Array.IndexOf(mass, item, 0, Length);

            if (index >= 0)
            {
                if (index > Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Array.Copy(mass, index + 1, mass, index, Length - index - 1);
                    --count;
                }
                return true;
            }
            else return false;
        }

        public bool Insert(T item, int index)
        {
            if (index < 0 || index > Length+1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else 
            {
                if (Length + 1 < Capacity)
                {
                    T[] arr = new T[Capacity];
                    Array.Copy(mass, 0, arr, 0, index-1);
                    arr[index-1] = item;
                    Array.Copy(mass, index-1, arr, index, Length - index + 1);
                    mass = arr;
                    arr = null;
                    ++count;
                    return true;
                }
                else 
                {
                    T[] arr = new T[Capacity * 2];
                    Array.Copy(mass, 0, arr, 0, index-1);
                    arr[index-1] = item;
                    Array.Copy(mass, index-1, arr, index, Length - index + 1);
                    mass = arr;
                    arr = null;
                    ++count;
                    return true;
                }               
            }   
        }

        public T[] ToArray()
        {
            T[] arr = new T[] { };
            Array.Copy(mass, 0, arr, 0, Length);
            return arr;

        }
        

        public object Clone()
        {
            return new Dynamic_Array<T>(Length);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)mass).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mass.GetEnumerator();
        }
    }
}
