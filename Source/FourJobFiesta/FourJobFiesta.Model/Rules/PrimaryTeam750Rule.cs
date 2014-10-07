using System.Collections.Generic;
using System.Linq;

namespace FourJobFiesta.Model.Rules
{
    public class PrimaryTeam750Rule : Rule
    {
        public PrimaryTeam750Rule()
        {
            RuleType = RuleType.Primary;
            Name = "Team 750";
            Description =
                "You are only allowed to use classes that are Mages or similar to Mages. "
                + "\n\nAvailable Jobs: Black Mage, White Mage, Blue Mage, Summoner, Time Mage, Red Mage, "
                + "Bard, Geomancer, Dancer, and Chemist.";
        }

        public override IEnumerable<Job> Apply(IEnumerable<Job> jobs, CrystalType crystalType, IEnumerable<Job> selectedJobs)
        {
            return jobs.Where(job => 
                (job.IsTeam750 
                && (job.CrystalType == crystalType))
                && !selectedJobs.Contains(job));
        }
    }
}
