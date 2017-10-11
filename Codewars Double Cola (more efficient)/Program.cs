using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Double_Cola__more_efficient_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            long n = 6;

            
            Console.WriteLine(WhoIsNext(names, n));
            Console.ReadLine();
        }

        public static string WhoIsNext(string[] names, long n)
        {
            long trimmed = n - 1;     //changes indexing so 1st now is 0th, etc.
            double generation = 0;  //generation refers to cloning generations, the O.G.'s are in generation 0, their direct clones are in generation 1

            for (int i = 5; i <= trimmed; i = i * 2)   //i is the number of members in each generation, 5 for the 0th, 10 for the 1st, 20 for the 3rd
            {
                trimmed -= i;    //after looping, subtracts all the members of previous generations
                generation += 1;
            }

            long place_in_generation = trimmed;  //clarifies meaning of trimmed for further calculations 
            double total_in_generation = 5.0 * (Math.Pow(2.0, generation));
            int origin_parent = Convert.ToInt16(Math.Floor((place_in_generation * 5.0) / total_in_generation));  //ratio comparison, place_in_gen is to total_in_gen as what is to 5 (total of gen 0), rounds down to find the O.G. parent



            return names[origin_parent];


        }
    }
}
