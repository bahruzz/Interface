

using Praktika.Helpers.Responses;
using Praktika.Models;

namespace Praktika.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        EmployeeResponse GetByID(Employee[] employees,int? id);
        EmployeeResponse Search(Employee[] employees, string name, string surname);
    }
}
