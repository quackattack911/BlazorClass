using System.Text.Json;
using BlazorClass.Dtos;

namespace BlazorClass.Service;

public class ApiService : IApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _client;
    
    public ApiService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _client = _httpClientFactory.CreateClient();
        _client.BaseAddress = new Uri("https://webapp-220426160339.azurewebsites.net/");
    }

    public async Task<List<StudentDto>?> GetAllStudents()
    {
        string getStudentsPath = "api/Data/GetStudents";
        var response = await _client.GetAsync(getStudentsPath);
        var responseString = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<StudentDto>>(responseString);
    }

    public async Task<List<StudentContactDto>?> GetAllStudentContacts()
    {
        string getStudentContactsPath = $"api/Data/GetStudentContacts";
        var response = await _client.GetAsync(getStudentContactsPath);
        var responseString = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<StudentContactDto>>(responseString);
    }
}