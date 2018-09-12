using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Classes
{
    class Character
    {

        //fields
 
        private int id;
      
        private string nationality;
    
        private string birthCountry;
   
        private string deathCountry;
     
        private string livingCountry;
      
        private string birthPlace;
       
        private string deathPlace;
     
        private string livingPlace;
   
        private string religion;
 
        private string firstName;
 
        private string secondName;
  
        private string lastName;
    
        private string biography;
      
        private string photo;

        private System.DateTime? birthDate;
     
        private System.DateTime? deathDate;

        //properties

        public int Id { get => id; set => id = value; }

        public string Nationality { get => nationality; set => nationality = value; }

        public string BirthCountry { get => birthCountry; set => birthCountry = value; }

        public string DeathCountry { get => deathCountry; set => deathCountry = value; }

        public string LivingCountry { get => livingCountry; set => livingCountry = value; }

        public string BirthPlace { get => birthPlace; set => birthPlace = value; }

        public string DeathPlace { get => deathPlace; set => deathPlace = value; }

        public string LivingPlace { get => livingPlace; set => livingPlace = value; }

        public string Religion { get => religion; set => religion = value; }

        public string FirstName { get => firstName; set => firstName = value; }

        public string SecondName { get => secondName; set => secondName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public string Biography { get => biography; set => biography = value; }

        public string Photo { get => photo; set => photo = value; }

        public DateTime? BirthDate { get => birthDate; set => birthDate = value; }

        public DateTime? DeathDate { get => deathDate; set => deathDate = value; }

        //methods

        //ConstrByDefault

        public Character()
        {

        }

        //CopyConstr

        public Character(Character chr)
        {
            this.id                 = chr.Id                    ;
            this.nationality        = chr.Nationality           ;
            this.birthCountry       = chr.BirthCountry          ;
            this.deathCountry       = chr.DeathCountry          ;
            this.livingCountry      = chr.LivingCountry         ;
            this.birthPlace         = chr.BirthPlace            ;
            this.deathPlace         = chr.DeathPlace            ;
            this.livingPlace        = chr.LivingPlace           ;
            this.religion          = chr.Religion             ;
            this.firstName          = chr.FirstName             ;
            this.secondName         = chr.SecondName            ;
            this.lastName           = chr.LastName              ;
            this.birthDate          = chr.BirthDate             ;
            this.deathDate          = chr.DeathDate             ;
            this.biography          = chr.Biography             ;
            this.photo              = chr.Photo                 ;
        }

        //ConstrWithParams

        public Character(int id, string nationality, string birthCountry, string deathCountry, string livingCountry, string birthPlace, string deathPlace, string livingPlace, string religious, string firstName, string secondName, string lastName, string biography, string photo, DateTime birthDate, DateTime deathDate)
        {
            this.id = id;
            this.nationality = nationality;
            this.birthCountry = birthCountry;
            this.deathCountry = deathCountry;
            this.livingCountry = livingCountry;
            this.birthPlace = birthPlace;
            this.deathPlace = deathPlace;
            this.livingPlace = livingPlace;
            this.religion = religious;
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.biography = biography;
            this.photo = photo;
        }
    }
}
