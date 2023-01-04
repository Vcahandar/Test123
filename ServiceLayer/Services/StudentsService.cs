using DomainLayer.Models;
using ServiceLayer.Helpers.Constans;
using ServiceLayer.Services.Interface;


namespace ServiceLayer.Services
{
    public class StudentsService : IStudentsService
    {
        public int GetStudentByCounting()
        {
            var people = GetAll();

            int count = 0;
            foreach (var item in people)
            {
                count++;
            }
            return count;
        }

        public double GetStudentsTotalAge()
        {
            Students[] students= GetAll();
            
            double count = 0;
            foreach (Students item in students)
            {
                count += item.Age;
                
            }
            
            return count/ students.Length;
        }

        public Students[] GetStudentsEmailName()
        {
            Students[] students = GetAll();
            Students[] result = new Students[students.Length];

            int count = 0;
            bool check = false;
            foreach (var item in students)

            {
                if (item.Email.StartsWith("c"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine(Error.ErrorNotFound);
            }
            return result;



        }
  
        public Students[] GetStudentsAddress()
        {
            Students[] students = GetAll();
            Students[] result = new Students[students.Length];
            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (item.Address.Contains("Ehmedli"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine(Error.ErrorAddress);
            }
            return result;
        }

        public Students[] GetStudentNamesSource(string studName) 
        {
            Students[] students = GetAll();
            Students[] result = new Students[students.Length];


            int count = 0;
            bool contains=false;
            foreach (var item in students)
            {
                if (item.Name.ToLower() == studName.ToLower() || item.Surname.ToLower() == studName.ToLower())
                {
                    result[count]=item; 
                    count++;
                    contains = true;

                }
               
            }

            if (!contains)
            {
                Console.WriteLine(Error.ErrorName);
            }

            return result;






        }

        public int GetStudentsByNamesFiltered()
        {
            var students = GetAll();
            int count = 0;
            foreach (var item in students)
            {
                if (item.Name == "Cahandar")
                {
                    count++;

                }
            }
            return count;
        }




        private Students[] GetAll()
        { 
        
        
                Students stu1 = new Students()
                {
                    Id = 1,
                    Name = "Cahandar",
                    Surname = "Velibeyli",
                    Email = "cahandar@gmail.az",
                    Age = 26,
                    Education = "Secondary education",
                    Address = "Ehmedli"
                };

                Students stu2 = new Students()
                {
                    Id = 2,
                    Name = "Ismayil",
                    Surname = "Yusifov",
                    Email = "yusifov@gmail.az",
                    Age = 22,
                    Education = "Secondary education",
                    Address = "Xezer"
                };

                Students stu3 = new Students()
                {
                    Id = 3,
                    Name = "Ceyhun",
                    Surname = "Memmedov",
                    Email = "ceyhun@gmail.az",
                    Age = 28,
                    Education = "Secondary education",
                    Address = "Merdekan"
                };

                Students stu4 = new Students()
                {
                    Id = 4,
                    Name = "Nurlan",
                    Surname = "Mecidli",
                    Email = "nurlan@gmail.az",
                    Age = 20,
                    Education = "Secondary education",
                    Address = "Xezer"
                };

                Students[] people = { stu1, stu2, stu3, stu4 };

                return people;


        }


    }
    
    
}  

