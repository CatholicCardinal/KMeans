using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMeans;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGeneration randomGeneration = new RandomGeneration();
            Algorithm algorithm = new Algorithm();

            randomGeneration.Generation();
            algorithm.KMeansAlgoritm();

            for (int j = 0; j < Algorithm.IterationList.Count; j++)
            {
                Bitmap b = new Bitmap(1000, 1000);
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.White);
                    // что нибудь рисуете
                    // g.DrawRectangle(...
                    Pen pen = new Pen(Color.Black);
                    pen.Width = 1 / 1000;

                    for (int i = 0; i < ParametrsData.ObjectNumber; i++)
                    {
                        g.DrawRectangle(SelectColor(j, i), ParametrsData.Vectors[i].X, ParametrsData.Vectors[i].Y, 1, 1);
                        g.FillRectangle(SelectColor(j, i).Brush, ParametrsData.Vectors[i].X, ParametrsData.Vectors[i].Y, 1, 1);
                    }
                }
                b.Save("D:\\TestKMeans\\Iteration"+j.ToString()+".bmp", System.Drawing.Imaging.ImageFormat.Bmp);

            }
        }

        private static Pen SelectColor(int j, int i)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            switch (Algorithm.IterationList[j][i])
            {
                case 1:
                    pen.Color = Color.Red;
                    break;
                case 2:
                    pen.Color = Color.Coral;
                    break;
                case 3:
                    pen.Color = Color.Blue;
                    break;
                case 4:
                    pen.Color = Color.Green;
                    break;
                case 5:
                    pen.Color = Color.Brown;
                    break;
                case 6:
                    pen.Color = Color.Orange;
                    break;
                case 7:
                    pen.Color = Color.HotPink;
                    break;
                case 8:
                    pen.Color = Color.Purple;
                    break;
                case 9:
                    pen.Color = Color.Gold;
                    break;
                case 10:
                    pen.Color = Color.DarkRed;
                    break;
                default:
                    pen.Color = Color.Black;
                    break;
            }
            return pen;
        }
    }
}
