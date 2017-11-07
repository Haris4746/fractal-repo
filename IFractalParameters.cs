using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace FracMaster
{
    public interface IFractalParameters :  IEnumerable,  IEnumerator, ICloneable
        //AUTHOR Haris Hussain
       
        //Class that finds and collects all the fractal and gui based parameters to be rendered by the GUI
        //Iteration and cloning is allowed
        //THIS CLASS SETS OUT ALL FUNCIONTS THROUGH AN INTERFACE
        //IT ALSO USES ITERATION AND RECURSIVENESS.
    {
        bool HasValue(String name);
        void AddValue(String name, object value);
        void SetValue(String name, object value);
        object GetValue(String name);
        object GetValue(String name, object defaultValue);
    }
}
