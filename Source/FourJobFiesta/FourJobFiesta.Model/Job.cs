namespace FourJobFiesta.Model
{
    public class Job
    {
        public string Name { get; private set; }
        public string ImagePath { get; private set; }
        public Crystal Crystal { get; private set; }
        public bool IsTeam750 { get; private set; }
        public bool IsClassic { get; private set; }

        private static Job _null;

        public Job(string name, Crystal crystal, bool isTeam750, bool isClassic)
        {
            Name = name;
            ImagePath = GetImagePath(name);
            Crystal = crystal;
            IsTeam750 = isTeam750;
            IsClassic = isClassic;
        }

        public static Job NULL
        {
            get
            {
                return _null ?? (_null = new Job(string.Empty, Crystal.None, false, false));
            }
        }

        private string GetImagePath(string name)
        {
            return "job_" + name.ToLower().Replace(" ", "_");
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            var that = obj as Job;
            if (that == null)
                return false;

            return Equals(Name, that.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
