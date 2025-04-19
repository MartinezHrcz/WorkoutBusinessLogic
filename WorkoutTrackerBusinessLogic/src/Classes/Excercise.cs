namespace WorkoutTrackerBusinessLogic.Classes;

public class Excercise
{
    private ExcersizeType type;
    public string Type { get => type.ToString(); }
    
    private string name;
    public string Name { get => name; set => name = value; }
    
    private string desc;
    public string Description { get => desc; set => desc = value; }

    public Excercise(ExcersizeType excersizeType, string name, string description)
    {
        type = excersizeType;
        this.name = name;
        desc = description;
    }

    public Excercise(string name, string description)
    {
        type = ExcersizeType.NOTSET;
        this.name = name;
        desc = description;
    }
    
    public override string ToString()
    {
        return
            $" Type: {type}, Name of excersize: {name}, Description: {desc}";
    }
}