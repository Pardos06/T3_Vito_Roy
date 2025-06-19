using System.ComponentModel.DataAnnotations;

namespace T3_Vito_Roy.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del libro es obligatorio")]
        public string TItulo { get; set; }

        [Required(ErrorMessage = "El nombre del libro es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Agregar Tema obligatorio")]

        public string Tema { get; set; }

        [Required(ErrorMessage = "Agregar Editorial obligatorio")]

        public string Editorial { get; set; }

        [Required(ErrorMessage = "El valor tiene que ser del año 1900-3000")]
        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 
        public DateTime AnioPublicacion { get; set; }

        [Required(ErrorMessage = "Páginas admitidas entre 10 a 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "Agregar categoria obligatorio")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Agregar tipo de material obligatorio")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Número de copias admitidas de 1 a 20")]
        public int Copia { get; set; }
    }
}
