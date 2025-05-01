using System.ComponentModel.DataAnnotations;

namespace DiaryAPP.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="* Please enter a title! ")]
        //[StringLength(100, MinimumLength = 3, ErrorMessage = "The content should be maximum 100 characters")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage ="* Please enter a content! ")]
        [StringLength(100, MinimumLength =3,ErrorMessage = "The content should be maximum 100 characters")]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage ="* Please select a date! ")]
    
        public DateTime Created { get; set; }

    }
}
