namespace carbox.Models
{
    public class Car
    {
        public required string Id { get; set; }
        public int BatteryLevel { get; set; }
        public required Location Location { get; set; }
        public CarStatus Status { get; set; } = CarStatus.Available;
        public required Station LastStation { get; set; }
        public int RouteId { get; set; }
        public List<ScheduledTrip> ScheduledTrips { get; set; } = new List<ScheduledTrip>(); // רשימת נסיעות מתוזמנות
        public List<Station> StopStations { get; set; } = new List<Station>();


        //public int lastStation()
        //{
        //    return StopStations[0].Id - 1;
        //}
    }

    public enum CarStatus
    {
        Available=0 ,  // Available
        Occupied =1 ,   // Occupied
        Maintenance =2,
        Waiting = 3 
    }
}