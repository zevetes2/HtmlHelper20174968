using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class ContactoViewModel
    {
        [Required]
        [Display(Name = "Cedula")]
        public string cedula { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }
        [Range(15,99,ErrorMessage = "Edad Incorrecta")]
        [Display(Name = "Edad")]
        public int edad { get; set; }
        [Display(Name = "Telefono")]
        public string telefono { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Correo Electronico")]
        public string email { get; set; }
        [Display(Name = "Genero")]
        public Genero genero { get; set; }
        [Display(Name = "Estado Civil")]
        public String estado { get; set; }
        [Display(Name = "Primaria")]
        public bool opcion1 { get; set; }
        [Display(Name = "Secundaria")]
        public bool opcion2 { get; set; }
        [Display(Name = "Tecnica")]
        public bool opcion3 { get; set; }
        [Display(Name = "Superior")]
        public bool opcion4 { get; set; }
    }
    public enum Genero {Vacio, Masculino, Femenino }
}