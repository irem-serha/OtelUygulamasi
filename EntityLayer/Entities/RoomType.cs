using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        [Display(Name ="Oda Adı")]
        [Required(ErrorMessage ="Oda Adını Boş Bırakamazsınız.")]
        public string RoomName { get; set; } = string.Empty;
        [Display(Name = "Oda Fiyatı")]
        [Required(ErrorMessage = "Oda Fiyatını Boş Bırakamazsınız.")]
        [Range(0,double.MaxValue)]
        public double? RoomPrice { get; set; }
        public virtual List<Room>? Room { get; set; }
    }
}
