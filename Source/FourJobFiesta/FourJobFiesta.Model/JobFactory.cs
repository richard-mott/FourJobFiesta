using System;
using System.Collections.Generic;
using System.Linq;

namespace FourJobFiesta.Model
{
    public static class JobFactory
    {
        private static readonly List<Job> DefaultJobs;
        private static readonly List<string> ValidNames;
        private static readonly Job _nullJob;

        static JobFactory()
        {
            DefaultJobs = new List<Job>
            {
                // Wind Crystal
                new Job("Knight", CrystalType.Wind, false, true),
                new Job("Monk", CrystalType.Wind, false, true),
                new Job("Thief", CrystalType.Wind, false, true),
                new Job("Black Mage", CrystalType.Wind, true, true),
                new Job("White Mage", CrystalType.Wind, true, true),
                new Job("Blue Mage", CrystalType.Wind, true, false),

                // Water Crystal
                new Job("Red Mage", CrystalType.Water, true, true),
                new Job("Time Mage", CrystalType.Water, true, false),
                new Job("Summoner", CrystalType.Water, true, false),
                new Job("Berserker", CrystalType.Water, false, false),
                new Job("Mystic Knight", CrystalType.Water, false, false),

                // Fire Crystal
                new Job("Beastmaster", CrystalType.Fire, false, false),
                new Job("Geomancer", CrystalType.Fire, true, false),
                new Job("Ninja", CrystalType.Fire, false, false),
                new Job("Ranger", CrystalType.Fire, false, false),
                new Job("Bard", CrystalType.Fire, true, false),

                // Earth Crystal
                new Job("Dragoon", CrystalType.Earth, false, false),
                new Job("Dancer", CrystalType.Earth, true, false),
                new Job("Samurai", CrystalType.Earth, false, false),
                new Job("Chemist", CrystalType.Earth, true, false)
            };

            ValidNames = DefaultJobs.Select(job => job.Name).ToList();
            
            _nullJob = new Job("None", CrystalType.None, false, false);
        }

        public static Job NullJob
        {
            get { return _nullJob;}
        }

        public static Job GetJob(string name)
        {
            return IsNameValid(name)
                ? DefaultJobs.First(job => job.Name == name)
                : Job.NULL;
        }

        public static IEnumerable<Job> GetAllJobs()
        {
            return DefaultJobs;
        }

        public static IEnumerable<Job> GetJobs(Func<Job, bool> query)
        {
            return DefaultJobs.Where(query);
        }

        private static bool IsNameValid(string name)
        {
            return ValidNames.Contains(name);
        }

    }
}
