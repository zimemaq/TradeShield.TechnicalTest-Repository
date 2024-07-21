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

            //int P = 0;
            //int Q = -1;
            int R = -1;

            // Try solution with nested loops. This might introduce performance issues on large arrays
            for(int P = 0; P < arrayLength - 2; P++)
            {
                for(int Q = P + 1; Q < arrayLength - 1; Q++)
                {
                    if (R >= 0 && points[P] > points[Q - 1])
                    {
                        maximumDepth = Math.Max(maximumDepth, Math.Min(points[P] - points[Q], points[R] - points[Q]));
                        R = -1;
                    }
                }
            }

            //for (int i = 1; i < arrayLength; i++)
            //{
            //    if(Q < 0 && points[i] < points[i - 1])
            //    {
            //        Q = i - 1;
            //    }

            //    if(Q >= 0 && (R < 0 || points[i] < points[i - 1]))
            //    {
            //        R = 1;
            //    }

            //    if(R >= 0 && points[i] > points[i - 1])
            //    {
            //        maximumDepth = Math.Max(maximumDepth, Math.Min(points[P] - points[Q], points[R] - points[Q]));
            //        P = i - 1;
            //        Q = -1;
            //        R = -1;
            //    }                
            //}

            return maximumDepth;
        }
    }
}
