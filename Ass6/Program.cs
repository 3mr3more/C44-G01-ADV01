using System.Collections;

namespace Ass6
{
    internal class Program
    {
public static void ReverseArray(ArrayList list)
    {
        int start = 0;
        int end = list.Count - 1;

        while (start < end)
        {
            object temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            start++;
            end--;
        }
    }
        public static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> even = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    even.Add(num);
            }
            return even;
        }
        static void Main(string[] args)
        {
            ArrayList arr = [ 1, 2, 3, 4, 5 ];
            ReverseArray(arr);
            foreach (int item in arr)
                Console.Write(item); 


        }

    }
}
