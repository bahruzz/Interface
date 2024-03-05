using Practice_Interface_Services.Services;
using Praktika.Models;
using Praktika.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Controllers
{
    public class EmployeeController

    {
        private readonly IEmployeeService employeeService;
        public EmployeeController()
        {
            employeeService=new EmployeeService();

        }

        public void GetAll()
        {
            var employees = employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result=$"{employee.Name} {employee.Surname} {employee.Age} {employee.Email} {employee.Address} {employee.Birthday.ToString("MM/dd/yyyy")}";
                Console.WriteLine(result);
            }
            
        }

        public void GetById()
        {
            int? id = null;
            var response = employeeService.GetByID(employeeService.GetAll(), id);
            if(response.ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Age} {response.Employee.Email} {response.Employee.Address} {response.Employee.Birthday.ToString("MM/dd/yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }


        public void Search()
        {
            string name = "Cavid";
            string surname = "Bashirov";
            var response=employeeService.Search(employeeService.GetAll(),surname,name);
            if(response.ErrorMessage is null)
            {
                var result = $"{response.Employee.Name} {response.Employee.Surname}"; 
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }

        }


    }
}
