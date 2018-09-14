using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Classes
{
    public class CharacterProperty
    {
        private int id;
        private DateTime date;
        private string status;
        private string name;
        private byte[] value;
        private string type;
        private Character character;

        public DateTime Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
        public byte[] Value { get => value; set => this.value = value; }
        public string Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }
        internal Character Character { get => character; set => character = value; }
    }
}
