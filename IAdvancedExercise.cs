using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessKing
{
    /// <summary>
    /// Interface Segregation Princple.
    /// </summary>
    public interface IAdvancedExercise : IExercise
    {
        void WarmUp();
        void CoolDown();
    }
}
