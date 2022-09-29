using LoanApplicationWCFService.Models;
using LoanApplicationWCFService.SQLDataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LoanApplicationWCFService.WCFServices.LoanEMI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoanEMIService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoanEMIService.svc or LoanEMIService.svc.cs at the Solution Explorer and start debugging.
    public class LoanEMIService : ILoanEMIService
    {
        LoanEMIDataContext ledc = new LoanEMIDataContext();
        public void AddLoanEMI(LoanEMIModel loanEMI)
        {
            ledc.InsertLoanEMI(loanEMI);
        }

        public void UpdateLoanEMI(LoanEMIModel loanEMI, Guid id)
        {
            ledc.UpdateLoanEMIUsingId(loanEMI, id);
        }

        public List<LoanEMIModel> GetAllLoansEMIs()
        {
            return ledc.GetAllLoanEMIs();
        }

        public LoanEMIModel GetLoanEMIById(Guid Id)
        {
            return ledc.GetLoanEMIById(Id);
        }

        public void DeleteLoanEMI(Guid id)
        {
            ledc.DeleteLoanEMI(id);
        }
    }
}
