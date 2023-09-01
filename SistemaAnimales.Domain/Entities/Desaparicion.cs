using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAnimales.Domain.Entities
{
    public class Desaparicion
    {
        [Column("idDesaparicion")]
        [Required]
        [Key]
        public int IdDesaparicion { get; set; }

        //Por medio de este usuario se publicara

        [Column("idUsuario")]
        [Required]
        [StringLength(maximumLength: 20)]
        public string IdUsuario{ get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string NombreAnimal { get; set; }

        [Column("foto")]
        [Required]
        [StringLength(maximumLength: 300)]
        public string Foto { get; set; }

        [Column("fecha")]
        [Required]
        public DateTime FechaDesaparicion { get; set; }

        [Column("edad")]
        [Required]
        public int Edad { get; set; }

        [Column("contacto")]
        [Required]
        [StringLength(maximumLength: 20)]
        public string Contacto { get; set; }

        [Column("otros")]
        [Required]
        [StringLength(maximumLength: 150)]
        public string Otros { get; set; }

        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }
    }
}
