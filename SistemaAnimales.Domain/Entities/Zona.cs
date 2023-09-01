using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAnimales.Domain.Entities
{
    public class Zona
    {
        [Column("idZona")]
        [Required]
        [Key]
        public int IdZona { get; set; }

        [Column("pais")]
        [Required]
        [StringLength(maximumLength: 40)]
        public string Pais { get; set; }

        [Column("departamento")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string Departamento { get; set; }

        //[Column("eliminado")]
        //[DefaultValue(0)]
        //public bool Eliminado { get; set; }
    }
}
