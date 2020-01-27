using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Short
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            String s = "zyxcba";
           // sortString(s);
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                k++;
            }
            Console.WriteLine(k);
            Console.WriteLine(String.Join("", arr));
            Console.ReadKey();
        }
        static void sortString(String str)
        {
            
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
          
            Console.WriteLine(String.Join("", arr));
          
        }
    }

    public abstract class customer
    {

        private int id;
        
    }
}
