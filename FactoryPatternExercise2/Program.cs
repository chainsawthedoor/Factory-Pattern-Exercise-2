namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database will you use? (List, SQL, Mongo)");
            var databaseType = Console.ReadLine().ToLower();
            var database = DataAccessFactory.GetDataAccessType(databaseType);
            database.LoadData();
            database.SaveData();
        }
    }
}
