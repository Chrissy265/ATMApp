using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.App
{
    class Entry  //Starting point of the program 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AppScreen.Welcome();
                ATMApp atmApp = new ATMApp();
                atmApp.InitializeData();
                atmApp.CheckUserCardNumAndPassword();
                atmApp.Welcome();
            }
        }
    }
}
