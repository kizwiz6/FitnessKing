using FitnessKing;

internal class Program
{
    private static void Main(string[] args)
    {
        Gym gym = new Gym();
        IExercise exercise = new Running();

        Thread thread1 = new Thread(() => gym.StartWorkout(exercise));
        Thread thread2 = new Thread(() => gym.StartWorkout(exercise));
        thread1.Start();
        thread2.Start();
    }
}