using WorkoutTrackerBusinessLogic.Classes;

namespace WorkoutTrackerBusinessLogic.Utils;

public class ExcerciseUtils
{
    public static List<Excercise> excercises;
    
    public static Excercise MakeNewExcercise()
    {
        Console.WriteLine("Creating new excercise");
        return null;
    }

    public static Excercise SelectExcersice()
    {
        if (excercises.Count == 0)
        {
            Console.WriteLine("No excercises!");
            return null;
        }

        int i = 0;
        string excerciseList = "";
        excercises.ForEach(exc => excerciseList += $" {exc.Name}, {exc.Type}");
        string input;
        do
        {
            Console.Clear();
            Console.WriteLine(excerciseList);
            Console.WriteLine("------To go back type: QUIT---------");
            Console.Write("Enter excercise name: ");
            input = Console.ReadLine().ToLower().Trim();
        } while (!excercises.Select(x => x.Name.ToLower()).Contains(input) || input.Equals("quit"));

        if (input.Equals("quit")) return null;
        return excercises.Find(x => x.Name == input);
    }

    public static int[] WeightAndReps(Excercise excercise)
    {
        int inputWeight =0;
        do
        {
            Console.Clear();
            Console.WriteLine($"{excercise.Name} Weight:");
            inputWeight = Int32.TryParse(Console.ReadLine().Trim(), out inputWeight) ? inputWeight : 0;
        } while (inputWeight <= 0);
        int inputReps = 0;
        do
        {
            Console.Clear();
            Console.WriteLine($"{excercise.Name} Reps:");
            inputWeight = Int32.TryParse(Console.ReadLine().Trim(), out inputWeight) ? inputWeight : 0;
        } while (inputReps <= 0);
        return new int[] { inputWeight, inputReps };
    }
}