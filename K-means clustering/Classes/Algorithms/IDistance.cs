using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means_clustering.Classes.Algorithms
{
    interface IDistance : IAlgorithm
    {
        double Calculate(double[] currentPoint, double[] centroid);
    }
}
