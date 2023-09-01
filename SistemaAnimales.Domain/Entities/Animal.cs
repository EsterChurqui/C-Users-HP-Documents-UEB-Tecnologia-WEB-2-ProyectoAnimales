using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAnimales.Domain.Entities
{
    public class Animal
    {
        [Column("idAnimal")]
        [Required]
        [Key]
        public int IdAnimal { get; set; }


        [Column("nombreAnimal")]
        [Required]
        [StringLength(maximumLength: 50)]
        public string NombreAnimal { get; set; }

        [Column("foto")]
        [Required]
        [StringLength(maximumLength: 300)]
        public string Foto { get; set; }

        [Column("especie")]
        [Required]
        [StringLength(maximumLength: 50)]
        public string Especie { get; set; }

        [Column("edad")]
        [Required]
        public int Edad { get; set; }

        [Column("genero")]
        [Required]
        [StringLength(maximumLength: 10)]
        public string Genero { get; set; }


        [Column("descripcion")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string Descripcion { get; set; }

        [Column("estado")]
        [Required]
        [StringLength(maximumLength: 30)]
        public string Estado { get; set; }

        //Llamando a Refugio

        [Column("idRefugio")]
        [Required]
        public int IdRefugio { get; set; }

        public virtual Refugio refugio { get; set; }

        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }



    }
}
