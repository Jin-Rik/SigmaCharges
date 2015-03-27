﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ChargesModels
{
    public class ChargesEdit
    {
        public int ChargesID { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resx.Charges),
    ErrorMessageResourceName = "Required")]
        [LocalizedDisplayName("PaymentType", NameResourceType = typeof(Resx.Charges))]
        public string PaymentType { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resx.Charges),
    ErrorMessageResourceName = "Required")]
        [LocalizedDisplayName("AmountOfPayment", NameResourceType = typeof(Resx.Charges))]
        public string AmountOfPayment { get; set; }

        [LocalizedDisplayName("Date", NameResourceType = typeof(Resx.Charges))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [LocalizedDisplayName("CharactOfPayment", NameResourceType = typeof(Resx.Charges))]
        public string CharactOfPayment { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resx.Charges),
    ErrorMessageResourceName = "Required")]
        [LocalizedDisplayName("LastName", NameResourceType = typeof(Resx.Charges))]
        public string LastName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resx.Charges),
    ErrorMessageResourceName = "Required")]
        [LocalizedDisplayName("FirstName", NameResourceType = typeof(Resx.Charges))]
        public string FirstName { get; set; }

        [LocalizedDisplayName("MiddleName", NameResourceType = typeof(Resx.Charges))]
        public string MiddleName { get; set; }
        public string AddedUser { get; set; }

        public ChargesEdit(int ChargesID, string PaymentType, string AmountOfPayment, DateTime Date, string CharactOfPayment, string LastName, string FirstName,
                            string MiddleName, string AddedUser)
        {
            this.ChargesID = ChargesID;
            this.PaymentType = PaymentType;
            this.AmountOfPayment = AmountOfPayment;
            this.Date = Date;
            this.CharactOfPayment = CharactOfPayment;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.AddedUser = AddedUser;
        }

        public ChargesEdit()
        {
            this.ChargesID = ChargesID;
            this.PaymentType = PaymentType;
            this.AmountOfPayment = AmountOfPayment;
            this.Date = Date;
            this.CharactOfPayment = CharactOfPayment;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.AddedUser = AddedUser;
        }
    }
}