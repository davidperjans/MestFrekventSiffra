namespace MestFrekventSiffra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // 2
            Console.WriteLine(MestFrekventSiffra(new int[] { 4, 3, 3, 3, 1, 1, 1, 2, 2, 2 })); // 1
        }

        public static int MestFrekventSiffra(int[] arrayOfNumbers)
        {
            var numberStoringDictionary = new Dictionary<int, int>();
            foreach (var number in arrayOfNumbers)
            {
                if (numberStoringDictionary.ContainsKey(number))
                {
                    numberStoringDictionary[number]++;
                }
                else
                {
                    numberStoringDictionary.Add(number, 1);
                }
            }
            return numberStoringDictionary.OrderByDescending(par => par.Value).ThenBy(par => par.Key).First().Key;
        }
    }
}
