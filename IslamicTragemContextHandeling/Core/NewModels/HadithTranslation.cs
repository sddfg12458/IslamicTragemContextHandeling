using System.ComponentModel.DataAnnotations;

namespace IslamicTragemContextHandeling.Core.NewModels
{
    public class HadithTranslation
    {

        [Key]
        public int Id { get; set; }

        [OldName("LanguageId")]
        public int LanguageId { get; set; }

        [OldName("SelId")]
        public int HadithId { get; set; }
        public Hadith? Hadith { get; set; }

        [OldName("Text")]
        public string Text { get; set; }


    }
}
