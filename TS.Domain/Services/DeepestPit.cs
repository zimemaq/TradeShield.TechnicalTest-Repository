using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Services
{
    public class DeepestPit : IDeepestPit
    {
        public int GetPitDepth(int[] points)
        {
            int arrayLength = points.Length;
            int maximumDepth = -1;

            // Try solution with nested loops. This might introduce performance issues on large arrays
            for (int P = 0; P < arrayLength - 2; P++)
            {
                for (int Q = P + 1; Q < arrayLength - 1; Q++)
                {
                    if (points[P] > points[Q])
                    {
                        for (int R = Q + 1; R < arrayLength; R++)
                        {
                            int minDepth = Math.Min(points[P] - points[Q], points[R] - points[Q]);
                            maximumDepth = Math.Max(maximumDepth, minDepth);
                        }
                    }
                }
            }            

            return maximumDepth;
        }
    }
}
