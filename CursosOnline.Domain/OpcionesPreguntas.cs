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
	[Table("OpcionesPreguntas")]
	public class OpcionesPreguntas : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int PreguntaId { get; set; } //(int, not null)
		[Required]
		[StringLength(2000)]
		public string Descripcion { get; set; } //(varchar(2000), not null)
		[Required]
		public int Orden { get; set; } //(int, not null)
		[Required]
		public bool Correcta { get; set; } //(bit, not null)
	}
}
