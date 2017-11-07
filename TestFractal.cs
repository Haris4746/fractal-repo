using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Runtime.Serialization;

namespace FracMaster
{
 
    //This was a (discontinued) base class to initialise the render of the fractal
    //Additional forumulas were added as per fractal type 
  
    public class TestFractal : GenericFractal 
    {                          
        public TestFractal()
        {
            pars.SetValue("NAME", "Render Test");                     
        }        

        override protected void RenderFunction(object o)
        {
            object[] P = (object[])o; //create fractal object
            RenderResult.RenderComplete clbk = (RenderResult.RenderComplete)P[0];
            RenderResult.RenderStatus status_clbk = (RenderResult.RenderStatus)P[1];

            try
            {
                               //set parameters
                int width = (int)pars.GetValue("WIDTH");
                int heigth = (int)pars.GetValue("HEIGHT");
                //Create new bitmap
                Bitmap bmp = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                //Use graphics from the bitmap
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Random r = new Random();
                    //Create draw box
                    for (int i = 0; i < 10000; i++)
                    {
                        int x = r.Next(0, width);
                        int y = r.Next(0, heigth);
                        int w = r.Next(1, width - x);
                        int h = r.Next(1, heigth - y);
                        int col = r.Next(0, 255);
                        using (SolidBrush br = new SolidBrush(Color.FromArgb(col, col, col)))
                        {
                            g.FillRectangle(br, new Rectangle(x, y, w, h));
                        }
                        status_clbk(((float)i) / 100.0f);
                    }
                }
                //Check if its completed, if yes then wait for further input
                res.IsCompleted = true;
                ((AutoResetEvent)(res.AsyncWaitHandle)).Set();
                clbk(bmp, 0);
            }
            catch
            {
                clbk(null, -1);
            }
        }

       

         
    }
}
