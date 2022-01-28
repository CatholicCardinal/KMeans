using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace KMeans
{
    public class RandomGeneration
    {
        private const int MaxValueVector = 1000;
        
        public RandomGeneration()
        {
            var rnd = new Random();

            ParametrsData.ClassesNumber = rnd.Next(5, 10);
            ParametrsData.ObjectNumber = rnd.Next(1000, 20000);
        }

        public RandomGeneration(int ClassesNumber1, int ObjectNumber1)
        {
            ParametrsData.ClassesNumber = ClassesNumber1;
            ParametrsData.ObjectNumber = ObjectNumber1;
        }

        public void Generation()
        {
            var rnd = new Random();
            ParametrsData.Vectors = new Point[ParametrsData.ObjectNumber];

            for (var i = 0; i < ParametrsData.Vectors.Length; i++)
            {
                ParametrsData.Vectors[i].X = rnd.Next(0, MaxValueVector);
                ParametrsData.Vectors[i].Y = rnd.Next(0, MaxValueVector);
            }

            RdmSelectCentreWeight();
        }

        private void RdmSelectCentreWeight()
        {
            var rnd = new Random();
            ParametrsData.CenterWeight = new PointF[ParametrsData.ClassesNumber];

            for (int i = 0; i < ParametrsData.CenterWeight.Length; i++)
            {
                ParametrsData.CenterWeight[i] = ParametrsData.Vectors[rnd.Next(0, MaxValueVector)];
            }
        }

        
    }
}
