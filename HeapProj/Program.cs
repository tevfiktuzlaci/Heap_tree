using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapProj
{
    class Program
    {
        static Heap h = new Heap(100);
        
        public static void BuildInitialHeap()
        {
            h.Insert(45);
            h.Insert(35);
            h.Insert(23);
            h.Insert(27);
            h.Insert(21);
            h.Insert(22);
            h.Insert(4);
            h.Insert(19);
            Console.WriteLine("ADIM 1 - Heap oluşturuldu....\n");
            h.DisplayHeap();
            Console.ReadLine();
        }

        public static void Insert42()
        {
            h.Insert(42);
            Console.WriteLine("ADIM 2 - 42 elemanı Heap'e eklendi....\n");
            h.DisplayHeap();
            Console.ReadLine();
        }


        public static void RemoveMax()
        {
            HeapDugumu max = h.RemoveMax();
            Console.WriteLine("ADIM 3 - Max eleman ({0}) Heap'ten silindi....\n", max.Deger);
            h.DisplayHeap();
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            BuildInitialHeap();
            Insert42();
            RemoveMax();
            HeapSort();

        }

        public static void HeapSort()
        {
            int [] dizi = {2, 6, 1, 4, 5, 9, 11, 3, 8, 34};
            
            HeapSort hs = new HeapSort(dizi);
            int[] sorted = hs.Sort();
            Console.Write("Sirali Dizi=");
            foreach (var item in sorted)
            {
                Console.Write(item.ToString() + ",");
            }
            Console.ReadLine();                

        }
    }
}
