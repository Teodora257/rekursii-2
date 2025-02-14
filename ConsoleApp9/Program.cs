namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete chislo: ");
            int n = int.Parse(Console.ReadLine());

            if (IsPowerOfTwo(n))
            {
                Console.WriteLine($"{n} e stepen na 2.");
            }
            else
            {
                Console.WriteLine($"{n} ne e stepen na 2.");
            }
        }
        static bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;  
            if (n == 1) return true;  
            if (n % 2 != 0) return false;  

            
            return IsPowerOfTwo(n / 2);
        }
    }
}

