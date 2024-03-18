public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, User!");
        Console.WriteLine("Hello, User!!!!!");
        Console.WriteLine("Hello, User!!!!!11111");


        int[] arr = new[] { 1, 2, 3};
        Console.WriteLine(GetAvg(arr));

        static double GetAvg(int[] arr)
        {
            int result = 0;
            foreach (var num in arr)
            {
                result += num;
            }

            return (double)result / arr.Length;
        }

        Console.WriteLine(findMax(arr));
    }

    public static int findMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}



