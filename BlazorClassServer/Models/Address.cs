using System.Text.Json.Serialization;

namespace BlazorClassServer.Models;

public partial class Address
{
    public Address()
    {
        Contacts = new HashSet<Contact>();
        Students = new HashSet<Student>();
    }
    [JsonIgnore]
    public Guid AddressId { get; set; }
    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string? ZipCode { get; set; }

    [JsonIgnore]
    public virtual ICollection<Contact> Contacts { get; set; }
    [JsonIgnore]
    public virtual ICollection<Student> Students { get; set; }
}