namespace CrusadeServices.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Customer
    {
        public int CustomerID { get; set; }
        public int CustomerTypeID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastUpdateDate { get; set; }=DateTime.Now;
        public bool IsBlacklisted { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? SalesPersonID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? CompanyName { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? Salutation { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? LastName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? HomeNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? OfficeNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? MobileNo { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? Address1 { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? Address2 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? PostalCode { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? B_Salutation { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? B_FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? B_LastName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? B_Address1 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? B_Address2 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? B_PostalCode { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? B_HomeNo { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? B_MobileNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? B_OfficeNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? CreatedBy { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? LastUpdateBy { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? ContactPerson { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? ContactNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? B_ContactNo { get; set; }

    }

}
