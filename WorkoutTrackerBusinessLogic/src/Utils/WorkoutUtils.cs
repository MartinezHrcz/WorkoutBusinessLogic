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
        Console.WriteLine("Quit: q");
        Console.WriteLine("Select workout:");
        for (int i = 0; i < workoutsList.Count; i++)
        {
            Console.WriteLine($" {i+1}. {workoutsList[i].Name}, {workoutsList[i].Duration}, {workoutsList[i].DateOfWorkout}");
        } 
        
        int input = 0;
        do
        {
            string inputString = Console.ReadKey().KeyChar.ToString();
            if (inputString.ToLower() == "q")
            {
                return null;
            }
            input =int.TryParse(inputString, out input) ? input : 0;
            Console.WriteLine(input);
        } while ((input-1) <=  0 || input >= workoutsList.Count);
        
        input--;
        return workoutsList[input];
    }
    //Needs to be fixed!!!
    public static void DeleteWorkout()
    {
        var workout = SelectWorkout() ;
        if (workout.Equals(null))
        {
            Console.WriteLine("Unable to delete workout! \n Press any key to continue...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine(workout.Name);
        workoutsList.Remove(workout);
        if (workoutsList.Contains(workout))
        {
            Console.WriteLine("Unable to delete workout! \nPress any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Workout deleted! \nPress any key to continue...");
            Console.ReadKey();
        }
    }

    public static void AddWorkout(string workoutName, List<Set> sets ,DateOnly dateOfWorkout, int duration)
    {
        Workout toBeAdded = new Workout(workoutName, sets, duration ,dateOfWorkout);
        workoutsList.Add(toBeAdded);
    }
    
    public static void AddWorkout(Workout tempWorkout)
    {
        workoutsList.Add(tempWorkout);
    }

    public static void ShowAll()
    {
        Console.Clear();
        workoutsList.ForEach(Console.WriteLine);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }


}