using System.Collections.Generic;
using System.Linq;

namespace FourJobFiesta.Model.Rules
{
    public class PrimaryRandomRule : Rule
    {
        public PrimaryRandomRule()
        {
            RuleType = RuleType.Primary;
            Name = "Random";
            Description =
                "When you reach a crystal, you are assigned a job chosen from all jobs available at that point. "
                + "\n\nFor example, when you reach the Fire crystal, you will be assigned a job from any of the "
                + "Wind, Water, or Fire Crystal job sets.";
        }

        public override IEnumerable<Job> Apply(IEnumerable<Job> jobs, CrystalType crystalType, IEnumerable<Job> selectedJobs)
        {
            return jobs.Where(job => (job.CrystalType <= crystalType && !selectedJobs.Contains(job)));
        }
    }
}
