using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;
using System.IO;

namespace FracMaster 

    //Extrapolates the fractal to a xml string to allow for online viewing or script builder functions
{
   

    public interface IFractal 
    {                 
        /// <summary>
        /// begin rendering of fractal
        /// </summary>
        /// <param name="RenderComplete"></param>
        /// <param name="StatusUpdate"></param>
        /// <returns></returns>
        IAsyncResult BeginRender(Delegate RenderComplete, Delegate StatusUpdate); //Provide system or render information
        
        /// <summary>
        /// end (or interrupt rendering)
        /// </summary>
        /// <param name="Res"></param>
        void EndRender(IAsyncResult Res);

        IFractalParameters Parameters { get; set;}//find paramaters for each constructor, i.e. reading/writing an xml doc (save file)

        void Configure();

        void WriteToXml(String filename);

        void ReadFromXml(String filename);

        void ReadFromXml(Stream xmlstream);
         

    }
}
