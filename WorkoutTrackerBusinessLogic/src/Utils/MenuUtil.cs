namespace WorkoutTrackerBusinessLogic.Utils;

public class MenuUtil
{
    public static void DisplayMenu(List<string> menuItems)
    {
        Console.Clear();
        Console.WriteLine("________________________");
        menuItems.ForEach(Console.WriteLine);
        Console.WriteLine("________________________");
    }
}