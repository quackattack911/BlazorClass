using System.Text.Json.Serialization;

namespace BlazorClass.Dtos;

public class StudentDto
{
    [JsonPropertyName("schoolCode")]
    public string SchoolCode { get; set; }
    [JsonPropertyName("studentId")]
    public string StudentId { get; set; }
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }
    [JsonPropertyName("address")]
    public string Address { get; set; }
    [JsonPropertyName("city")]
    public string City { get; set; }
    [JsonPropertyName("state")]
    public string State { get; set; }
    [JsonPropertyName("zipCode")]
    public string ZipCode { get; set; }
    [JsonIgnore]
    public bool ShowDetail { get; set; }
}