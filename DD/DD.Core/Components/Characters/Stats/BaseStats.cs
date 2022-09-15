namespace Stats
{
    public class BaseStats
    {
        public BaseStats(float attack, float defense, float hitPoints, float movement)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            Movement = movement;
        }

        public float Attack { get; set; }
        public float Defense { get; set; }
        public float HitPoints { get; set; }
        public float Movement { get; set; }
    }
}