using CollectionsAndExceptions.Exceptions;

namespace CollectionsAndExceptions.Classes
{
    public class Element : ICloneable
    {
        public int? PeriodicNumber { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public object Clone() => MemberwiseClone();

        /*public bool Check()
        {
            if(PeriodicNumber is null || 
               PeriodicNumber < 1 || 
               Name.Length < 5 || 
               Symbol.Length < 2) return false;

            return true;
        }*/
        public void Check()
        {
            if (PeriodicNumber is null ||
               PeriodicNumber < 1 ||
               Name.Length < 5 ||
               Symbol.Length < 2)
                throw new ElementException(this, "Invalid property value");
               //throw new ArgumentException("Invalid property value");
        }
    }
}

