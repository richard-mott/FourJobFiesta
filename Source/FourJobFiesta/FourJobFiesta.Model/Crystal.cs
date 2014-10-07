using Assisticant.Fields;

namespace FourJobFiesta.Model
{
    public class Crystal
    {
        private Observable<string> _name = new Observable<string>("");
        private Observable<CrystalType> _crystalType = new Observable<CrystalType>(CrystalType.None);
        private Observable<Job> _job = new Observable<Job>(JobFactory.NullJob);

        public CrystalType CrystalType
        {
            get { return _crystalType; }
            set { _crystalType.Value = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name.Value = value; }
        }

        public Job Job
        {
            get { return _job; }
            set { _job.Value = value; }
        }

        public Crystal() {}

        public Crystal(string name, CrystalType crystalType)
        {
            _name.Value = name;
            _crystalType.Value = crystalType;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            var that = obj as Crystal;
            if (that == null)
                return false;

            return Equals(Name, that.Name) && Equals(CrystalType, that.CrystalType);
        }

        public override int GetHashCode()
        {
            // Overflow is fine, just wrap
            unchecked
            {
                var hash = 17;

                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + CrystalType.GetHashCode();

                return hash;
            }
        }
    }
}