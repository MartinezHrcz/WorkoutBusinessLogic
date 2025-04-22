using WorkoutTrackerBusinessLogic.Classes;

namespace WorkoutTrackerBusinessLogic.Utils;

public class ExcerciseUtils
{
    public static List<Excercise> excercises = new List<Excercise>();
    
    public static Excercise MakeNewExcercise()
    {
        Console.WriteLine("Creating new excercise");
        return null;
    }

    public static Excercise SelectExcersice()
    {
        if (excercises.Count == 0)
        {
            Console.WriteLine("No available excercises!");
            return null;
        }

        int i = 0;
        string excerciseList = "";
        excercises.ForEach(exc => excerciseList += $" {exc.Name}, {exc.Type} \n");
        string input;
        do
        {
            Console.Clear();
            Console.WriteLine(excerciseList);
            Console.WriteLine("------To go back type: QUIT---------");
            Console.Write("Enter excercise name: ");
            input = Console.ReadLine().ToLower().Trim();
            Console.WriteLine(input);
            //Console.WriteLine(excercises.Find(x => x.Name.ToLower().Trim() == input));
        } while (!excercises.Select(x => x.Name.Trim().ToLower()).ToList().Contains(input) && !input.Equals("quit"));

        if (input.Equals("quit")) return null;
        return excercises.Find(x => x.Name.Trim().ToLower().Equals(input));
    }

    public static int[] WeightAndReps(Excercise excercise)
    {
        if (excercise == null)
        {
            Console.WriteLine("Null");
            return null;
        }

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
            inputReps = Int32.TryParse(Console.ReadLine().Trim(), out inputWeight) ? inputWeight : 0;
        } while (inputReps <= 0);
        return new int[] { inputWeight, inputReps };
    }
}