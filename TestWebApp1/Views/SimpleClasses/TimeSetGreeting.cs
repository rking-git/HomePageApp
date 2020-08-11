using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TestWebApp1.Views.Simple_Classes
{
    public class TimeSetGreeting
    {
        public static string TimeSetWrite()
        {
            string timeRightNow = DateTime.Now.ToString("h:mm:ss tt");
            return timeRightNow;
        }
    }
}



/*             Console.Write("Current Date and Time is : ");
            
*/