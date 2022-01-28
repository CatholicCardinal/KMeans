using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMeans
{
    public class ParametrsData
    {
        private static int classesNumber;
        private static int objectNumber;
        public static Point[] Vectors;
        private static PointF[] centerWeight;

        public static int ClassesNumber { get => classesNumber; set => classesNumber = value; }
        public static int ObjectNumber { get => objectNumber; set => objectNumber = value; }
        public static PointF[] CenterWeight { get => centerWeight; set => centerWeight = value; }
    }
}
