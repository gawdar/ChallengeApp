using ChallengeApp;

Employee employee1 = new Employee("Adam", "Słodowy", 60);
Employee employee2 = new Employee("Monika", "Zych", 32);
Employee employee3 = new Employee("Mirosław", "Misiek", 40);


employee1.AddScore(10);
employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(3);

employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(3);
employee2.AddScore(2);
employee2.AddScore(9);

employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(4);

List<Employee> employess = new List<Employee>()
{ 
    employee1, employee2, employee3 
};

int maxResult = -1;
Employee employeeWithMaxResult = null;


foreach (var employee in employess)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}



Console.WriteLine("Pracownikiem z najwyższą liczbą ocen jest: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + "lat" + " " + employeeWithMaxResult.Age + " pracownik ten zdobył punktów: " + maxResult );
