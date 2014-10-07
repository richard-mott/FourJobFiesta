namespace FourJobFiesta.Model
{
    public class DesignModeFiesta : Fiesta
    {
        public DesignModeFiesta()
        {
            Wind.Job = JobFactory.GetJob("Knight");
            Water.Job = JobFactory.GetJob("Red Mage");
            Fire.Job = JobFactory.GetJob("Ninja");
            Earth.Job = JobFactory.GetJob("Dancer");
        }
    }
}
