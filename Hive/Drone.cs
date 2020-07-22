namespace Hive
{
    public class Drone : Bee
    {
        public Drone():base()
        {
            BeeType = "Drone";
        }
        public override void Damage(int percentageToReduce)
        {
            TakeDamage(percentageToReduce);
            // Drone below 50 %
            if (Health < (MaxHealth * 0.5))
            {
                PronounceDead();
            }
        }

    }
}
