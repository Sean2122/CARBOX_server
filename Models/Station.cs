namespace carbox.Models
{
    public class Station
    {
        public int Id { get; set; }  // Station identifier
        public required string Name { get; set; }  // Station name
        public required Location Location { get; set; }  // Station location
    }
}