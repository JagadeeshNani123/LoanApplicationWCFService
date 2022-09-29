using LoanApplicationWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LoanApplicationWCFService.WCFServices.LoanEMI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoanEMIService" in both code and config file together.
    [ServiceContract]
    public interface ILoanEMIService
    {
        [OperationContract]
        void AddLoanEMI(LoanEMIModel loanEMI);

        [OperationContract]
        void UpdateLoanEMI(LoanEMIModel loanEMI, Guid id);

        [OperationContract]
        void DeleteLoanEMI(Guid id);

        [OperationContract]
        List<LoanEMIModel> GetAllLoansEMIs();

        [OperationContract]
        LoanEMIModel GetLoanEMIById(Guid Id);
    }
}
