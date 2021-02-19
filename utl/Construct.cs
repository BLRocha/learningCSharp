namespace dot.utl
{
    public class Construct
    {
        public string Name;
        public uint Age;
        public double Height;
    
        public Construct() {
            Name = "vazio|void";
        }
        public Construct(string name, uint age, double height) {
            Name = name;
            Age = age;
            Height = height;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" +
                   "Age: " + Age + "\n" +
                   "Height: " + Height;
        }
    }
}