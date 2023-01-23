using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessKing
{
    public class Running : IExercise
    {
        public void Perform()
        {
            Console.WriteLine("Running for 5 minutes");
        }
    }
}
