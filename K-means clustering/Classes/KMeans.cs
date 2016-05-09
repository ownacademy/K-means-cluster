using K_means_clustering.Classes.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means_clustering
{
    class KMeans
    {
        static void Main(string[] args)
        {
            FileReader reader = new FileReader();


            Console.WriteLine("\nBegin k-means clustering\n");
            reader.StartRead();


            Console.WriteLine("Raw unclustered data:\n");
            //Maybe show data


            //set count of clusters
            int numClusters = 3;
            Console.WriteLine("\nSetting numClusters to " + numClusters);

            int[,] rawData = reader.getDataSet();
            int[] clustering = Cluster(rawData, numClusters);

            Console.WriteLine("\nK-means clustering complete\n");

            //ShowClustered data

            Console.WriteLine("\nEnd k-means clustering\n");
            Console.ReadKey();

        }

        private static int[] Cluster(object rawData, int numClusters)
        {
            throw new NotImplementedException();
        }
    }
}
