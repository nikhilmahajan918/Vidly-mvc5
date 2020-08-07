using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
 
namespace Vidly.Models
{
    public class Customer            
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter The Customer's Name.")]
        [StringLength(255)]       // Name which is nvarchar(max) i.e in c# ,string has null prop. and stores as max characters as user input..so to avoid weuse data annotations
        public string Name { get; set; }      // whenever we change our domain model ,like now we have override over default conventions....then at that time we need to create add a new migratration.

        public bool IsSubscibedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }  //now without required attribute, this membershipid amd membership property have validation error in NewCustomer bcs of this byte datatype...50th video see for more info.

       
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}