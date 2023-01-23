using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessKing
{
    public class Weightlifting : IExercise
    {
        public void Perform()
        {
            Console.WriteLine("Lifting weights for 10 minutes");
        }
    }
}
