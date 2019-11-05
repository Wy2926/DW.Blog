using System.ComponentModel.DataAnnotations;

namespace DW.Blog.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}