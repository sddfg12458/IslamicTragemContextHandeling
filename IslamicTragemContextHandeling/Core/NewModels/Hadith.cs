using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IslamicTragemContextHandeling.Core.NewModels
{
    [OldName("HadithZiadNew")]
    public class Hadith
    {
        [Key]
        [OldName("SelId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [OldName("BabId")]
        public int? BabId { get; set; }
        public HadithBab Bab { get; set; }

        [OldName("Matn")]
        public string Matn { get; set; }

        [OldName("HadithWithSign")]
        public string HadithWithSign { get; set; }

        [OldName("HadithWithNoSign")]
        public string HadithWithNoSign { get; set; }


    }
}
