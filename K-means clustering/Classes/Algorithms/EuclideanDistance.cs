using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means_clustering.Classes.Algorithms
{
    class EuclideanDistance : IDistance
    {

        public double Calculate(double[] currentPoint, double[] epicenter)
        {
            // Euclidean distance between two vectors for UpdateClustering()
            // consider alternatives such as Manhattan distance
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < currentPoint.Length; ++j)
                sumSquaredDiffs += Math.Pow((currentPoint[j] - epicenter[j]), 2);
            return Math.Sqrt(sumSquaredDiffs);
        }
    }
}
