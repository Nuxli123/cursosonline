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
	[Table("Preguntas")]
	public class Preguntas : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		public int CursoId { get; set; } //(int, null)
		[Required]
		public int Numero { get; set; } //(int, not null)
		[Required]
		[StringLength(2000)]
		public string Descripcion { get; set; } //(varchar(2000), not null)
	}
}
