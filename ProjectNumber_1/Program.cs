using ProjectNumber_1;
using System;



namespace ProjectNumber_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // commit test
            // commit test 2
            IHumanResourceManager HumanService = new HumanService();
            do
            {
               // Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome to the *****Insan Resource Project*****");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Etmek istediyiniz emeliyatin nomresini daxil edin:");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
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

                while (!int.TryParse(select, out selectNum) || selectNum < 1 || selectNum > 8)
                {
                    Console.WriteLine("Duzgun daxil edin");
                    select = Console.ReadLine();
                }
                Console.Clear();
                switch (selectNum)
                {
                    case 1:

                        GetDepartments(HumanService);
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
        static void GetDepartments(IHumanResourceManager HumanService)
        {
            if (HumanService.Departments.Length > 0)
            {


                foreach (Department item in HumanService.Departments)
                {
                    Console.WriteLine($"Name={item.Name} SalaryLimit={item.SalaryLimit} WorkerLimit={item.WorkerLimit}Employees.Length={item.Employees.Length}");

                }
                HumanService.GetDepartments();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Department yoxdur elave edin");
                return;
            }
            HumanService.GetDepartments();

        }
        static void AddDepartments(ref IHumanResourceManager HumanService)
        {
            Console.WriteLine("Adi daxil edin");
            string Name = Console.ReadLine();
            while (Name.Length < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Duzgun adi daxil edin,minimun 2 herfden ibaret olmalidir");
                Name = Console.ReadLine();
                continue;
                foreach (Department item in HumanService.Departments)
                {
                    if (Name == item.Name)
                    {
                        Console.WriteLine("Eyni adda 2 department yaradila bilmez");
                        Name = Console.ReadLine();

                        break;
                    }
                }
                if (true)
                {
                    break;
                }


            }
            Console.WriteLine("Departmentin iscilerinin max sayini daxil edin");
            string workerlimitStr = Console.ReadLine();
            int workerlimit;
            while (!int.TryParse(workerlimitStr, out workerlimit) || workerlimit < 1)
            {
                Console.WriteLine("Duzgun limit deyerini daxil edin, minimum isci limiti 1-dir");
                workerlimitStr = Console.ReadLine();
            }
            Console.WriteLine("Departmentin iscilerinin maaslarinin limit deyerini daxil edin");
            string salarylimitStr = Console.ReadLine();
            double salarylimit;
            while (!double.TryParse(salarylimitStr, out salarylimit) || salarylimit < workerlimit * 250)
            {
                Console.WriteLine($"Duzgun deyer daxil edin(Reqemlerden ibaret olmalidir) ve minimum iscilerin maasi {250 * workerlimit}-den asagi olmamalidir!!!");
                salarylimitStr = Console.ReadLine();
            }
            //string Limit = Console.ReadLine();
            HumanService.AddDepartment(Name,workerlimit,salarylimit);
            


        }
        static void EditDepartaments(ref IHumanResourceManager HumanService)
        {
            if (HumanService.Departments.Length <= 0)
            {
                Console.WriteLine("Edit edile bilecek department yoxdur. Evvelce department elave edin");
                return;
            }
            Console.WriteLine("Departamentlerin siyahilari");
            Console.WriteLine("*******************");
            foreach (Department item in HumanService.Departments)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("****************");
            }
            Console.WriteLine("Deyismek istediyiniz departamentin adini qeyd edin");

            string currentName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(currentName))
            {
                Console.WriteLine("Dogru qeyd edin");
                currentName = Console.ReadLine();
            }
            bool find = false;
            string newName = string.Empty;
            foreach (Department item in HumanService.Departments)
            {
                if (item.Name.ToLower() == currentName.ToLower())
                {
                    Console.WriteLine("Departmentin yeni adini daxil edin");
                    newName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(newName) || newName.Length < 2)
                    {
                        Console.WriteLine("Duzgun yazin ");
                        newName = Console.ReadLine();
                    }
                    find = true;
                    break;
                }
               
            }
            if (find == true)
            {
                HumanService.EditDepartments(currentName, newName);
            }
            else
            {
                Console.WriteLine("Bu adda department tapilmadi");
            }
           

        }
        static void RemoveEmployee(ref IHumanResourceManager HumanService)
        {
            Console.WriteLine(" Silmek istediyiniz  iscinin departamentinin adini qeyd edin");
            foreach (Department item in HumanService.Departments)
            {
                Console.WriteLine($"{item}");
            }
                string DepartamentName = Console.ReadLine();
                //string employeeName = Console.ReadLine();
                while (true)
                {
                    foreach (Department departamantName in HumanService.Departments)
                    {
                        if (departamantName.Name.ToLower() == DepartamentName.ToLower())
                        {
                            Console.WriteLine("Iscinin nomresini daxil edin");
                            string employeeName = Console.ReadLine();

                            while (true)
                            {
                                bool check = false;
                                foreach (Employee empName in departamantName.Employees)
                                {
                                    if (empName.No.ToLower() == employeeName.ToLower())
                                    {
                                        HumanService.RemoveEmployee(employeeName, DepartamentName);
                                        check = true;
                                        break;
                                    }
                                }
                                if (check == true)
                                {
                                    return;
                                }
                            }

                        }
                    }

                }

            



        }
        static void EditEmployee(ref IHumanResourceManager HumanService)
        {
            int countworker = 0;
            foreach(Department department in HumanService.Departments)
            {
                foreach (Employee employee in department.Employees)
                {
                    if (employee!=null )
                    {
                        countworker++;
                    }
                }
            }
            if (countworker==0)
            {
                Console.WriteLine("Isci yoxdur ,emeliyat yerine yetirmek isteyirsinizse en azi 1 isci deyer olmalidir");
                return; 
            }
            Console.WriteLine("Deyisiklik etmek istediyiniz iscinin nomresini daxil edin");
            string workerNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(workerNo))
            {
                Console.WriteLine("Duzgun daxil et");
                workerNo = Console.ReadLine();
            }
            Console.WriteLine("Deyisiklik etmek istediyiniz iscinin nomresini daxil edin");
            string fullname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fullname))
            {
                Console.WriteLine("Duzgun daxil et");
                fullname = Console.ReadLine();
            }

            string yeniSalary = null;
            double yeniSalaryNum = 0;
            string newPositoon = null;
            bool check = true;
            foreach (Department department in HumanService.Departments)
            {
                foreach (Employee employee in department.Employees)
                {
                    if (employee!=null)
                    {
                        if (employee.No.ToUpper()== workerNo.ToUpper() )
                        {
                            if (employee.Fullname.ToUpper()==fullname.ToUpper())
                            {
                                
                                Console.WriteLine("\n Maasa duzelis etmek:");
                                yeniSalary = Console.ReadLine();

                                Console.WriteLine("\n Vezifesinde duzelis etmek");
                                newPositoon = Console.ReadLine();

                                HumanService.EditEmployee(workerNo, newPositoon, yeniSalaryNum);
                                return;

                                

                            }
                        }
                    }
                }

            }





        }
        static void AddEmployee(ref IHumanResourceManager HumanService)
        {
            Console.WriteLine("Daxil etmek istediyiniz iscinin ad ve soyadini daxil edin");
            
            string fullName = Console.ReadLine();
            string[] full = fullName.Split(' ');
            while (string.IsNullOrWhiteSpace(fullName) || fullName.Length < 2)
            {
                Console.WriteLine("Duzgun isci adi daxil edin:");
                fullName = Console.ReadLine();
            }
            Console.WriteLine("Iscinin vezifesinin daxil edin:");

            string posotionName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(posotionName) || posotionName.Length < 2)
            {
                Console.WriteLine("PositionName duzgun daxil edin please");
                posotionName = Console.ReadLine();
            }
            Console.WriteLine(" Elave etmek istediyiniz iscinin maasinin daxil edin:");

            string Salary = Console.ReadLine();
            double checkSalary = 0;
            while (!double.TryParse(Salary, out checkSalary) || checkSalary < 250)
            {
                Console.WriteLine("Duzgun maasi daxil edin");
                Salary = Console.ReadLine();
            }
            Console.WriteLine("Iscini elave etmek istediyiniz departamente daxil edin");
            string departmentName = Console.ReadLine();
            //while (string.IsNullOrWhiteSpace(departmentName))
            //{
            //    Console.WriteLine("Departament yoxdur, ilk evvel departament yaradin");
            //    departmentName = Console.ReadLine();
            //}
            while (true)
            {
                bool check = false;
                if (departmentName.Length < 2)
                {
                    Console.WriteLine("Duzgun department adi daxil edin");
                    departmentName = Console.ReadLine();
                    continue;
                }
                foreach (Department item in HumanService.Departments)
                {
                    if (item.Name.ToLower() == departmentName.ToLower())
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bele bir department movcud deyil, yeniden elave edin");
                    departmentName = Console.ReadLine();
                }

            }
            HumanService.AddEmployee(fullName, posotionName, checkSalary, departmentName);

        }

        static void ShowAllEmployees(ref IHumanResourceManager HumanService)
        {
            foreach (Department item1 in HumanService.Departments)
            {
                foreach (Employee item2 in item1.Employees)
                {
                    Console.WriteLine($"{item2.No} {item2.Fullname} {item2.DepartmentName} {item2.Salary}");
                }
                
            }

        }
        static void ShowEmployeesByDepartment(ref IHumanResourceManager HumanService)
        {
            Console.WriteLine("Department adini daxil edin");
            string department = Console.ReadLine();
            while (department.Length <2 )
            {
                Console.WriteLine("Minimum 2 herfden ibaret olmalidir");
                department = Console.ReadLine();
            }
            foreach (Department item1 in HumanService.Departments)
            {
                if (item1.Name.ToUpper() == department.ToUpper())
                {


                    foreach (Employee item2 in item1.Employees)
                    {
                        Console.WriteLine($"{item2.No} {item2.Fullname} {item2.DepartmentName} {item2.Salary}");
                    }
                    break;
                }

            }

        }
    }
}
