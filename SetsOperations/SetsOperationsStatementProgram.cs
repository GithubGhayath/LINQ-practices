using Repository.Entities;
using Repository.Extensions;
using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOperationsStatement
{
    internal class SetsOperationsStatementProgram
    {
        public static void Main(string[] args)
        {
            RunExample04();
        }

        // Union() and UnionBy()
        private static void RunExample04()
        {
            var Set1 = Meetings.GetMeetings()[0];
            var Set2 = Meetings.GetMeetings()[1];


            Set1.Participants.Print($"=============== Meeting 1 Participants ({Set1.Participants.Count})");
            Set2.Participants.Print($"=============== Meeting 2 Participants ({Set2.Participants.Count})");

            // var Set3 = Set1.Participants.Union(Set2.Participants);

            // Or we can use UnionBy() if .Equals() not implement:
            var Set3 = Set1.Participants.UnionBy(Set2.Participants, x => x.EmployeeNo);

            Set3.Print("=============== Meeting 1 Participants Union Meeting 2 participants");
        }


        // Intersect() and IntersectBy()
        private static void RunExample03()
        {
            var Set1 = Meetings.GetMeetings()[0];
            var Set2 = Meetings.GetMeetings()[1];


            Set1.Participants.Print($"=============== Meeting 1 Participants ({Set1.Participants.Count})");
            Set2.Participants.Print($"=============== Meeting 2 Participants ({Set2.Participants.Count})");

            //var Set3 = Set1.Participants.Intersect(Set2.Participants);

            // Or we can use IntersectBy() if .Equals() not implement:
            var Set3 = Set1.Participants.IntersectBy(Set2.Participants.Select(x => x.EmployeeNo), p => p.EmployeeNo);

            Set3.Print("=============== Meeting 1 Participants Intersected with Meeting 2 participants");
        }


        // Expect() and ExpectBy()
        private static void RunExample02()
        {
            var Set1 = Meetings.GetMeetings()[0];
            var Set2 = Meetings.GetMeetings()[1];


            Set1.Participants.Print($"=============== Meeting 1 Participants ({Set1.Participants.Count})");
            Set2.Participants.Print($"=============== Meeting 2 Participants ({Set2.Participants.Count})");


            //var Set3 = Set1.Participants.Except(Set2.Participants);

            // Or we can use ExceptBy() if .Equals() not implement:
            var Set3 = Set1.Participants.ExceptBy(Set2.Participants.Select(x => x.EmployeeNo), p => p.EmployeeNo);

            Set3.Print("=============== Meeting 1 Participants except Meeting 2 participants");
        }


        // Distinct() and DistinctBy()
        private static void RunExample01()
        {
            // Employees in meeting 1 and meeting 2
            var participantsM1M2 = Meetings.GetMeetings()[0].Participants.Concat(Meetings.GetMeetings()[1].Participants);


            // To get distinct :
            //var DistinctParticipants = participantsM1M2.Distinct();

            // Or we can use DistinctBy() if .Equals() not implement:
            var DistinctParticipants = participantsM1M2.DistinctBy(p => p.EmployeeNo);


            // Printing the Distinct Participants
            DistinctParticipants.Print("Meeting 1 and Meeting 2 participants (Distinct)");
        }


    }

  
}
