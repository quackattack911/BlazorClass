using BlazorClass.Dtos;

namespace BlazorClass.Service;

public interface IApiService
{
    Task<List<StudentDto>?> GetAllStudents();
    Task<List<StudentContactDto>?> GetAllStudentContacts();
}