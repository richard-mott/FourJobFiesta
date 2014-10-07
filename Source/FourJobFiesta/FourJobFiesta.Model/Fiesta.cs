using System.Collections.Generic;
using Assisticant.Fields;
using FourJobFiesta.Model.Rules;

namespace FourJobFiesta.Model
{
    public class Fiesta
    {
        private readonly Observable<Rule> _primaryRule
            = new Observable<Rule>(new PrimaryNormalRule());
        private readonly Observable<Rule> _secondaryRule
            = new Observable<Rule>(new SecondaryNormalRule());
        private readonly Observable<Job> _windCrystal
            = new Observable<Job>(JobFactory.NullJob);
        private readonly Observable<Job> _waterCrystal
            = new Observable<Job>(JobFactory.NullJob);
        private readonly Observable<Job> _fireCrystal
            = new Observable<Job>(JobFactory.NullJob);
        private readonly Observable<Job> _earthCrystal
            = new Observable<Job>(JobFactory.NullJob);

        public Fiesta()
        {
            Rules = new List<Rule>
            {
                new PrimaryNormalRule(),
                new PrimaryRandomRule(),
                new PrimaryTeam750Rule(),
                new PrimaryTeamNo750Rule(),
                new PrimaryClassicRule(),
                new SecondaryNormalRule(),
                new SecondaryNaturalRule()
            };

            SelectedJobs = new List<Job>();
        }

        public IEnumerable<Rule> Rules { get; private set; }
        public List<Job> SelectedJobs { get; private set; }
        
        public Rule PrimaryRule
        {
            get { return _primaryRule; }
            set { _primaryRule.Value = value; }
        }

        public Rule SecondaryRule
        {
            get { return _secondaryRule; }
            set { _secondaryRule.Value = value; }
        }

        public Job WindCrystal
        {
            get { return _windCrystal; }
            set { _windCrystal.Value = value; }
        }

        public Job WaterCrystal
        {
            get { return _waterCrystal; }
            set { _waterCrystal.Value = value; }
        }

        public Job FireCrystal
        {
            get { return _fireCrystal; }
            set { _fireCrystal.Value = value; }
        }

        public Job EarthCrystal
        {
            get { return _earthCrystal; }
            set { _earthCrystal.Value = value; }
        }
    }
}
