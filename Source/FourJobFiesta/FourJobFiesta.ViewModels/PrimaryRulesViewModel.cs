using System.Collections.Generic;
using System.Linq;
using FourJobFiesta.Model;
using FourJobFiesta.Model.Rules;

namespace FourJobFiesta.ViewModels
{
    public class PrimaryRulesViewModel
    {
        private readonly Fiesta _fiesta;

        public PrimaryRulesViewModel(Fiesta fiesta)
        {
            _fiesta = fiesta;
        }

        public IEnumerable<PrimaryRuleViewModel> Rules
        {
            get
            {
                return _fiesta.Rules
                    .Where(rule => rule.RuleType == RuleType.Primary)
                    .Select(rule => new PrimaryRuleViewModel(_fiesta, rule));
            }
        }

        public Rule PrimaryRule
        {
            get { return _fiesta.PrimaryRule; }
            set { _fiesta.PrimaryRule = value; }
        }

        public string Title
        {
            get { return "Primary Rules"; }
        }
    }
}
