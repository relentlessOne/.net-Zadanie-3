using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class DynamicArray
    {
        int[] arr;
        int size;

        public int this[int i]
        {
            get
            {
                try
                {
                
                    if (i > size)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        return arr[i];
                    }
              
                } catch (Exception)
                {
                    Console.WriteLine("There is no index "+ i);
                    return 0;
                }
             
            }
            set
            {
                try
                {


                    if (i > size-1)
                    {
                       
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        arr[i] = value;
                    }


                } catch (Exception)
                {



                    bool stopMemoryReserving = false;


                    while (!stopMemoryReserving)
                    {
                        Array.Resize(ref arr, arr.Length * 2);

                        if (arr.Length > i)
                            stopMemoryReserving = true;
                    }


                    //Console.WriteLine("size " + size);

                    //Console.WriteLine("arr.lenght " + arr.Length);

                    //Console.WriteLine("i " + i);


                    if (size < i)
                    {
                        for (int j = size ; j < i ; j++)
                        {
                            arr[j] = -1;
                            size++;
                        }
                    }

                    arr[i] = value;
                    size++;
                }
       
            }
        }

        public void display()
        {
            Console.WriteLine("The size of the array is {0}", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


        }

     
        public void add(int what)
        {
            Array.Resize(ref arr, arr.Length * 2);
            size++;
            arr[size-1] = what;
        }


        public DynamicArray(int size)
        {
            this.size = size;
            this.arr = new int[this.size];
            
            for(int i = 0; i < this.arr.Length; i++)
            {
                arr[i] = -1;
            }
         
        }
    }
}
