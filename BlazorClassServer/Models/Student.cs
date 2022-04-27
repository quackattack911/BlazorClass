using System.Text.Json.Serialization;

namespace BlazorClassServer.Models;

public partial class Student
{
    public Student()
    {
        StudentContacts = new HashSet<StudentContact>();
    }

    public string StudentId { get; set; } = null!;
    public string SchoolCode { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    [JsonIgnore]
    public Guid? AddressId { get; set; }

    public virtual Address? Address { get; set; }
    [JsonIgnore]
    public virtual ICollection<StudentContact> StudentContacts { get; set; }
}