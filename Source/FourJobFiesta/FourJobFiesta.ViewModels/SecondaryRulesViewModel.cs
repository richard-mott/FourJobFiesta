using System.Collections.Generic;
using System.Linq;
using FourJobFiesta.Model;
using FourJobFiesta.Model.Rules;

namespace FourJobFiesta.ViewModels
{
    public class SecondaryRulesViewModel
    {
        private readonly Fiesta _fiesta;

        public SecondaryRulesViewModel(Fiesta fiesta)
        {
            _fiesta = fiesta;
        }

        public IEnumerable<SecondaryRuleViewModel> Rules
        {
            get
            {
                return _fiesta.Rules
                    .Where(rule => rule.RuleType == RuleType.Secondary)
                    .Select(rule => new SecondaryRuleViewModel(_fiesta, rule));
            }
        }

        public Rule SecondaryRule
        {
            get { return _fiesta.SecondaryRule; }
            set { _fiesta.SecondaryRule = value; }
        }

        public string Title
        {
            get { return "Secondary Rules"; }
        }
    }
}
