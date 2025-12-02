using System.Collections.ObjectModel;
using MongoDB.Bson;
using MongoDB.Driver;
using StudentsManager.Models;

namespace StudentsManager.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    public ObservableCollection<Student> Students { get; } = [];

    public MainWindowViewModel()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var db = client.GetDatabase("university_db");
        var studentsCollection = db.GetCollection<Student>("students");
        var filter = new BsonDocument();
        var students = studentsCollection.Find(filter).ToList();

        Students.Clear();
        foreach (var student in students)
        {
            Students.Add(student);
        }
    }
}