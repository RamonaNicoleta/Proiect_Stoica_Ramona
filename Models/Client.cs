﻿using System.ComponentModel.DataAnnotations;

namespace Proiect_Stoica_Ramona.Models
{
    public class Client
    {

        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage =
"Prenumele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau AnaMaria")]

        [StringLength(30, MinimumLength = 3)]
        public string? FirstName { get; set; }


        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]

        public string? LastName { get; set; }


        [StringLength(70)]

        public string? Adress { get; set; }
        public string Email { get; set; }

        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Telefonul trebuie să fie de forma '0722123123'.")]
        public string? Phone { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public ICollection<Rent>? Rents { get; set; }
    }
}
