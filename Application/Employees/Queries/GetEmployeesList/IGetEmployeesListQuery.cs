using System.Collections.Generic;

namespace CleanArchitecture.Application.Employees.Queries.GetEmployeesList
{
    public interface IGetEmployeesListQuery
    {
        IList<EmployeeModel> Execute();
    }
}