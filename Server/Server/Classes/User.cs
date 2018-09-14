using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Classes
{
    public class User
    {
        private int id;
        private string email;
        private int characterId;
        private string password;
        private string phoneNumber;
        private System.DateTime? lastLogIn;
        private string accessLevelType;


        public User()
        {

        }
        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int CharacterId { get { return characterId; } set { characterId = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public DateTime? LastLogIn { get { return lastLogIn; } set { lastLogIn = value; } }
        public string Access { get { return accessLevelType; } set { accessLevelType = value; } }
    }
}
