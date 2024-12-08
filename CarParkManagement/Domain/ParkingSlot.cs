using System.ComponentModel.DataAnnotations;

namespace CarParkManagement.Domain
{
    public class ParkingSlot
    {
        [Key]
        public int SlotID { get; set; }
        public string SlotNumber { get; set; }
        public bool InAvailable { get; set; }
        public string Floorlevel { get; set; }
        public string? Location { get; set; }
    }
}
