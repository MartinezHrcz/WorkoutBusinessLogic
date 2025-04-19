namespace WorkoutTrackerBusinessLogic.Classes;

public class Workout
{
    private List<Set> sets;
    public List<Set> Sets
    { get => sets; set => sets = value; }

    private int duration;
    public int Duration { get => duration; set => duration = value; }

    private DateOnly dateOfWorkout;
    public DateOnly DateOfWorkout { get => dateOfWorkout;}

    public Workout(List<Set> sets, int duration, DateOnly dateOfWorkout)
    {
        this.sets = sets;
        this.duration = duration;
        this.dateOfWorkout = dateOfWorkout;
    }

    public override string ToString()
    {
        string output = "";
        output += this.DateOfWorkout.ToString() + "\n";
        output += $"Workout ({this.duration}): \n";
        sets.ForEach(set => output += set.ToString() + "\n");
        
        return output;
    }
}