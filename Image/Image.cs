using static System.Math;
using System.Drawing;
using static PaulQpro.Lib.Image.ImageType;

namespace PaulQpro.Lib.Image
{
    public static class Image
    {
        public static void FilterAndSave(string path, Bitmap img, ImageType type)
        {
            Bitmap newImg = new Bitmap(img);
            for (int y = 0; y < img.Height; y++) for (int x = 0; x < img.Width; x++)
                {
                    Color cl = img.GetPixel(x, y);
                    int r = cl.R; int g = cl.G; int b = cl.B;
                    int gr = (int)(0.3 * r + 0.6 * g + 0.1 * b);
                    int nR = 0;
                    int nG = 0;
                    int nB = 0;
                    switch (type)
                    {
                        case g1:
                            nR = (int)(Round(gr / 255.0) * 255); nG = nR; nB = nG;
                            break;
                        case g2:
                            nR = (int)(Round((gr - 31) / 63.0) * 85); nG = nR; nB = nG;
                            break;
                        case g4:
                            nR = (int)(Round((gr - 15) / 32.0) * (255 / 7.0)); nG = nR; nB = nG;
                            break;
                        case g8:
                            nR = gr; nG = nR; nB = nG;
                            break;
                        case c3:
                            nR = (int)(Round(r / 255.0) * 255);
                            nG = (int)(Round(g / 255.0) * 255);
                            nB = (int)(Round(b / 255.0) * 255);
                            break;
                        case c6:
                            nR = (int)(Round((r - 31) / 63.0) * 85);
                            nG = (int)(Round((g - 31) / 63.0) * 85);
                            nB = (int)(Round((b - 31) / 63.0) * 85);
                            break;
                        case c12:
                            nR = (int)(Round((r - 15) / 32.0) * (255 / 7.0));
                            nG = (int)(Round((g - 15) / 32.0) * (255 / 7.0));
                            nB = (int)(Round((b - 15) / 32.0) * (255 / 7.0));
                            break;
                        case c24:
                            nR = r;
                            nG = g;
                            nB = b;
                            break;
                    }
                    if (nR < 0) nR = 0; if (nR > 255) nR = 255;
                    if (nG < 0) nG = 0; if (nG > 255) nG = 255;
                    if (nB < 0) nB = 0; if (nB > 255) nB = 255;
                    newImg.SetPixel(x, y, Color.FromArgb(nR,nG,nB));
                }
            newImg.Save(path);
        }
    }
}