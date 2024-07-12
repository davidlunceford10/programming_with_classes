abstract class Employee
{
    private string _name;
    private double _hoursWorked;
    private double _hourlyWage;

    public Employee(string name, double hoursWorked, double hourlyWage)
    {
        _name = name;
        _hoursWorked = hoursWorked;
        _hourlyWage = hourlyWage;
    }

    public virtual double GetPay()
    {
        return _hoursWorked * _hourlyWage;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract double InsuranceCost();

    public override string ToString()
    {
        return $"Name: {_name} Hours Worked: {_hoursWorked} Wage: {_hourlyWage} ";
    }

    //polymorphism activity

}