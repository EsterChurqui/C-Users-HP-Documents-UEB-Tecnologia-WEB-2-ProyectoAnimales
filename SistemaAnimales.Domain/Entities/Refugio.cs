using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SistemaAnimales.Domain.Entities
{
    public class Refugio
    {

        [Column("idRefugio")]
        [Required]
        [Key]
        public int IdRefugio { get; set; }

        //Por medio de este usuario se publicara

        [Column("idUsuario")]
        [Required]
        [StringLength(maximumLength: 20)]
        public string IdUsuario { get; set; }


        [Column("nombre")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string NombreRefugio { get; set; }

        [Column("foto")]
        [Required]
        [StringLength(maximumLength: 300)]
        public string Foto { get; set; }

        [Column("direccion")]
        [Required]
        [StringLength(maximumLength: 200)]
        public string Direccion { get; set; }


        [Column("telefono")]
        [Required]
        public int Telefono{ get; set; }

        [Column("correoElectronico")]
        [Required]
        [StringLength(maximumLength: 30)]
        public string CorreoElectronico { get; set; }

        [Column("presentacion")]
        [Required]
        [StringLength(maximumLength: 300)]
        public string Presentacion { get; set; }

        //Llamando a la Zona

        [Column("idZona")]
        [Required]
        public int IdZona { get; set; }

        public virtual Zona zona { get; set; }

     // Los animales que estaran en el refugio

        public virtual ICollection<Animal> Animales { get; set; }

        //*********************************************************

        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }
    }
}
