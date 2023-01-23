using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessKing
{
    /// <summary>
    /// Liskov Substitution Principle
    /// </summary>
    public class AdvancedRunning : IExercise
    {
        public void Perform()
        {
            Console.WriteLine("Running for 10 minutes at a high intensity");
        }
    }
}
