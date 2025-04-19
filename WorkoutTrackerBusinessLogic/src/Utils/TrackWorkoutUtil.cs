using WorkoutTrackerBusinessLogic.Classes;

namespace WorkoutTrackerBusinessLogic.Utils;

public class TrackWorkoutUtil
{
    static private readonly string MENU =
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
        Console.Clear();
        Console.WriteLine("START METHOD");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }



   
}