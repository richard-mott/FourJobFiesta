using System.IO;
using System.Windows.Input;
using Assisticant;
using FourJobFiesta.Model;

namespace FourJobFiesta.ViewModels
{
    public class CrystalViewModel
    {
        private readonly Fiesta _fiesta;
        private readonly Crystal _crystal;

        public CrystalViewModel(Fiesta fiesta, Crystal crystal)
        {
            _fiesta = fiesta;
            _crystal = crystal;
        }

        public string Name
        {
            get { return _crystal.Name; }
        }

        public string JobName
        {
            get { return _crystal.Job.Name; }
        }

        public string ImagePath
        {
            get
            {
                const string path = "Images/";
                var jobImage = _crystal.Job.ImagePath;

                var fullPath = Path.GetFullPath(path + jobImage);

                return fullPath;
            }
        }

        public ICommand SelectJob
        {
            get
            {
                return MakeCommand
                    .Do(() => _fiesta.SelectJob(_crystal));
            }
        }
    }
}
