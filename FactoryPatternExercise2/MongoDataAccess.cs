namespace FactoryPatternExercise2;

public class MongoDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("Loading data from MongoDB...");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving data to MongoDB...");
    }
}