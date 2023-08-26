namespace CrusadeServices.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateOfJob { get; set; }
        public string WorkOrderNo { get; set; }
        public string InvoiceNo { get; set; }
        public string Description { get; set; }
        public decimal PriceNoGST { get; set; }
        public string ModeOfPayment { get; set; }
        public string Remark { get; set; }
        public string Technicians { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string OtherAddress { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeNo { get; set; }
        public string OfficeNo { get; set; }
        public string MobileNo { get; set; }
        public string Salutation { get; set; }
        public string PostalCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string B_Salutation { get; set; }
        public string B_FirstName { get; set; }
        public string B_LastName { get; set; }
        public string B_Address1 { get; set; }
        public string B_Address2 { get; set; }
        public string B_PostalCode { get; set; }
        public string B_HomeNo { get; set; }
        public string B_MobileNo { get; set; }
        public string B_OfficeNo { get; set; }
        public string SalesPersonID { get; set; }
        public string B_ContactPerson { get; set; }
        public string B_ContactNo { get; set; }
        public int EmployeeID { get; set; }
        public string ContractDesc { get; set; }
        public string TimeOfJob { get; set; }
        public string TermsAndCondition { get; set; }
        public string ReferenceNo { get; set; }
        public string EmailID { get; set; }
        public string UnitNo { get; set; }
        public string B_EmailID { get; set; }
        public string B_UnitNo { get; set; }
        public bool IsQuotation { get; set; }
        public string PrizeSpecial { get; set; }
        public string TranStatus { get; set; }
        public string UnitNo2 { get; set; }
        public string B_UnitNo2 { get; set; }
        public string OperationRemarks { get; set; }
        public string OperationStatus { get; set; }
        public string JobTitle { get; set; }
        public string DescRug { get; set; }
        public string DescCarpet { get; set; }
        public string DescMattress { get; set; }
        public string DescUpholstery { get; set; }
        public string DescGeneral { get; set; }
        public string DescOthers { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public DateTime DateOfQuotation { get; set; }
        public int Discount { get; set; }
        public string JobType { get; set; }
        public string TimeArrived { get; set; }
        public string TimeCompletion { get; set; }
        public string SpecialInstructions { get; set; }
        public int CustomerTypeID { get; set; }
        public string CompanyName { get; set; }
        public int IsBlacklisted { get; set; }
    }

}
