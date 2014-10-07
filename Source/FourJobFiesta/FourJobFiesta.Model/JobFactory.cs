using System;
using System.Collections.Generic;
using System.Linq;

namespace FourJobFiesta.Model
{
    public static class JobFactory
    {
        private static readonly List<Job> DefaultJobs;
        private static readonly List<string> ValidNames;

        static JobFactory()
        {
            DefaultJobs = new List<Job>
            {
                // Wind Crystal
                new Job("Knight", Crystal.Wind, false, true),
                new Job("Monk", Crystal.Wind, false, true),
                new Job("Thief", Crystal.Wind, false, true),
                new Job("Black Mage", Crystal.Wind, true, true),
                new Job("White Mage", Crystal.Wind, true, true),
                new Job("Blue Mage", Crystal.Wind, true, false),

                // Water Crystal
                new Job("Red Mage", Crystal.Water, true, true),
                new Job("Time Mage", Crystal.Water, true, false),
                new Job("Summoner", Crystal.Water, true, false),
                new Job("Berserker", Crystal.Water, false, false),
                new Job("Mystic Knight", Crystal.Water, false, false),

                // Fire Crystal
                new Job("Beastmaster", Crystal.Fire, false, false),
                new Job("Geomancer", Crystal.Fire, true, false),
                new Job("Ninja", Crystal.Fire, false, false),
                new Job("Ranger", Crystal.Fire, false, false),
                new Job("Bard", Crystal.Fire, true, false),

                // Earth Crystal
                new Job("Dragoon", Crystal.Earth, false, false),
                new Job("Dancer", Crystal.Earth, true, false),
                new Job("Samurai", Crystal.Earth, false, false),
                new Job("Chemist", Crystal.Earth, true, false)
            };

            ValidNames = DefaultJobs.Select(job => job.Name).ToList();
        }

        public static Job GetJob(string name)
        {
            return IsNameValid(name)
                ? DefaultJobs.First(job => job.Name == name)
                : Job.NULL;
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
