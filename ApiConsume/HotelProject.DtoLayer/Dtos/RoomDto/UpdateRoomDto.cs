using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Please add room number!")]
        public string? RoomNumber { get; set; }
        public string? RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please add room price!")]
        public int? Price { get; set; }
        [Required(ErrorMessage = "Please add room title!")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Please add bed count of the room number!")]
        public string? BedCount { get; set; }
        [Required(ErrorMessage = "Please add bath count of the room number!")]
        public string? BathCount { get; set; }
        public string? Wifi { get; set; }
        [Required(ErrorMessage = "Please add description!")]
        public string? Description { get; set; }
    }
}
