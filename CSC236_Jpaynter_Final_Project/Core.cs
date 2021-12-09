using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_Jpaynter_Final_Project
{
    // TODO: Create an interface and an array of allowed users of the home
    // TODO: Add an GUI to the design to allow the user to add and delete the users

    interface ProfileActions
    {
        string getName();
        string getRelationship();
        string getAge();

        void setName(string name);
        void setRelationship(string realationship);
        void setAge(string age);
    }

    public struct user : ProfileActions
    {
        string name;
        string relationship;
        string age;

        public string getAge()
        {
            return age;
        }

        public string getName()
        {
            return name;
        }

        public string getRelationship()
        {
            return relationship;
        }

        public void setAge(string age)
        {
            this.age = age;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setRelationship(string relationship)
        {
            this.relationship = relationship;
        }
    }


    /// <summary>
    /// The Core class is the brain of the smart home application. This class manages the state of all home components
    /// This is a singleton design pattern to prevent multiple instances of this object. 
    /// Every Form using the Core class will be using the same instance. 
    /// This ensures the information between the forms is the same;
    /// </summary>
    public sealed class Core
    {
        private static Core instance = null;
        private static readonly object padlock = new object();
        private List<user> users = new List<user>();
        public event EventHandler UserChanged; // Delegate declared

        //Constructor
        Core()
        {
            frontDoor = false;
            backDoor = false;
            garageDoor = false;
            kitchenLights = false;
            familyRoomLights = false;
            masterBedroomLight = false;
            bedroomLightOne = false;
        }
        // Constructor for subclass to extend?
        protected Core(int number)
        {

        }

        public static Core Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Core();
                    }
                    return instance;
                }
            }
        }



        /************************************************
         * Public Getters and Setters for all attributes:
         ************************************************/
        public List<user> getUsers()   
        {
            return this.users;
        }

        public bool frontDoor
        {
            get; set;
        }
        public bool backDoor
        {
            get; set;
        }

        public bool garageDoor
        {
            get; set;
        }
        public bool kitchenLights
        {
            get; set;
        }
        public bool familyRoomLights
        {
            get; set;
        }

        public bool bedroomLightOne
        {
            get; set;
        }

        public bool masterBedroomLight
        {
            get; set;
        }

        /************************************************
         ************************************************/


        /************************************************
         * API to interact with the List of users:
         ************************************************/
        public void createNewUser(string name, string relationship, string age)
        {
            user newUser = new user();
            newUser.setName(name);
            newUser.setRelationship(relationship);
            newUser.setAge(age);
            this.users.Add(newUser);
            OnUserChange(EventArgs.Empty);
        }

        public void removeUser(int index)
        {
            for (int user = 0; user < this.users.Count; user++)
            {
                if (user == index)
                {
                    users.Remove(this.users[index]);
                }
            }
        }

        // OnUserChanged is an event handler with only one argument
        public void OnUserChange(EventArgs e)
        {
            UserChanged(this, e);
        }

        /************************************************
         ************************************************/


        
        // TODO: Create a Logging Delegate. See previous assignment. Log the current time and status when something is switched
    }
}