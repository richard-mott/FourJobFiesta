namespace FourJobFiesta.Model.Rules
{
    public class SecondaryNaturalRule : Rule
    {
        public SecondaryNaturalRule()
        {
            RuleType = RuleType.Secondary;
            Name = "Natural";
            Description =
                "Bartz must use the Wind Crystal job exclusively, Lenna the Water, Faris the Fire, and Galuf the Earth. "
                + "Until you reach the assigned Crystal, that character must use the Freelancer job. "
                + "\n\nThe only exception is, when doing a Classic run, the jobs are assigned from the Classic job set "
                + "instead of the set for that Crystal.";
        }
    }
}
