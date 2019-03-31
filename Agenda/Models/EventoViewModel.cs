using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class EventoViewModel
    {
        public int id_evento { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Evento")]
        public string nombre_evento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha del Evento")]
        public DateTime fecha { get; set; }
        [Required]
        [Display(Name = "Lugar del Evento")]
        public string lugar { get; set; }
        public string fe { get; set; }
    }
}