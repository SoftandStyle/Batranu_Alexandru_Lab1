using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Batranu_Alexandru_Lab1.Controllers
{
    public class MyController : Controller
    {
        public String Index()
        {
            return "Welcome to our website";


        }

        public String Greed()
        {

            return "Hello user";

        }        
        
        public String displayIntegerAndStringValues(int displayedInt, String displayedString)
        {
            return "These are the parameters: " + displayedInt + " and string" + displayedString;
        }
                        
        
    }
}
