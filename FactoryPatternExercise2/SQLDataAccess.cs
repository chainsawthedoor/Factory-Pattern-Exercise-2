namespace FactoryPatternExercise2;

public class SQLDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("Loading data from SQL...");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving data to SQL...");
    }
}