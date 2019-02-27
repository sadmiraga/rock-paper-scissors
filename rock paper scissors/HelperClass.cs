using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class HelperClass
    {
        public static int rand { get; set; }

        Random rnd = new Random();

        //METODA KOJA VRACA RANDOM BROJ
        public int GetState()
        {
            
            rand = rnd.Next(0, 3);

            return rand;
        }
    }
}
