using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Api.Models
{
    public class Question
    {
        [Key]
        public int QId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? QuestionInWords { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? ImageName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Option1  { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Option2  { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Option3 { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Option4 { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int Answer { get; set; }
    }
}
