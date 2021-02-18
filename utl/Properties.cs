namespace dot.utl
{
    public class Properties
    {
        private string _name;
        public int Age { private get; set; }
        private double _height;

        public string Name
        {
            get { return _name; }
            set {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        
        public double Height
        {
            get { return _height; }
            set {
                if (value != null)
                {
                    _height = value;
                }
            }
        }
        
        public override string ToString()
        {
            return "Name: " + _name + 
                   " Age " + Age +
                   " Height " + _height;
        }
    }
}