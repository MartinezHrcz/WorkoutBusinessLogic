using WorkoutTrackerBusinessLogic.Classes;
using WorkoutTrackerBusinessLogic.Utils;

namespace WorkoutTrackerBusinessLogic.Procedures;

public class Initialization
{
    public static void Initialize()
    {
        try
        {
            LoadInDefaultExc();
        }
        catch (Exception e)
        {
            Console.WriteLine("Default excercises could not be loaded. \n Continue anyway? (Y/N):");
            char input;
            do
            {
                input = Console.ReadKey().KeyChar;
            } while (input.Equals('Y') || input.Equals('N'));

            if (input.Equals('N'))
            {
                Environment.Exit(0);
            }
            throw;
        }
        


    }

    private static void LoadInDefaultExc()
    {
        Console.WriteLine("Loading default exc");
        StreamReader sr;
        try
        {
            sr = File.OpenText("../../../src/Files/DefaultExcercises");
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e);
            return;
        }
        
        Excercise loadedExc;
        int lineNumber = 0;
        
        while (!sr.EndOfStream)
        {
            lineNumber++;
            string[] line = sr.ReadLine().Split(';');
            loadedExc = new Excercise(line[0], line[1], line[2]);
            if (loadedExc != null)
            {
                ExcerciseUtils.excercises.Add(loadedExc);
                Console.WriteLine("Loaded excercise: " + loadedExc.Name);
            }

            
        }

        if (lineNumber != ExcerciseUtils.excercises.Count)
        { return; }
    }
}