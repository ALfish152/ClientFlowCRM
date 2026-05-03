using System;

namespace ClientFlowCRM.Models
{
    public abstract class Interaction
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Notes { get; set; }
        public abstract string Type { get; }
        public abstract string Summary { get; } 

        public Interaction()
        {
            Timestamp = DateTime.Now;
            Notes = "";
        }
    }

    public class Call : Interaction
    {
        public int Duration { get; set; }
        public string Outcome { get; set; }
        public override string Type => "Call";
        public override string Summary => $"Call ({Duration}min) - {Outcome}";
    }

    public class Email : Interaction
    {
        public string Subject { get; set; }
        public override string Type => "Email";
        public override string Summary => $"Email: {Subject}";
    }

    public class Meeting : Interaction
    {
        public string Location { get; set; }
        public string Attendees { get; set; }
        public override string Type => "Meeting";
        public override string Summary => $"Meeting at {Location}";
    }
}