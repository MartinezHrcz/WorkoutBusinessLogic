using WorkoutTrackerBusinessLogic.Classes;

namespace WorkoutTrackerBusinessLogic.Utils;

public static class TrackWorkoutUtil
{
    private static readonly string MENU =
        """
        1.Start workout.
        2.Back to main menu.
        """;
    
    public static void Menu()
    {
        char input;
        do
        {
            Console.Clear();
            Console.WriteLine(MENU);
            input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    Start();
                    break;
                
            }
        } while (!input.Equals('2'));
    }

    private static void Start()
    {
        Console.WriteLine("Give a name of the workout:");
        string workoutName = Console.ReadLine();
        DateTime startTime = DateTime.Now;
        List<Set> sets = new List<Set>();
        char menuInput = ' ' ;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Workout Tracking System!");
            Console.WriteLine($"Start of the workout: {startTime.TimeOfDay.Hours}:{startTime.TimeOfDay.Minutes}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1.Add set \n 2. Stop Workout");
            menuInput = Console.ReadKey().KeyChar;
            switch (menuInput)
            {
                case '1':
                    Excercise setExcercise;
                    try
                    {
                        setExcercise = ExcerciseUtils.SelectExcersice();
                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine("Can't select excercise!");
                        break;
                    }

                    int[] weightAndReps = ExcerciseUtils.WeightAndReps(setExcercise);
                    Set tempSet = new Set(setExcercise, weightAndReps[1], weightAndReps[0]);
                    sets.Add(tempSet);
                    
                    break;
                case '2':
                    Console.Clear();
                    Workout tempWorkout = new Workout(workoutName, sets, DateTime.Now.Subtract(startTime).Seconds ,DateOnly.Parse(DateTime.Now.ToString("MM/dd/yyyy")));
                    WorkoutUtils.AddWorkout(tempWorkout);
                    Console.WriteLine("Going to menu!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        } while (menuInput != '2');
        Console.ReadKey();
    }
}