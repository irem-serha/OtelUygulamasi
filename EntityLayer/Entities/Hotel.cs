using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public string HotelDescription { get; set; } = string.Empty;
        public string HotelAdress { get; set; } = string.Empty;
        public string Suburb { get; set; }= string.Empty;
        public int PostCode { get; set; }
        public string PhoneNo { get; set; } = string.Empty; 
        public virtual List<Room>? Rooms { get; set; }   
        public  List<Emplyees>? Emplyees { get; set; }


    }
}
