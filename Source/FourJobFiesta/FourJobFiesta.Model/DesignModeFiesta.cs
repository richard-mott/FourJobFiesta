namespace FourJobFiesta.Model
{
    public class DesignModeFiesta : Fiesta
    {
        public DesignModeFiesta()
        {
            WindCrystal = JobFactory.GetJob("Knight");
            WaterCrystal = JobFactory.GetJob("Red Mage");
            FireCrystal = JobFactory.GetJob("Ninja");
            EarthCrystal = JobFactory.GetJob("Dancer");
        }
    }
}
