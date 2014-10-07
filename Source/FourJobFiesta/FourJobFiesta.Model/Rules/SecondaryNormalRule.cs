namespace FourJobFiesta.Model.Rules
{
    public class SecondaryNormalRule : Rule
    {
        public SecondaryNormalRule()
        {
            RuleType = RuleType.Secondary;
            Name = "Normal";
            Description =
                "This is the standard secondary rule. "
                + "Any character can equip the four jobs you are assigned. "
                + "When you have jobs available, you cannot be the Freelancer job, and you must use at least one of each job available. "
                + "\n\nFor example, at the Wind Crystal, you are assigned the Knight job. "
                + "At this point, all four characters must use this job. "
                + "At the Water Crystal, you are assigned the Time Mage job. "
                + "\n\nYou must then have at least one Knight and one Time Mage in your party, and all "
                + "characters must use one of these jobs (i.e., two Knights and two Time Mages, "
                + "three Knights and one Time Mage, or one Knight and three Time Mages).";
        }
    }
}
