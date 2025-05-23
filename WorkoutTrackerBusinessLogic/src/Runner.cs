﻿
using WorkoutTrackerBusinessLogic.Classes;
using WorkoutTrackerBusinessLogic.Procedures;
using WorkoutTrackerBusinessLogic.Utils;

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
        Initialization.Initialize();
        char input;
        do
        {
            Console.Clear();
            Console.WriteLine(MAINMENU);
            Console.WriteLine("Enter a number: ");
            input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    TrackWorkoutUtil.Menu();
                    break;
                case '2':
                    WorkoutUtils.ShowAll();
                    break;
                case '3':
                    WorkoutUtils.DeleteWorkout();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Exiting...!");
                    break;
            }
            
        } while (!input.Equals('4'));
    }
}