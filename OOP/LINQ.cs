using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class LINQ
    {
        public LINQ() 
        {
            SelectName();
        }

        public void SelectName()
        {
            List<string> list = new List<string>() { "Josef", "Felix", "Berta", "Valentýn" };

            var query = from l in list where (l == "Josef" || l == "Valentýn") select l; //from názevrproměnné in názevkolekce select názevproměnné

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
