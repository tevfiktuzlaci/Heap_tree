using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapProj
{
    public class HeapSort
    {
        private int[] dizi;
        static Heap heap = new Heap(100);
        public HeapSort(int[] dizi)
        {
            this.dizi = dizi;
            for (int i = 0; i < dizi.Length; i++) //dizi olarak aldığımız için for döngüsü kullanarak sıra ile ekledim
            {
                heap.Insert(dizi[i]);
            }
            
        }
        
        public int[] Sort()
        {
            
            for (int i = 0; i < dizi.Length; i++)
            {
                HeapDugumu max = heap.RemoveMax(); //remove metodu hem maxı veriyor hem de maxı sildiği için kullandım
                dizi[i] = max.Deger; //dizimdeki elemanları Heap ağacına eklemiştim tekrar dizime ekledim 
            }
            return dizi;
            
        }
        
    }
}
