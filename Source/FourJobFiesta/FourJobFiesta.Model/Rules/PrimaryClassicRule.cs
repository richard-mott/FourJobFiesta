using System.Collections.Generic;
using System.Linq;

namespace FourJobFiesta.Model.Rules
{
    public class PrimaryClassicRule : Rule
    {
        public PrimaryClassicRule()
        {
            RuleType = RuleType.Primary;
            Name = "Classic";
            Description =
                "Only jobs available in Final Fantasy I can be used. Classic runs are always Natural runs. "
                + "However, jobs can be assigned multiple times. "
                + "\n\nAvailable Jobs: Knight, Monk, Thief, White Mage, Black Mage, Red Mage. "
                + "The Red Mage job can only be assigned after reaching the Water Crystal.";
        }

        public override IEnumerable<Job> Apply(IEnumerable<Job> jobs, CrystalType crystalType, IEnumerable<Job> selectedJobs)
        {
            return jobs.Where(job => (job.IsClassic && job.CrystalType <= crystalType));
        }
    }
}
