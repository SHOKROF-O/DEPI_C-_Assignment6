using System;
 
public class Employee
{
    private int _id;
    private string _name;
    private SecurityLevel _securityLevel;
    private decimal _salary;
    private HireDate _hireDate;
    private Gender _gender;
 
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
 
    public string Name
    {
        get { return _name; }
        set { _name = value ?? "Unknown"; }
    }
 
    public SecurityLevel SecurityLevel
    {
        get { return _securityLevel; }
        set { _securityLevel = value; }
    }
 
    public decimal Salary
    {
        get { return _salary; }
        set { _salary = value < 0 ? 0 : value; }
    }
 
    public HireDate HireDate
    {
        get { return _hireDate; }
        set { _hireDate = value ?? new HireDate(); }
    }
 
    public Gender Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
 
    // default constructor
    public Employee()
    {
        Name = "Unknown";
        HireDate = new HireDate();
    }
 
    // full constructor
    public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, Gender gender)
    {
        Id = id;
        Name = name;
        SecurityLevel = securityLevel;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
    }
 
    public override string ToString()
    {
        string salaryText = String.Format("{0:C}", Salary);
        return $"ID: {Id}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {salaryText}, Hire Date: {HireDate}, Gender: {Gender}";
    }
}