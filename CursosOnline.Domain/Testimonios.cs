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
	[Table("Testimonios")]
	public class Testimonios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[StringLength(300)]
		public string Nombre { get; set; } //(varchar(300), null)
		[StringLength(600)]
		public string Descripcion { get; set; } //(varchar(600), null)
		[StringLength(400)]
		public string Imagen { get; set; } //(varchar(400), null)
	}
}
