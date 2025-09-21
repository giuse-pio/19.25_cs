namespace _19._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            string input;
            do
            {
                Console.Write("inserisci un numero(o premi invio per uscire): ");
                input = Console.ReadLine();
                int number;
                if (input == "")
                    break;
                else
                {
                    int.TryParse(input, out number);
                    a.Add(number);
                }

            } while (input != "");
            do
            {
                Console.Write("inserisci un numero(o premi invio per uscire): ");
                input = Console.ReadLine();
                int number;
                if (input == "")
                    break;
                else
                {
                    int.TryParse(input, out number);
                    b.Add(number);
                }

            } while (input != "");

            foreach (int n in a)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            foreach (int n in b)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            List<int> c = unione(a, b);

            foreach (int n in c)
            {
                Console.WriteLine(n);
            }


            List<int> unione(List<int> a, List<int> b)
            {
                List<int> tot = new List<int>();
                tot.AddRange(a);
                foreach (int n in b)
                {
                    if (!tot.Contains(n))
                    {
                        tot.Add(n);
                    }
                }
                return tot;
            }
        }
    }
}
