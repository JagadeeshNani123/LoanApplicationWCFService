﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanApplicationWCFService.Models
{
    public class CustomerModel
    {
        public Guid Id { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string EmailAddress { get; set; }


        public string Password { get; set; }


        public string Occupation { get; set; }


        public decimal Income { get; set; }


        public string DateOfBirth { get; set; }


        public string AddressProof { get; set; }


        public string AddressProofNumber { get; set; }


        public string PanCardNumber { get; set; }


        public string PhoneNumber { get; set; }

    }
}