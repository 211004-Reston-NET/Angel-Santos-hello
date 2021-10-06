//Sets the house class to be under the HouseFunction namespace
namespace HouseFunction
{
    //public will make this class available for all
    public class House
    {
        //private will make this field belong to just this C# code and nowhere else
        private string owner; 
        private string terminal;
        private string ghost;
        private int roomCount;

        public House()
        {
            owner = "Angel";
            ghost = "Casper";
            roomCount = 1;
        }

        //Creates a property that is attached to a field
        public string TerminalInput { get{return terminal;} set{terminal = value;} }
        public string Owner { get{return owner;} set{owner = value; } }
        public string MiceName { get; set; }
    }
}