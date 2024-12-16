namespace Set3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vector de numere: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.Write("Numar k: ");
            int k = int.Parse(Console.ReadLine());

            int poz = 0;

            if (v.Contains(k)) 
            {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != k)
                {
                    poz++;
                }
            }
                Console.WriteLine(poz);

            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
