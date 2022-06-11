public class RealTask
{
    private string name;
    private string description;
    private DateTime startTime, endTime;

    RealTask(string name)
    {
        name = name;
        startTime = DateTime.now;

    }
}
