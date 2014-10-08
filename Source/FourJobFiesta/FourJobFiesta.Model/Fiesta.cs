using System;
using System.Collections.Generic;
using System.Linq;
using Assisticant.Fields;
using FourJobFiesta.Model.Rules;

namespace FourJobFiesta.Model
{
    public class Fiesta
    {
        private static readonly Random Random = new Random();

        private readonly Observable<Rule> _primaryRule
            = new Observable<Rule>(new PrimaryNormalRule());
        private readonly Observable<Rule> _secondaryRule
            = new Observable<Rule>(new SecondaryNormalRule());
        
        private readonly Observable<Crystal> _wind
            = new Observable<Crystal>(new Crystal("Wind Crystal", "Bartz", CrystalType.Wind));
        private readonly Observable<Crystal> _water
            = new Observable<Crystal>(new Crystal("Water Crystal", "Lenna", CrystalType.Water));
        private readonly Observable<Crystal> _fire
            = new Observable<Crystal>(new Crystal("Fire Crystal", "Faris", CrystalType.Fire));
        private readonly Observable<Crystal> _earth
            = new Observable<Crystal>(new Crystal("Earth Crystal", "Galuf", CrystalType.Earth));

        public IEnumerable<Rule> Rules { get; private set; }
        public List<Job> SelectedJobs { get; private set; }

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

        public Crystal Wind
        {
            get { return _wind; }
            set { _wind.Value = value; }
        }

        public Crystal Water
        {
            get { return _water; }
            set { _water.Value = value; }
        }

        public Crystal Fire
        {
            get { return _fire; }
            set { _fire.Value = value; }
        }

        public Crystal Earth
        {
            get { return _earth; }
            set { _earth.Value = value; }
        }

        public void SelectJob(Crystal crystal)
        {
            var validJobs = GetAvailableJobs(crystal);
            var selectedJob = GetRandomJob(validJobs.ToList());

            if (SelectedJobs.Contains(crystal.Job))
                SelectedJobs.Remove(crystal.Job);

            crystal.Job = selectedJob;
            crystal.Level++;
            SelectedJobs.Add(selectedJob);
        }

        private IEnumerable<Job> GetAvailableJobs(Crystal crystal)
        {
            var jobs = JobFactory.GetAllJobs();

            jobs = PrimaryRule.Apply(jobs, crystal.CrystalType, SelectedJobs);
            jobs = SecondaryRule.Apply(jobs, crystal.CrystalType, SelectedJobs);

            return jobs;
        }

        private Job GetRandomJob(List<Job> jobs)
        {
            if (jobs.Count == 0)
                return JobFactory.NullJob;

            var selectedIndex = Random.Next(jobs.Count);

            return jobs[selectedIndex];
        }
    }
}
