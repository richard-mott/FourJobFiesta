using System.Collections.Generic;
using System.Linq;

namespace FourJobFiesta.Model.Rules
{
    public class PrimaryTeamNo750Rule : Rule
    {
        public PrimaryTeamNo750Rule()
        {
            RuleType = RuleType.Primary;
            Name = "Team No 750";
            Description =
                "You are only allowed to use classes that are not in the Team 750 list. "
                + "\n\nAvailable Jobs: Knight, Monk, Thief, Berserker, Mystic Knight, Ninja, Beastmaster, "
                + "Ranger, Dragoon, and Samurai.";
        }

        public override IEnumerable<Job> Apply(IEnumerable<Job> jobs, CrystalType crystalType, IEnumerable<Job> selectedJobs)
        {
            return jobs.Where(job => 
                !job.IsTeam750 
                && (job.CrystalType == crystalType)
                && !selectedJobs.Contains(job));
        }
    }
}
