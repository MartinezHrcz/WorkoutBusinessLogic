using WorkoutTrackerBusinessLogic.Classes;

namespace WorkoutTrackerBusinessLogic.Utils;

public class WorkoutUtils
{
    
    
    private static List<Workout> workoutsList = new List<Workout>();
    public static List<Workout> WorkoutsList
    {
        get { return workoutsList; }
    }

    private static Workout SelectWorkout()
    {
        Console.Clear();
        Console.WriteLine("Select workout:");
        for (int i = 0; i < workoutsList.Count; i++)
        {
            Console.WriteLine($" {i+1}. {workoutsList[i].Name}, {workoutsList[i].Duration}, {workoutsList[i].DateOfWorkout}");
        }
        char input;
        do
        {
            input = Console.ReadKey().KeyChar;
        } while ((input-1) <  0 || input >= workoutsList.Count );

        input--;
        return workoutsList[input];
    }

    public static bool DeleteWorkout()
    {
        Workout workout = SelectWorkout();
        workoutsList.Remove(workout);
        if (workoutsList.Contains(workout))
        {
            Console.WriteLine("Unable to delete workout! \nPress any key to continue...");
            Console.ReadKey();
            return false;
        }
        return true;
    }

    public static void AddWorkout(string workoutName, List<Set> sets ,DateOnly dateOfWorkout, int duration)
    {
        Workout toBeAdded = new Workout(workoutName, sets, duration ,dateOfWorkout);
        workoutsList.Add(toBeAdded);
    }

    public static void ShowAll()
    {
        Console.Clear();
        Console.WriteLine("SHOW ALL");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}