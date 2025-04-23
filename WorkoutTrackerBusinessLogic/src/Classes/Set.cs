namespace WorkoutTrackerBusinessLogic.Classes;

public class Set
{
    private Excercise excercise;
    public Excercise _Excercise { get => excercise;  }
    private int reps;
    public int Reps { get => reps; set => reps = value; }
    private double weight;
    public double Weight { get => weight; set => weight = value; }

    public Set(Excercise excercise, int reps, double weight)
    {
        this.excercise = excercise;
        this.reps = reps;
        this.weight = weight;
    }

    public override string ToString()
    {
        return $"Excersize: {_Excercise.Name} Reps: {Reps}, Weight: {Weight}";
    }
}