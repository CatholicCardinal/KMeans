using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMeans
{
    public class Algorithm
    {
        private static int[] classesObject;
        private static List<int[]> iterationList;
        private int Replayce;

        public static int[] ClassesObject { get => classesObject; set => classesObject = value; }
        public static List<int[]> IterationList { get => iterationList; set => iterationList = value; }

        public void KMeansAlgoritm()
        {
            IterationList = new List<int[]>();
            ClassesObject = new int[ParametrsData.ObjectNumber];

            int i = 0;
            do
            {
                RecalculationArea();
                RecalculationCentre();
                i++;
            } while (Replayce > 1);

        }

        private void RecalculationCentre()
        {
            for (int i = 0; i < ParametrsData.ClassesNumber; i++)
            {
                int N = 0, sumX =0, sumY=0;
                for (int j = 0; j < ParametrsData.ObjectNumber; j++)
                {
                    if (ClassesObject[j] == i)
                    {
                        N++;
                        sumX += ParametrsData.Vectors[j].X;
                        sumY += ParametrsData.Vectors[j].Y;
                    }
                }
                ParametrsData.CenterWeight[i].X = sumX / N;
                ParametrsData.CenterWeight[i].Y = sumY / N;
            }
        }

        private void RecalculationArea()
        {
            var copyClassesObject = new int[ParametrsData.ObjectNumber];
            ClassesObject.CopyTo(copyClassesObject, 0);

            int j = 0;
            Replayce = 0;
            ClassesObject = new int[ParametrsData.ObjectNumber];
            foreach (var vector in ParametrsData.Vectors)
            {
                float minDistance = 10000F;
                int k = 0, min = 100;
                foreach (var center in ParametrsData.CenterWeight)
                {

                    float dist = Distance(vector, center);
                    if (minDistance > dist)
                    {
                        minDistance = dist;
                        min = k;
                    }
                    k++;
                }
                if (copyClassesObject[j] != min)
                    Replayce++;
                ClassesObject[j] = min;
                j++;
            }
            IterationList.Add(ClassesObject);
        }

        private float Distance(PointF A, PointF B)
        {
            return (float)Math.Sqrt(Math.Pow((double)A.X - (double)B.X, 2) + Math.Pow((double)A.Y - (double)B.Y, 2));
        }
    }
}
