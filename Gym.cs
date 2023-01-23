using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessKing
{
    /// <summary>
    /// Single Responsibility Principle
    /// </summary>
    public class Gym
    {
        private object _lock = new object();
        public void StartWorkout(IExercise exercise)
        {
            lock (_lock)
            {
                exercise.Perform();
            }
        }
    }
}
