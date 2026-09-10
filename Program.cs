using System;
 
class Program
{
    static void Main()
    {
        Employee[] EmpArr = new Employee[3];
 
        //DBA
        EmpArr[0] = new Employee(1, "Ahmed", SecurityLevel.DBA, 15000, new HireDate(1, 3, 2020), Gender.M);
 
        //Guest
        EmpArr[1] = new Employee(2, "Mona", SecurityLevel.Guest, 5000, new HireDate(10, 6, 2022), Gender.F);
 
        //security officer with full permissions
        EmpArr[2] = new Employee(3, "Omar", SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary | SecurityLevel.DBA, 20000, new HireDate(5, 1, 2019), Gender.M);
 
        foreach (Employee emp in EmpArr)
        {
            Console.WriteLine(emp);
        }
    }
}