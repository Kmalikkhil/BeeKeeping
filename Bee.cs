namespace BeeKeeping
{
    public class Bee
    {
        
        public string Name;
        public float Size;


        public Bee () {
            this.Name = "";
            this.Size = 0;
        }

        public Bee (string name, float size){
            this.Name = name;
            this.Size = size;
        }

        public float getBeeSize(){
            return this.Size;
        }

    }
}