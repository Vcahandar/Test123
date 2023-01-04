using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {

        public float Calculate(float n, float m, string operation)
        {
            float result;
            switch (operation)
            {
                case "+":
                    result = n+m; 
                    return result;
                    case "-":
                    result = n-m;
                    return result;
                    case "*":
                    result = n*m;
                    return result;
                    case "/":
                    result = n/m;
                    return result;  
            }
            return default;



        }
    }
}







