namespace CrusadeServices.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int CustomerTypeID { get; set; }
        public string SalesPersonID { get; set; }
        public string CompanyName { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeNo { get; set; }
        public string OfficeNo { get; set; }
        public string MobileNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string B_Salutation { get; set; }
        public string B_FirstName { get; set; }
        public string B_LastName { get; set; }
        public string B_Address1 { get; set; }
        public string B_Address2 { get; set; }
        public string B_PostalCode { get; set; }
        public string B_HomeNo { get; set; }
        public string B_MobileNo { get; set; }
        public string B_OfficeNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string B_ContactNo { get; set; }
        public int IsBlacklisted { get; set; }
        public int EmployeeID { get; set; }
    }

}
