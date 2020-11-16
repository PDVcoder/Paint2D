using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Windows.Forms;

namespace Paint2D
{
    class Fractal
    {
        public double devcof = 0.501;
        WorkSpace f1;
        public Fractal(double val, WorkSpace f)
        {
            devcof = val;
            f1 = f;
        }

        // Фрактальний трикутник
        public void fractal_tringle(Color color, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Random rand = new Random();
            int point;
            int xcp = (x1 + x2) / 2;
            int ycp = y3;

            for (int i = 0; i < 200000; i++)
            {
                point = rand.Next(0, 4);
                try
                {
                    switch (point)
                    {
                        case 1:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x1 + (xcp - x1) * devcof));
                            ycp = Convert.ToInt32((y1 + (ycp - y1) * devcof));
                            break;
                        case 2:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x2 + (xcp - x2) * devcof));
                            ycp = Convert.ToInt32((y2 + (ycp - y2) * devcof));
                            break;
                        case 3:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x3 + (xcp - x3) * devcof));
                            ycp = Convert.ToInt32((y3 + (ycp - y3) * devcof));
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    return;
                }

            }
            //picture.Image = bmp;
        }

        // Фрактальний прямокутник
        public void fractal_rect(Color color, int x1, int y1, int x2, int y2)
        {
            Random rand = new Random();
            int point;
            int xcp = x1;
            int ycp = y1;

            int x3 = x1;
            int y3 = y2;

            int x4 = x2;
            int y4 = y1;

            int x5 = x1 + (x2 - x1) / 2;
            int y5 = y1;

            int x6 = x1;
            int y6 = y1 + (y2 - y1) / 2;

            int x7 = x1 + (x2 - x1) / 2; ;
            int y7 = y2;

            int x8 = x2;
            int y8 = y1 + (y2 - y1) / 2;

            for (int i = 0; i < 200000; i++)
            {
                point = rand.Next(0, 9);
                try
                {
                    switch (point)
                    {
                        case 1:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x1 + (xcp - x1) * devcof));
                            ycp = Convert.ToInt32((y1 + (ycp - y1) * devcof));
                            break;
                        case 2:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x2 + (xcp - x2) * devcof));
                            ycp = Convert.ToInt32((y2 + (ycp - y2) * devcof));
                            break;
                        case 3:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x3 + (xcp - x3) * devcof));
                            ycp = Convert.ToInt32((y3 + (ycp - y3) * devcof));
                            break;
                        case 4:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x4 + (xcp - x4) * devcof));
                            ycp = Convert.ToInt32((y4 + (ycp - y4) * devcof));
                            break;
                        case 5:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x5 + (xcp - x5) * devcof));
                            ycp = Convert.ToInt32((y5 + (ycp - y5) * devcof));
                            break;
                        case 6:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x6 + (xcp - x6) * devcof));
                            ycp = Convert.ToInt32((y6 + (ycp - y6) * devcof));
                            break;
                        case 7:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x7 + (xcp - x7) * devcof));
                            ycp = Convert.ToInt32((y7 + (ycp - y7) * devcof));
                            break;
                        case 8:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x8 + (xcp - x8) * devcof));
                            ycp = Convert.ToInt32((y8 + (ycp - y8) * devcof));
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    return;
                }

            }
            //picture.Image = bmp;
        }

        // Фрактальний ромб
        public void fractal_romb(Color color, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            Random rand = new Random();
            int point;
            int xcp = x1;
            int ycp = y1;


            int x5 = x1 + (x2 - x1) / 2;
            int y5 = y1 + (y2 - y1) / 2;

            int x6 = x1 - (x2 - x1) / 2;
            int y6 = y1 + (y2 - y1) / 2;

            int x7 = x3 + (x4 - x3) / 2;
            int y7 = y3 + (y4 - y3) / 2;

            int x8 = x4 + (x2 - x4) / 2;
            int y8 = y2 + (y4 - y2) / 2;

            for (int i = 0; i < 200000; i++)
            {
                point = rand.Next(0, 9);
                try
                {
                    switch (point)
                    {
                        case 1:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x1 + (xcp - x1) * devcof));
                            ycp = Convert.ToInt32((y1 + (ycp - y1) * devcof));
                            break;
                        case 2:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x2 + (xcp - x2) * devcof));
                            ycp = Convert.ToInt32((y2 + (ycp - y2) * devcof));
                            break;
                        case 3:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x3 + (xcp - x3) * devcof));
                            ycp = Convert.ToInt32((y3 + (ycp - y3) * devcof));
                            break;
                        case 4:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x4 + (xcp - x4) * devcof));
                            ycp = Convert.ToInt32((y4 + (ycp - y4) * devcof));
                            break;
                        case 5:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x5 + (xcp - x5) * devcof));
                            ycp = Convert.ToInt32((y5 + (ycp - y5) * devcof));
                            break;
                        case 6:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x6 + (xcp - x6) * devcof));
                            ycp = Convert.ToInt32((y6 + (ycp - y6) * devcof));
                            break;
                        case 7:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x7 + (xcp - x7) * devcof));
                            ycp = Convert.ToInt32((y7 + (ycp - y7) * devcof));
                            break;
                        case 8:
                            f1.bmp.SetPixel(xcp, ycp, color);
                            xcp = Convert.ToInt32((x8 + (xcp - x8) * devcof));
                            ycp = Convert.ToInt32((y8 + (ycp - y8) * devcof));
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    return;
                }

            }
            //picture.Image = bmp;
        }

    }
}
