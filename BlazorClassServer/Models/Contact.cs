using System.Text.Json.Serialization;

namespace BlazorClassServer.Models;

public partial class Contact
{
    public Contact()
    {
        StudentContacts = new HashSet<StudentContact>();
    }
    [JsonIgnore]
    public Guid ContactId { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Mobile { get; set; } = null!;
    [JsonIgnore]
    public Guid? AddressId { get; set; }

    public virtual Address? Address { get; set; }
    [JsonIgnore]
    public virtual ICollection<StudentContact> StudentContacts { get; set; }
}