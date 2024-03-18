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
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }

            return (double)sum / arr.Length;
        }
    }
}



