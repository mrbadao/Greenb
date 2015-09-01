using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GreenbPlugin
{
    public class FeedBackPrinter
    {
        public static Image InsertProduct(Image inputProduct, int position, int width, int height, Image bgImage)
        {
            using (Graphics g = Graphics.FromImage(bgImage))
            {
                switch (position)
                {
                    case 0:
                        g.DrawImage(inputProduct, 35, 21, width, height);
                        break;
                    case 1:
                        g.DrawImage(inputProduct, 105, 21, width, height);
                        break;
                    case 2:
                        g.DrawImage(inputProduct, 70, 81, width, height);
                        break;
                    default:
                        break;
                }

            }

            return bgImage;
        }

        public static Image DrawProductInfo(Image billImage, string drawStr,FontFamily fontfamily, int fontSize, FontStyle fontStyle, Color drawColor, Point drawPoint)
        {
            using (Font drawFont = new Font(fontfamily, fontSize, fontStyle))
            using (Graphics g = Graphics.FromImage(billImage))
            {
                g.DrawString(drawStr.Trim(), drawFont, new SolidBrush(drawColor), drawPoint);
            }
            return billImage;
        }
    }
}
