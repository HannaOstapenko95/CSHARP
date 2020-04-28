using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase //Incomplete class that cannot be instantiated. Can be used only like base class. Objects cannot be created. 
    {//At least 1 prop or method should not be realised in class
        //Sealed class - concrete class that cannot be extended by inheritance. Prevents overriding functionality
        //public sealed class Cust { }
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid
        {
            get { return Validate(); }
        }
        /*OR LIKE ABOVE public bool IsValid => Validate();*/
        public abstract bool Validate(); //abstract method
    }
}
