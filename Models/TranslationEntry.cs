using System.ComponentModel.DataAnnotations;

namespace wordcollector.Models
{
    public class TranslationEntry
    {
        [Required(ErrorMessage = "Japanese is required")]
        public string Japanese { get; set; }
        public string Kanji { get; set; }
        [Required(ErrorMessage = "English is required")]
        public string English { get; set; }
    }
}