using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class EmployeeController
    {
        private readonly EmployeeService _service;

        public EmployeeController()
        {
            _service = new EmployeeService();
        }

        public void GetEmployees()
        {
            DateTime maxTime= new DateTime(1991, 01, 01);
            DateTime minTime = new DateTime(2023, 01, 01);
            var result = _service.GetEmployees(maxTime, minTime);

            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} -- Birthday: {item.Birthday} --Salary: {item.Salary}");
                }

            }

        }



    }
}
