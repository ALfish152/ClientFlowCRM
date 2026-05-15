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
        public string Summary { get; set; }
        public string Outcome { get; set; }
        public int Duration { get; set; }

        public Interaction()
        {
            Timestamp = DateTime.Now;
            Notes = "";
            Outcome = "";
        }

        public virtual void UpdateSummary() { }
    }

    public class Call : Interaction
    {
        public override string Type => "Call";
        public override void UpdateSummary()
        {
            Summary = $"{Outcome}";
        }
    }

    public class Email : Interaction
    {
        public string Subject { get; set; }
        public override string Type => "Email";
        public override void UpdateSummary()
        {
            Summary = $"Subject: {Subject}";
        }
    }

    public class Meeting : Interaction
    {
        public string Location { get; set; }
        public override string Type => "Meeting";
        public override void UpdateSummary()
        {
            Summary = $"Location: {Location}";
        }
    }
}