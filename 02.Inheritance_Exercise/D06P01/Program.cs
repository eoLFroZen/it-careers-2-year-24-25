using D06P01;

FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("Id", "Name", "Address", "Position", "Department");

ContractEmployee contractEmployee = new ContractEmployee("ContractId", "ContractName", "ContractAddress", "ContractPosition", "ContractDepartment");

fullTimeEmployee.Show();
Console.WriteLine(fullTimeEmployee.Department);
//Console.WriteLine(fullTimeEmployee.GetDepartment());
Console.WriteLine(fullTimeEmployee.CalculateSalary(20));

Console.WriteLine();

contractEmployee.Show();
Console.WriteLine(contractEmployee.Department);
//Console.WriteLine(contractEmployee.GetDepartment());
Console.WriteLine(contractEmployee.CalculateSalary(20));