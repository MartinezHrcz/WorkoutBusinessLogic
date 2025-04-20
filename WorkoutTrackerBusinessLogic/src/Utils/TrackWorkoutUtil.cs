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
            switch (menuInput)
            {
                case '1':
                    Excercise setExcercise = ExcerciseUtils.SelectExcersice();
                    if (setExcercise != null)
                    {
                        Console.WriteLine("Can't add excercise!");
                        break;
                    }
                    Set tempSet = new Set()
                    break;
                case '2':
                    Console.WriteLine("Going to menu!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        } while (menuInput != '2');
        
        Console.ReadKey();
    }



   
}