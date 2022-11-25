using System;
    class create_array
    {
        public static void Main()
        {
            int i,num=Convert.ToInt32(Console.ReadLine());
            string[] arr=new string[num]; 
            for(i=0;i<num;i++)
            {
                arr[i]=Console.ReadLine();
            }
            for(i=0;i<num;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }