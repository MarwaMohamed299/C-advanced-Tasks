using ConsoleApp1;

Employee e1 = new Employee();
Console.WriteLine(e1);

//////// sorted array////

Console.WriteLine("---------sorted array-------");

Employee[] Employees = new Employee[3] ;
Employee DBA = new Employee();
Employee Guest = new Employee();
Employee security_officer = new Employee();

DBA.Gender = ConsoleApp1.gender.male;
DBA.Salary = 1222;
DBA.Id = 1;
DBA.Securitylevel = ConsoleApp1.securityprivilage.DBA;
DBA.hiringdate = new ConsoleApp1.HiringDate { day = 1, month = 9, year = 1998 };

Console.WriteLine(DBA);
Guest.Gender = ConsoleApp1.gender.male;
Guest.Salary = 1222;
Guest.Id = 2;
Guest.Securitylevel = ConsoleApp1.securityprivilage.guest;
Guest.hiringdate = new ConsoleApp1.HiringDate { day = 1, month = 7, year = 1999 };

Console.WriteLine(Guest);

security_officer.Gender = ConsoleApp1.gender.male;
security_officer.Salary = 1222;
security_officer.Id = 3;
security_officer.Securitylevel = ConsoleApp1.securityprivilage.secretary;
security_officer.hiringdate = new ConsoleApp1.HiringDate { day = 1, month = 5, year = 1995 };
Console.WriteLine(security_officer);

Array.Sort(Employees);
foreach (var item in Employees)
{
    Console.WriteLine(item);
 }
