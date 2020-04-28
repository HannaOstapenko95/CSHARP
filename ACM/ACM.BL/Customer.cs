using System;
using Acme.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //Types of relationship: Collaboration (uses a) (Product -> Product repository (provide services to class); 
        //Composition (has a) (Customer -> Adress) -> adding properties to class. Object from one class is constructed from objects from another classes
        //: Aggredation classes are related, but independent
        //Composition: by object properties or by using IDs(reduces coupling)
        //Composition (has a); Inheritance (is a) - for creating more specific types: Parent/base class, child/derived class
        //Class can have only one parent class. Any number of inheritance levels
        /*public Address WorkAddress { get; set; }
        public Address HomeAddress { get; set; } OR:*/
        public List<Address> AddressList { get; set; } //Composition (has a relationship)
        public Customer() : this(0) //Constructor chaining (1 const calls another) //snippet for Constructor = ctor TAB TAB. If no parameters - default constructor. No need to write it.
        { //Default constructor calls parametrized constructor

        }
        public Customer(int customerId) // Constructor. Overloading
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        //3 layers - UI, Business logic, Data access. Common library. Solution - application, project - for a layer(business logic)
        public int CustomerId { get; private set; } //propg - TAB TAB //snippets
        public int CustomerType { get; set; }
        public string FirstName { get; set; } //auto-implemented property. No need of backing field. prop -TAB TAB
        public string EmailAddress { get; set; } //Insert Snippet prop
        private string _lastName; //backing field
        public string LastName //property
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        /* public string Log()
         {
             var logString = CustomerId + ": " +
                 FullName + " " +
                 "Email: " + EmailAddress + " " +
                 "Status: " + EntityState.ToString();
             return logString;
         }THE SAME*/
        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        public override string ToString() => FullName;
        public string FullName //propfull - TAB TAB. No need backing field because it is not returned
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; } //static modifier for all object instances. Property belongs to a class, but not to an instance of class/exact object
        
        //Validates the customer data
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
        //Methods extracted to Customer Repository
       /* //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        //Saves the current customer
        public bool Save()
        {
            return true;
        }
        //Retrieve all customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }*/
    }
}
