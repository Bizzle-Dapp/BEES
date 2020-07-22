namespace Hive
{
    /// <summary>
    /// I have chosen an abstract class to define the Bee ...
    /// ...This will be the base class for all future types of Bee.
    /// </summary>
    public abstract class Bee
    {
        public float MaxHealth { get; } = 100; // Removes the use of magic numbers further afield.
        public string BeeType { get; protected set; } // Protected to stop UI project being able to update this in the DataGridView. Derived classes only, after all, only needed by constructors.
        public float Health { get; private set; }
        public bool Dead { get; private set; }

        /// <summary>
        /// Each Bee has a floating-point health property, which is not writable externally and upon creation is set to
        /// a value of 100. All Bee's are alive by default.
        /// </summary>
        protected Bee()
        {
            Health = MaxHealth;
            Dead = false; 
        }

        /// <summary>
        /// Renders the Bee's 'Dead' property true.
        /// </summary>
        public void PronounceDead()
        {
            Dead = true;
        }

        /// <summary>
        /// Takes a single integer parameter that should be a value between 0 ...
        /// ...and 100.  When this method is called, the health of the bee is to be ...
        /// ...reduced by that percentage of their current health.
        /// </summary>
        /// <param name="percentageToReduce">Percentage of current Health to reduce by</param>
        public abstract void Damage(int percentageToReduce);

        /// <summary>
        /// The method that performs the reusable logic of damaging a bee.
        /// </summary>
        /// <param name="percentageToReduce"></param>
        public void TakeDamage(int percentageToReduce)
        {
            // Each Bee has a Damage() method that takes a single integer parameter that should be a value between 0 and 100.
            if (percentageToReduce < 0 || percentageToReduce > 100) return;
            /* I did have this, but realised it would have to be a programmer error and would then result in a try{}catch{} in the UI unnecessarily. */
            // throw new ArgumentOutOfRangeException(nameof(percentageToReduce)); 

            // When a Bee is dead, no further health deductions should be recorded by the bee
            if (Dead) return;

            // Reduce Health - This line alone I could spend a thousand years thinking about. Precision here is absolutely the test,
            // however I'm trying to wager which is the more important value. It appears that a Bee's Health is gauged as a percentage, thus 100
            // to start. Now I'm sat here thinking though that perhaps this itself it the test due to the nature of the work. 

            // I've decided my best efforts here are, keep as close to absolute precision as I feasibly can given the time:
            Health -= (Health * (percentageToReduce / 100f));
        }
    }
}
