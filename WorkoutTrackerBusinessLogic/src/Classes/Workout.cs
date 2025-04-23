namespace WorkoutTrackerBusinessLogic.Classes;

public class Workout
{
    private string name;
    public string Name { get => name; set => name = value; }
    
    private List<Set> sets;
    public List<Set> Sets
    { get => sets; set => sets = value; }

    private int duration;
    public int Duration { get => duration; set => duration = value; }

    private DateOnly dateOfWorkout;
    public DateOnly DateOfWorkout { get => dateOfWorkout;}

    public Workout(string name,List<Set> sets, int duration, DateOnly dateOfWorkout)
    {
        this.name = name;
        this.sets = sets;
        this.duration = duration;
        this.dateOfWorkout = dateOfWorkout;
    }

    public override string ToString()
    {
        int hours = duration / 3600;
        int minutes = duration % 3600 / 60;
        string output = "";
        output += DateOfWorkout.ToString() + "\n";
        output += $"{name} ({hours}: {minutes}): \n";
        sets.ForEach(set => output += set.ToString() + "\n");
        
        return output;
    }
}