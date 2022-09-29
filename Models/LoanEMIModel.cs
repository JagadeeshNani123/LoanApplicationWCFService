﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanApplicationWCFService.Models
{
    public class LoanEMIModel
    {
        public Guid EMIId { get; set; }

        public Guid LoanId { get; set; }

        public decimal EMIAmout { get; set; }

        public string EMIPaymentDate { get; set; }

        public int EMINo { get; set; }

    }
}