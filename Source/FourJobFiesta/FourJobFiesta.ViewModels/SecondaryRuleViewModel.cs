using FourJobFiesta.Model;
using FourJobFiesta.Model.Rules;

namespace FourJobFiesta.ViewModels
{
    public class SecondaryRuleViewModel
    {
        private readonly Fiesta _fiesta;
        private readonly Rule _rule;

        public SecondaryRuleViewModel(Fiesta fiesta, Rule rule)
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
            get { return _fiesta.SecondaryRule.Equals(_rule); }
            set
            {
                if (value)
                    _fiesta.SecondaryRule = _rule;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            var that = obj as SecondaryRuleViewModel;
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
