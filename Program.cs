using FitnessKing;

internal class Program
{
    private static void Main(string[] args)
    {
        Gym gym = new Gym();
        IExercise exercise = new Running();
        gym.StartWorkout(exercise);
        exercise = new AdvancedRunning();
        gym.StartWorkout(exercise);
        exercise = new Weightlifting();
        gym.StartWorkout(exercise);
        IAdvancedExercise advancedExercise = new AdvancedWeightlifting();
        advancedExercise.WarmUp();
        advancedExercise.Perform();
        advancedExercise.CoolDown();
    }
}