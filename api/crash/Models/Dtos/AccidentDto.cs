namespace Crash.Models.Dtos
{
   public class AccidentDto
   {
        public Guid Id { get; set; }
        public int AccidentId { get; set; }
        public string Location { get; set; }

        public DateTime AccidentDate { get; set; }

        public string Weather { get; set; }
        public string Daylight { get; set; }
        public double EstimatedCost { get; set; }
        public int NumberOfParties { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public List<string> Parties { get; set; } = new List<string>();
    }
}
