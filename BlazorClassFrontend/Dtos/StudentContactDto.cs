using System.Text.Json.Serialization;

namespace BlazorClass.Dtos;

public class StudentContactDto
{
    [JsonPropertyName("studentId")]
    public string StudentId { get; set; }
    [JsonPropertyName("relationship")]
    public string Relationship { get; set; }
    [JsonPropertyName("contact")]
    public ContactDto Contact { get; set; }

    public class ContactDto
    {
        [JsonPropertyName("lastName")]
        public string LastName { get; set;  }
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("email")]
        public string EmailAddress { get; set; }
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }
        [JsonPropertyName("address")]
        public AddressDto Address { get; set; }
    }

    public class AddressDto
    {
        [JsonPropertyName("street")]
        public string Street { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }
    }
}