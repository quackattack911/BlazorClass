using System.Text.Json.Serialization;

namespace BlazorClassServer.Models;

public partial class StudentContact
{
    public string StudentId { get; set; } = null!;
    [JsonIgnore]
    public Guid ContactId { get; set; }
    public string Relationship { get; set; } = null!;

    public virtual Contact Contact { get; set; } = null!;
    public virtual Student Student { get; set; } = null!;
}