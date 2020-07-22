namespace Hive
{
    public class Queen: Bee
    {
        public Queen() : base()
        {
            BeeType = "Queen";
        }
        public override void Damage(int percentageToReduce)
        {
            TakeDamage(percentageToReduce);
            // Queen below 20 %
            if (Health < (MaxHealth * 0.2))
            {
                PronounceDead();
            }
        }
    }
}
