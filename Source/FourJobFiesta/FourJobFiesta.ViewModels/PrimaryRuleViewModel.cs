using FourJobFiesta.Model;
using FourJobFiesta.Model.Rules;

namespace FourJobFiesta.ViewModels
{
    public class PrimaryRuleViewModel
    {
        private readonly Fiesta _fiesta;
        private readonly Rule _rule;

        public PrimaryRuleViewModel(Fiesta fiesta, Rule rule)
        {
            _fiesta = fiesta;
            _rule = rule;
        }

        public string Name
        {
            get { return _rule.Name; }
        }

        public string Description
        {
            get { return _rule.Description; }
        }

        public bool IsSelected
        {
            get { return _fiesta.PrimaryRule.Equals(_rule); }
            set
            {
                if (value)
                    _fiesta.PrimaryRule = _rule;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            var that = obj as PrimaryRuleViewModel;
            if (that == null)
                return false;

            return Equals(_rule, that._rule);
        }

        public override int GetHashCode()
        {
            return _rule.GetHashCode();
        }
    }
}
