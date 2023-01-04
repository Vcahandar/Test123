using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class CalculateController
    {
        public float Calculate()
        {
            Console.WriteLine("Reqem daxil edin:");
            float n= float.Parse(Console.ReadLine());

            Console.WriteLine("Oparetion daxil edin");
            string operation = Console.ReadLine();

            Console.WriteLine("Reqem daxil edin:");
            float m=float.Parse(Console.ReadLine());

            ICalculateService calculateService= new CalculateService();
            var result = calculateService.Calculate(n,m, operation);

            Console.WriteLine($"Netice : {result}");

            return result;



        }





    }
}
