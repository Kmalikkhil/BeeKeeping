namespace BeeKeeping
{
    public class QueenBee : Bee
    {
        public QueenBee()
        {
        }

        public QueenBee(string name, float size) : base(name, size)
        {
            this.Size = 0f;
        }

        public Bee MakeBee(string name){
            Bee newBee = new Bee();
            newBee.Size = 0.1f;
            newBee.Name = name;
            return newBee;
        }
    }
}