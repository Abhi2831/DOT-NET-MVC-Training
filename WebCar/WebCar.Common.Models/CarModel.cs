using WebCar.Common.Enums;

namespace WebCar.Common.Models
{
    public class CarModel
    {
        public int? Id { get; set; }
        public string? CarName { get; set; }
        public string? Carmodel { get; set; }

        public string? CarManufacturer { get; set; }
        public CarTypes? CarColor { get; set; }
        public string? CarReleaseDate { get; set; }
        public object? Title { get; set; }
    }
}