using Assisticant;
using FourJobFiesta.Model;

namespace FourJobFiesta.ViewModels
{
    public class CrystalsViewModel
    {
        private Fiesta _fiesta;

        public CrystalsViewModel(Fiesta fiesta)
        {
            _fiesta = fiesta;
        }

        public CrystalViewModel Wind
        {
            get { return new CrystalViewModel(_fiesta.Wind); }
        }

        public CrystalViewModel Water
        {
            get { return new CrystalViewModel(_fiesta.Water); }
        }

        public CrystalViewModel Fire
        {
            get { return new CrystalViewModel(_fiesta.Fire); }
        }

        public CrystalViewModel Earth
        {
            get { return new CrystalViewModel(_fiesta.Earth); }
        }
    }
}
