using System;
    class create_array
    {
        public static void Main()
        {
            int i,num=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[num]; 
            for(i=0;i<num;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<num;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }