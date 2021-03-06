using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SharpAddress.Enums;

namespace SharpAddress.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name ="Address Line 2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public States State { get; set; }
        [Display(Name ="Zip Code")]
        public string ZipCode { get; set; }
        //TODO: Which phone is primary phone
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }
        [Display(Name ="Work Phone")]
        public string WorkPhone { get; set; }
        [Display(Name ="Cell Phone")]
        public string CellPhone { get; set; }
        [Display(Name ="Fax Number")]
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string ContentType { get; set; }
        public int CategoryId { get; set; }
    }
}
