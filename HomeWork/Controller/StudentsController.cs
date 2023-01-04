
using ServiceLayer.Services;


namespace HomeWork.Controller
{
    public class StudentsController
    {
        private readonly StudentsService _service;

        public StudentsController()
        {
            _service= new StudentsService();
        }

        public void GetStudentByCounting()
        {
            Console.WriteLine(_service.GetStudentByCounting());
        }

        public void GetStudentsTotalAge()
        {
            Console.WriteLine(_service.GetStudentsTotalAge());
        }


        public void GetStudentsEmailName()
        {
            var result=_service.GetStudentsEmailName();
            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Id}-{item.Name} {item.Surname}--{item.Email}");
                }

            }
        }

        public void GetStudentsAddress()
        {
            var result = _service.GetStudentsAddress();
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Address}");
                }

            }

        }
             public void GetStudentsByNamesFiltered()
             {

                Console.WriteLine(_service.GetStudentsByNamesFiltered());
             }
 




        public void GetStudentNamesSource()
        {
            Console.WriteLine("Ad daxil edin :");
            string studName =Console.ReadLine();
            var result = _service.GetStudentNamesSource(studName);

            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Id}--{item.Name} {item.Surname}   Education: {item.Education}");

                }
            }


        }


    }
}
