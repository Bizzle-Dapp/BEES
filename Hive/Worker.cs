namespace Hive
{
    public class Worker: Bee
    {
        public Worker() : base()
        {
            BeeType = "Worker";
        }
        public override void Damage(int percentageToReduce)
        {
            TakeDamage(percentageToReduce);
            // Worker below 70 %
            if (Health < (MaxHealth * 0.7))
            {
                PronounceDead();
            }
        }
    }
}
