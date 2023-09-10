using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;



class Employee :IComparable
{



    private int id;
    private int salary;
    private gender gender;
    private securityprivilage securitylevel;
    private HiringDate Hiringdate;

    public Employee()
    {
        id = 15;
        securitylevel = securityprivilage.guest;
        gender = gender.male;
        salary = 2244;
        Hiringdate = new HiringDate();
    }

    public Employee(int _id, securityprivilage _securitylevel, int _salary, HiringDate _Hiringdate, gender _gender)
    {
        id = _id;
        securitylevel = _securitylevel;
        salary = _salary;
        Hiringdate = _Hiringdate;
        gender = _gender;
    }

    public int Id
    {
        set { id = value; }
        get { return id; }
    }

    public int Salary
    {
        set { salary = value; }
        get { return salary; }
    }

    public gender Gender
    {
        set { gender = value; }
        get { return gender; }
    }

    public HiringDate hiringdate
    {
        set { Hiringdate = value; }
        get { return Hiringdate; }
    }

    public securityprivilage Securitylevel
    {
        set { securitylevel = value; }
        get { return securitylevel; }
    }

    public override string ToString()
    {
        return $"ID: {Id}, Security Level: {Securitylevel}, Salary: {Salary}, " +
            $"Date Hired: {Hiringdate.day}/{Hiringdate.month}/{Hiringdate.year}, Gender: {Gender}";
    }
    public int CompareTo(object? obj)
    {
        Employee right = obj as Employee;
       
        return this.Hiringdate.CompareTo(right.Hiringdate);

    }
}





