using System.ComponentModel.DataAnnotations;

namespace BlazerUICrud.Models
{
    public class DisplayPersonModel
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "First Name is too long.")]
        [MinLength(1, ErrorMessage = "First Name is too short.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last Name is too long.")]
        [MinLength(1, ErrorMessage = "Last Name is too short.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
    public class DeletePersonModel
    {

        public int Id { get; set; }

    }
}
