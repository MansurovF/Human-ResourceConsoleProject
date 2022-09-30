using ProjectNumber_1;
using System;



namespace ProjectNumber_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IHumanResourceManager HumanService = new HumanService();
            do
            {
                Console.WriteLine("Welcome to the *****Insan Resource Project*****");
                Console.WriteLine("Etmek istediyiniz emeliyatin nomresini daxil edin:");
                Console.WriteLine("\n1- Departameantlerin siyahisini gostermek");
                Console.WriteLine("\n2-Departamenet yaratmaq");
                Console.WriteLine("\n3-Departmanetde deyisiklik etmek");
                Console.WriteLine("\n4-Iscilerin siyahisini gostermek"); ;
                Console.WriteLine("\n5-Departamentdeki iscilerin siyahisini gostermrek");
                Console.WriteLine("\n6-Isci elave etmek");
                Console.WriteLine("\n7-Isci uzerinde deyisiklik etmek");
                Console.WriteLine("\n8-Departamentden isci silinmesi");
                string select = Console.ReadLine();
                int selectNum;
                int.TryParse(select, out selectNum);
                
                while (!int.TryParse(select, out selectNum) || selectNum<1 || selectNum >8 )
                {
                    Console.WriteLine("Duzgun daxil edin");
                    select = Console.ReadLine();
                }
                Console.Clear();
                switch (selectNum)  
                {
                    case 1:
                        
                        GetDepartments(  HumanService);
                        break;
                    case 2:
                        AddDepartments(ref HumanService);
                        break;
                    case 3:
                        EditDepartaments(ref HumanService);
                        break;
                    case 4:
                        ShowAllEmployees(ref HumanService);
                        break;
                    case 5:
                        ShowEmployeesByDepartment(ref HumanService);
                        break;
                    case 6:
                        AddEmployee(ref HumanService);
                        break;
                    case 7:
                        EditEmployee(ref HumanService);
                        break;
                    case 8:
                        RemoveEmployee(ref HumanService);
                        break;
                    
                        
                }

            } while (true);

        }
        static void GetDepartments(  IHumanResourceManager HumanService)
        {
            
        }
        static void AddDepartments(ref IHumanResourceManager HumanService)
        {

        }
        static void EditDepartaments(ref IHumanResourceManager HumanService)
        {

        }
        static void RemoveEmployee(ref IHumanResourceManager HumanService)
        {

        }
        static void EditEmployee(ref IHumanResourceManager HumanService)
        {

        }
        static void AddEmployee (ref IHumanResourceManager HumanService)
        {

        }
        static void Departments (ref IHumanResourceManager HumanService)
        {

        }
        static void ShowAllEmployees(ref IHumanResourceManager HumanService)
        {

        }
        static void ShowEmployeesByDepartment(ref IHumanResourceManager HumanService)
        {

        }
    }
}
