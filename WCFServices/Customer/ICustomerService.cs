using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LoanApplicationWCFService.Models;

namespace LoanApplicationWCFService.WCFServices.Customer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void AddCustomer(CustomerModel customer);

        [OperationContract]
        void UpdateCustomer(CustomerModel customer, Guid id);

        [OperationContract]
        void DeleteCustomer(Guid id);

        [OperationContract]
        List<CustomerModel> GetAllCustomers();

        [OperationContract]
        CustomerModel GetCustomerById(Guid Id);
    }
}
