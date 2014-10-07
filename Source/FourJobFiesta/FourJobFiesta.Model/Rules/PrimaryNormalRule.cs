using System.Collections.Generic;
using System.Linq;

namespace FourJobFiesta.Model.Rules
{
    public class PrimaryNormalRule : Rule
    {
        public PrimaryNormalRule()
        {
            RuleType = RuleType.Primary;
            Name = "Normal";
            Description = 
                "This is the standard challenge. "
                + "For each Crystal, you are assigned a single job from that Crystal's job set. "
                + "At the end of the game, you will have access to one job from each crystal."
                + "\n\nFor example, the Wind Crystal will assign you Knight, Monk, Thief, Black Mage, White Mage, or Blue Mage. ";
        }

        public override IEnumerable<Job> Apply(IEnumerable<Job> jobs, CrystalType crystalType, IEnumerable<Job> selectedJobs)
        {
            return jobs.Where(job => job.CrystalType == crystalType);
        }
    }
}
