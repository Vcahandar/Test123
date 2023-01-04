using DomainLayer.Models;
using ServiceLayer.Helpers.Constans;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService:IEmployeeService
    {
        public Employee[] GetEmployees(DateTime maxTime,DateTime minTime)
        {
            Employee[] employees = GetAll();
            Employee[] result= new Employee[employees.Length];
            int count=0;
            

            foreach (var item in employees)
            {
                if (item.Birthday > maxTime && item.Birthday < minTime&&item.Salary>2000)
                {
                    result[count] = item;
                    count++;
                }
            }
           
            return result;
        }



        private Employee[] GetAll()
        {

            Employee emplo1 = new Employee()
            {
                Name = "Ismayil",
                Surname = "Yusifov",
                Birthday = new DateTime(1995, 10, 16),
                Salary = 2300,
            };
            Employee emplo2 = new Employee()
            {
                Name = "Nurlan",
                Surname = "Mecidli",
                Birthday = new DateTime(1996, 01, 01),
                Salary =1900,
            };
            Employee emplo3 = new Employee()
            {
                Name = "Ceyhun",
                Surname = "Memmedov",
                Birthday = new DateTime(1994, 07, 24),
                Salary = 2500,
            };
            Employee emplo4 = new Employee()
            {
                Name = "Abbas",
                Surname = "Bagirov",
                Birthday = new DateTime(2000, 08, 26),
                Salary = 1850,
            }; Employee emplo5 = new Employee()
            {
                Name = "Elcin",
                Surname = "Hesenov",
                Birthday = new DateTime(1994, 07, 22),
                Salary = 2600,
            };

            Employee [] people = { emplo1, emplo2, emplo3, emplo4, emplo5 };

            return people;





        }

    }
}
