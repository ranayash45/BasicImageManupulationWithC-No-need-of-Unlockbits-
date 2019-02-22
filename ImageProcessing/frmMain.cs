using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
     
    public struct PixelData
    {
        public Byte Blue, Green, Red;
    };

    unsafe public partial class frmMain : Form
    {
        
            PixelData*[,] ImagaData;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Bitmap File|*.bmp|Jpeg Images|*.jpeg;*.jpg|Png Images|*.png";

            if(dialog.ShowDialog()==DialogResult.OK)
            {
                frmImage.ImageLocation = dialog.FileName;
            }

        }

        private void laplasianToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PixelData* dstPointer;
            for(int i=0;i<frmImage.Height;i++)
            {
                for(int j=0;j<frmImage.Width;j++)
                {
                    dstPointer = ImagaData[i, j];
                    dstPointer->Green = dstPointer->Red;
                    dstPointer->Blue = dstPointer->Red;

                }
            }

            frmImage.Refresh();
        }

        private void frmImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var bitmap = (Bitmap)frmImage.Image;
            var clone = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);
            Graphics gr = Graphics.FromImage(clone);
            gr.DrawImage(bitmap, new Rectangle(0, 0, clone.Width, clone.Height));
            frmImage.Image = clone;

            var obj = (Bitmap)frmImage.Image;
            BitmapData data;
            data = obj.LockBits(new Rectangle(0, 0, obj.Width, obj.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            ImagaData = new PixelData*[data.Height, data.Width];

            PixelData* dstPointer = (PixelData*)data.Scan0;
            for (int i = 0; i < obj.Height; i++)
            {
                for (int j = 0; j < obj.Width; j++)
                {

                    ImagaData[i, j] = dstPointer;
                    dstPointer = dstPointer + 1;
                }
            }

            obj.UnlockBits(data);

        }

        private void laplasianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            byte[,] pixelValue=new byte[frmImage.Height,frmImage.Width];
            int temp;
            for(int i = 1; i < frmImage.Height - 2; i++)
            {
                for(int j = 1; j < frmImage.Width - 2;j++)
                {
                    temp = ( Math.Abs((ImagaData[i, j]->Red * 4)+(-1*ImagaData[i - 1, j]->Red + -1 * ImagaData[i + 1, j]->Red + -1 * ImagaData[i, j - 1]->Red + -1 * ImagaData[i, j + 1]->Red)));
                    if(temp>255)
                    {
                        temp = 255;
                    }
                    pixelValue[i, j] = Convert.ToByte(temp);
                }
            }
            for (int i = 1; i < frmImage.Height - 2; i++)
            {
                for (int j = 1; j < frmImage.Width - 2; j++)
                {
                    ImagaData[i, j]->Red = pixelValue[i, j];
                    ImagaData[i, j]->Green = pixelValue[i, j];
                    ImagaData[i, j]->Blue = pixelValue[i, j];

                }
            }
            frmImage.Refresh();
        }

        private void imageSmoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[,] rpixelValue = new byte[frmImage.Height, frmImage.Width];
            byte[,] gpixelValue = new byte[frmImage.Height, frmImage.Width];
            byte[,] bpixelValue = new byte[frmImage.Height, frmImage.Width];
            double temp;
            for (int i = 1; i < frmImage.Height - 2; i++)
            {
                for (int j = 1; j < frmImage.Width - 2; j++)
                {
                    temp = (ImagaData[i,j]->Red + ImagaData[i+1, j]->Red + ImagaData[i-1, j]->Red+ ImagaData[i, j+1]->Red + ImagaData[i, j-1]->Red + ImagaData[i+1, j+1]->Red + ImagaData[i+1, j-1]->Red+ ImagaData[i-1, j+1]->Red + ImagaData[i-1, j-1]->Red) / 9;
                    rpixelValue[i, j] = Convert.ToByte(temp);


                    temp = (ImagaData[i, j]->Green + ImagaData[i + 1, j]->Green + ImagaData[i - 1, j]->Green + ImagaData[i, j + 1]->Green + ImagaData[i, j - 1]->Green + ImagaData[i + 1, j + 1]->Green + ImagaData[i + 1, j - 1]->Green + ImagaData[i - 1, j + 1]->Green + ImagaData[i - 1, j - 1]->Green) / 9;
                    gpixelValue[i, j] = Convert.ToByte(temp);

                    temp = (ImagaData[i, j]->Blue + ImagaData[i + 1, j]->Blue + ImagaData[i - 1, j]->Blue + ImagaData[i, j + 1]->Blue + ImagaData[i, j - 1]->Blue + ImagaData[i + 1, j + 1]->Blue + ImagaData[i + 1, j - 1]->Blue + ImagaData[i - 1, j + 1]->Blue + ImagaData[i - 1, j - 1]->Blue) / 9;
                    bpixelValue[i, j] = Convert.ToByte(temp);


                }
            }
            for (int i = 1; i < frmImage.Height - 2; i++)
            {
                for (int j = 1; j < frmImage.Width - 2; j++)
                {
                    ImagaData[i, j]->Red = rpixelValue[i, j];
                    ImagaData[i, j]->Green = gpixelValue[i, j];
                    ImagaData[i, j]->Blue = bpixelValue[i, j];

                }
            }
            frmImage.Refresh();

        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmImage.Height; i++)
            {
                for (int j = 0; j < frmImage.Width; j++)
                {
                    ImagaData[i, j]->Red = Convert.ToByte(255 - ImagaData[i,j]->Red);
                    ImagaData[i, j]->Green = Convert.ToByte(255 - ImagaData[i, j]->Green);
                    ImagaData[i, j]->Blue =  Convert.ToByte(255 - ImagaData[i, j]->Blue);

                }
            }

            frmImage.Refresh();
        }
    }
}
