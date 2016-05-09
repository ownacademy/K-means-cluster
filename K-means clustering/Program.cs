using K_means_clustering.Classes.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means_clustering
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader reader = new FileReader();
            reader.StartRead();

            Console.ReadKey();
        }
    }
}
