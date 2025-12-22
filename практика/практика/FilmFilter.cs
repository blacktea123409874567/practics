using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace практика
{
    public class FilmFilter
    {

        private Dictionary<string, List<Movy>> _catolog = new Dictionary<string, List<Movy>>();
        private Dictionary<string, Movy> _AllMovies = new Dictionary<string, Movy>();

        private const string DATE_FILE_PATH = "movy_database.json";


        public void CtreateCatalog(string jonure)
        {
            if (string.IsNullOrWhiteSpace(jonure))
            {
                Console.WriteLine("alooo jonure is empty");
                return;
            }

            if (_catolog.ContainsKey(jonure)) 
            {
                Console.WriteLine("༼ つ ◕_◕ ༽つ yoo bro this catolog olready be ");
                return;
            }
            _catolog.Add(jonure, new List<Movy>());
        }

        public void CreateMovie()
        {
            string nameMovie = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nameMovie)) 
            {
                Console.WriteLine($"bro common this film  really name '{nameMovie}'");
                return;
            }

            if (_AllMovies.Any( x=> x.Value.Equals(nameMovie)))
            {
                Console.WriteLine("༼ つ ◕_◕ ༽つ yoo bro this movie olready be ");
                return;
            }

        }

        public void WorkWithCatalog()
        {
            Console.Clear();
            Console.WriteLine("=== all catalode === ");

            if (_catolog.Count == 0)
            {
                Console.WriteLine("net hotcatov");
                return;
            }
            else
            {
                foreach (var catolog in _catolog)
                {
                    Console.WriteLine($"{catolog.Key} -{catolog.Value} ");
                }
            }

            Console.WriteLine("== choose cstologe ==");
            if (_catolog.Count == 0)
            {
                Console.WriteLine("create catalog pleaze");
                return;
            }
            Console.WriteLine("dostupnie catalizatory(catalogy)");

            int index = 0;
            var catalogList = _catolog.Keys.ToList();

            foreach (var cat in catalogList) 
            {
                Console.WriteLine($"{index}. {cat} ");
                index++;
            }

        }


        // описать функцию поиска
        public void FindMovie()
        {
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine(" ");
            }
        }

        public void ShowMoviesInCatalog()
        {
            string gener = Console.ReadLine();

            var movies = _catolog[gener];
            if (movies.Count == 0)
            {
                Console.WriteLine("net filmov");
            }
            else
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {movies[i]}");
                }
            }
        }

        public void Run()
        {
            LoadData();
            ShowMainMenu();
        }




        public void ShowMainMenu() 
        {
            bool IsRun = true;
            while (IsRun)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("===choose move===");
                Console.WriteLine("0. create catalog");
                Console.WriteLine("1. create movy");
                Console.WriteLine("2. open catalog");
                Console.WriteLine("3. export catalog in file");
                Console.Write("4. find movie ");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("(¬‿¬)");
                Console.Write("5. exite");

                

                int choose = int.Parse(Console.ReadLine());

                switch (choose) 
                {
                    case 0:
                        string jonure = Console.ReadLine();
                        CtreateCatalog(jonure);
                        break;
                    case 1:
                        CreateMovie();
                        break;
                    case 2:
                        WorkWithCatalog();
                        break;
                    case 3:
                        ExportCatalog();
                        break;
                    case 4:
                        FindMovie();
                        break;
                    case 5:
                        IsRun = false;
                        break;
                    default:
                        break;
                }
            }
        } 
    }
} 
