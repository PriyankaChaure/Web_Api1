using System.ComponentModel.DataAnnotations;

namespace Curd_Coventions.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email Id Required!")]
        [EmailAddress(ErrorMessage ="Invalid EmailId!")]
        public string EmailId { get; set; }
        [Required(ErrorMessage ="Password Required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
