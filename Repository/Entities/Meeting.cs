using Repository.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Meeting
    {
        public string Title { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public TimeOnly StartAt { get; set; }
        public TimeOnly EndAt { get; set; }
        public List<EmployeeDto> Participants { get; set; } = new();

        public override string ToString()
        {
            string participantsText;

            if (Participants.Count == 0)
            {
                participantsText = "    None";
            }
            else
            {
                participantsText = string.Join(Environment.NewLine,
                    Participants.Select(p => $"\t                 -[{p.EmployeeNo}]. {p.Name}"));
            }

            return
                    $@"Meeting:
              Title        : {Title}
              Date         : {Date}
              Start At     : {StartAt}
              End At       : {EndAt}
              Participants:
{participantsText}";
        }
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if(ReferenceEquals(this, obj)) return true;
            if(obj.GetType() != this.GetType()) return false;

            Meeting other = (Meeting) obj;

            return Title.Equals(other.Title)
                && StartAt == other.StartAt
                && Date == other.Date
                && EndAt == other.EndAt
                && Participants.SequenceEqual(other.Participants);
        }

        public override int GetHashCode()
        {

            int hash = 17;

            hash = hash * 23 + Title.GetHashCode();
            hash = hash * 23 + StartAt.GetHashCode();
            hash = hash * 23 + EndAt.GetHashCode();
            hash = hash * 23 + Date.GetHashCode();

            return hash;
        }

    }
}
