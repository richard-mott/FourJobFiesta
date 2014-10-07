using Assisticant;
using FourJobFiesta.Model;

namespace FourJobFiesta.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private readonly Fiesta _fiesta;

        public ViewModelLocator()
        {
            _fiesta = DesignMode 
                ? new DesignModeFiesta() 
                : new Fiesta();
        }

        public object PrimaryRulesViewModel
        {
            get
            {
                return ViewModel(() =>
                    new PrimaryRulesViewModel(_fiesta));
            }
        }

        public object SecondaryRulesViewModel
        {
            get
            {
                return ViewModel(() =>
                    new SecondaryRulesViewModel(_fiesta));
            }
        }

        public object CrystalsViewModel
        {
            get
            {
                return ViewModel(() =>
                    new CrystalsViewModel(_fiesta));
            }
        }
    }
}
