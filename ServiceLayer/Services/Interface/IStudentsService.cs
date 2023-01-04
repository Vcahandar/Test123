using DomainLayer.Models;


namespace ServiceLayer.Services.Interface
{
    public interface IStudentsService
    {
        int GetStudentByCounting();

        double GetStudentsTotalAge();

        Students[] GetStudentsEmailName();

        Students[] GetStudentsAddress();

        Students[] GetStudentNamesSource(string studName);

        int GetStudentsByNamesFiltered();
    }
}
