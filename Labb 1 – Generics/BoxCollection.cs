using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Generics
{
    internal class BoxCollection : ICollection<Box>
    {

        private List<Box> innerCol;

        public BoxCollection()
        {
            innerCol = new List<Box>();
        }

        public Box this[int index]
        {
            get { return innerCol[index]; }
            set { innerCol[index] = value; }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }


        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine($"Box with dimensions L:{item.height} L:{item.length} W:{item.width} already exists in the system");
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(Box item)
        {
            bool found = false;

            foreach (var box in innerCol)
            {
                if (box.Equals(item))
                {
                    found = true;
                    
                }
            }

            

            return found;
        }

        public bool Contains(Box? item, EqualityComparer<Box> comparer)
        {
            bool found = false;
            foreach (var box in innerCol)
            {
                if (comparer.Equals(box, item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than" +
                                            "the collection");
            }

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }



        public bool Remove(Box item)
        {
            bool result = false;

            for (int i = 0; i < innerCol.Count; i++)
            {
                Box box = innerCol[i];
                if (new BoxSameDimensions().Equals(box, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    Console.WriteLine($"Box width dimensions H: {box.height} L: {box.length} W:{box.width}");
                    break;
                }
            }

            return result;
        }

        public int Count
        {
            get { return innerCol.Count; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}
