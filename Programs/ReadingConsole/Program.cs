using System;

namespace ReadingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            string arrayLengths = Console.ReadLine();
            int N1 = int.Parse(arrayLengths.Split(' ')[0]);
            int N2 = int.Parse(arrayLengths.Split(' ')[1]);
            string array1items = Console.ReadLine();
            string array2items = Console.ReadLine();

            int[] arr1 = new int[N1];
            int[] arr2 = new int[N2];

            for(int i = 0; i < N1; i++)
            {
                arr1[i] = int.Parse(array1items.Split(' ')[i]);
            }

            for(int j = 0; j < N2; j++)
            {
                arr2[j] = int.Parse(array2items.Split(' ')[j]);
            }

            Console.Write($"Array1 items are ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
            Console.Write($"Array2 items are ");
            for(int j = 0; j < N2; j++)
            {
                Console.Write($"{arr2[j]} ");
            }

        string selectedColumn = SelectColumn(arr1,arr2);
        Console.WriteLine(selectedColumn);
        }

        public static string SelectColumn(int[] a1, int[] a2)
	{
	    int sumofFirstArray = 0;
	    int sumofSecondArray = 0;
	    
	    for(int i = 0; i < a1.Length; i++)
	    {
	        sumofFirstArray += a1[i];
	    }
	    
	    for(int j = 0; j < a2.Length; j++)
	    {
	        sumofSecondArray += a2[j];
	    }
	    
	    if(sumofFirstArray != sumofSecondArray)
	    {
	        return sumofFirstArray > sumofSecondArray ? "C1" : "C2";
	    }
	    else
	    {
	        return "C1";
	    }
	}
    }
}
