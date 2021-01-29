using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    public class Program
    {
        static void Main(string[] args)
        {

            var numbers = MyLinq.Random()
                                .Where(n => n > 0.5)
                                .Take(10);

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            var movies = new List<Movie>
            {
                new Movie {Title = "The dark knight", Rating = 8.9f, Year = 2020 },
                new Movie {Title = "The purple knight", Rating = 7.9f, Year = 2019 },
                new Movie {Title = "The red knight", Rating = 3.9f, Year = 2020 },
                new Movie {Title = "The blue knight", Rating = 4.9f, Year = 2018 },
                new Movie {Title = "The brown knight", Rating = 2.9f, Year = 2019 },
                new Movie {Title = "The pink knight", Rating = 10.0f, Year = 2017 },
                new Movie {Title = "The yellow knight", Rating = 6.4f, Year = 2016 }
            };


            var query = movies.Where(w => w.Year > 2017)
                              .OrderByDescending(w => w.Rating);

            var enumerator = query.GetEnumerator(); 
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }
        }
    }
}