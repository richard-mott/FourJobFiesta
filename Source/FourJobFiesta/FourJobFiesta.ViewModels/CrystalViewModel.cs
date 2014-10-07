using System.IO;
using FourJobFiesta.Model;

namespace FourJobFiesta.ViewModels
{
    public class CrystalViewModel
    {
        private readonly Crystal _crystal;

        public CrystalViewModel(Crystal crystal)
        {
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
    }
}
