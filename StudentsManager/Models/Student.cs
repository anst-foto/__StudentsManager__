using System.Collections.Generic;
using MongoDB.Bson;

namespace StudentsManager.Models;

public class Student
{
    public ObjectId Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public Dictionary<string, List<uint>> Marks { get; set; }
}