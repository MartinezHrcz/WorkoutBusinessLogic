
using WorkoutTrackerBusinessLogic.Classes;

namespace WorkoutTrackerBusinessLogic;

public class Runner
{ 
    static readonly string MAINMENU =
        """
        CLI Workout Tracker!
        1. Start a new workout
        2. Show all workouts
        3. Delete workout
        4.Exit
        """;
    
    public static void Main(string[] args)
    {
        char input;
        do
        {
            input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    
                    break;
                case '2':
                    
                    break;
                case '3':
                    
                    break;
                case '4':
                    
                    break;
            }
            
        } while (!input.Equals('4'));
    }
    
    
}