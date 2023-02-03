namespace Helpers
{
    public class Helpers
    {
        public static void Age()
        {
            Console.WriteLine("Enter your age in years");
            int age = Convert.ToInt16(Console.ReadLine());
            int ageInDays = age * 365;
            Console.WriteLine("Age in Days" + ageInDays);
        }
        public static void SumofArray()
        {
            int[] Array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int sum = Array.Sum();
            Console.WriteLine("Sum of Array is" + sum);
        }
        public static void Frequency()
        {

            int[] array = { 1, 2, 3, 4, 3, 4, 3, 2, 1, 5, 6, 7, 5, 6 };
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {

                int count = 0;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }

                }
                Console.WriteLine(array[i] + " " + count);
            }
        }

        public static void CheckList()
        {
            List<int> numbers = new List<int>() { 2, 2, 2, 2, 2, 2 }; // Initializing list 


            bool isAllEqual = numbers.Distinct().Count() == 1;

            Console.WriteLine(isAllEqual);
        }
        public static void ReverseString()


        {
            string str = ("Knowledge Stream");
            int len = str.Length;
            for (int i = len - 1; i >= 0; i--)
            {

                Console.WriteLine(str[i]);


            }
        }
        public static void RemoveLisItems()
        {
            var list = new List<string> { "abc", "def", "ghj", "kli", "adkja" };

            int indexToRemove = 1;    // passing object

            list.RemoveAt(indexToRemove);

            Console.WriteLine(String.Join(", ", list));


        }
    }
}

