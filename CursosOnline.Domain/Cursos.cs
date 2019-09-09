using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursosOnline.Domain
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Clase de datos
	/// </summary>
	[Table("Cursos")]
	public class Cursos : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[StringLength(1000)]
		public string Nombre { get; set; } //(varchar(1000), null)
		[StringLength(400)]
		public string Icono { get; set; } //(varchar(400), null)
		[StringLength(10)]
		public string Color { get; set; } //(varchar(10), null)
		[StringLength(150)]
		public string Instructor { get; set; } //(varchar(150), null)
        public string ImagenPortada { get; set; }
        public string Descripcion { get; set; }
        public decimal Duracion { get; set; }
        public decimal Precio { get; set; }

	}
}
