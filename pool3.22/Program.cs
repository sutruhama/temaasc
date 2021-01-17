using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Introduce the size of first array:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce the size of second array:");
            n2 = int.Parse(Console.ReadLine());
            int[] v1 = new int[n1];
            int[] v2 = new int[n2];
            Console.WriteLine("Introduce the numbers of first array:");
            for (int i = 0; i < n1; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce the numbers of second array:");
            for (int i = 0; i < n2; i++)
                v2[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Elements of FirstArray(v1):");
            for (int i = 0; i < n1; i++)
                Console.WriteLine(v1[i] + " ");
            Console.WriteLine("Elements of SecondArray(v2):");
            for (int i = 0; i < n2; i++)
                Console.WriteLine(v2[i] + " ");
            ExpectMethod(v1,v2); 
            IntersectMethod(v1,v2);  
            UnionMethod(v1,v2);
            Console.ReadLine();
        }
        private static void ExpectMethod(int []vec1,int []vec2)
        {
            Console.WriteLine("-----------------------------ExpectMethod------------------------------");
            
            int[] Except = vec1.Except(vec2).ToArray();
            Console.WriteLine("Expect Result:");
            foreach (int num in Except)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

        }
        
        private static void IntersectMethod(int []arr1,int []arr2)
        {
            Console.WriteLine("-----------------------------IntersectMethod------------------------------");
            int[] Results = arr1.Intersect(arr2).ToArray();
            Console.WriteLine("Intersect Result:");

            foreach (int Result in Results)
            {
                Console.Write("{0} ", Result);
            }
        }
 
        private static void UnionMethod(int []a, int []b)
        {
            Console.WriteLine("-----------------------------UnionMethod------------------------------");
            int[] UnResult = a.Union(b).ToArray();
            Console.WriteLine("Union Result");
            foreach (int s in UnResult)
            {
                Console.Write(s+" ");
            }
        }
    }
}
