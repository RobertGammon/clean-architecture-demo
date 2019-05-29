using System.Collections.Generic;

namespace CleanArchitecture.Application.Customers.Queries.GetCustomerList
{
    public interface IGetCustomersListQuery
    {
        IList<CustomerModel> Execute();
    }
}