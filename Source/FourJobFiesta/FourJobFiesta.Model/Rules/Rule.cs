using System.Collections.Generic;
using Assisticant.Fields;

namespace FourJobFiesta.Model.Rules
{
    public class Rule
    {
        private Observable<RuleType> _ruleType = new Observable<RuleType>();
        public RuleType RuleType
        {
            get { return _ruleType; }
            protected set { _ruleType.Value = value; }
        }

        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public virtual IEnumerable<Job> Apply(IEnumerable<Job> jobs, CrystalType crystalType, IEnumerable<Job> selectedJobs)
        {
            return jobs;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            var that = obj as Rule;
            if (that == null)
                return false;

            return Equals(RuleType, that.RuleType) 
                && Equals(Name, that.Name) 
                && Equals(Description, that.Description);
        }

        public override int GetHashCode()
        {
            // Overflow is fine, just wrap
            unchecked
            {
                var hash = 17;
                
                hash = hash * 23 + RuleType.GetHashCode();
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Description.GetHashCode();
                
                return hash;
            }
        }
    }
}
