using System;
using System.Globalization;
using TrainingEighteen.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Count = new Dictionary<string, int>();

            HashSet<VoteCounting> set = new HashSet<VoteCounting>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] count = sr.ReadLine().Split(',');
                        string candidate = count[0];
                        int vote = int.Parse(count[1]);

                        if (Count.ContainsKey(candidate))
                        {
                            Count[candidate] += vote;
                        }
                        else
                        {
                            Count[candidate] = vote;
                        }
                        
                    }
                    foreach(var item in Count)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                    
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

/* Dictionary<string, string> Cookies = new Dictionary<string, string>();

            Cookies["user"] = "Denior Quadros";
            Cookies["email"] = "denior@gmail.com";
            Cookies["phone"] = "98888-8888";

            Console.WriteLine(Cookies["user"]);

            Cookies.Remove("phone");
            if (Cookies.ContainsKey("phone"))
            {
                Console.WriteLine(Cookies["phone"]);
            }
            else
            {
                Console.WriteLine("phone not exist");
            }

            Console.WriteLine("Size: " + Cookies.Count);

            Console.WriteLine("ALL COOKIES:");

            foreach (KeyValuePair<string, string> item in Cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

*/