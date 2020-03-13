using System;
using System.Collections.Generic;
using System.Text;

namespace Rockpaperscissors.Libary
{
    //Default access modifier is internal
    //They have to have the same 

    public interface IInputOut
    {
        void Output(string s);
        void Input();
    }
}
