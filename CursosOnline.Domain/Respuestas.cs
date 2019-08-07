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
	[Table("Respuestas")]
	public class Respuestas : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int PreguntaId { get; set; } //(int, not null)
		[Required]
		public int AplicacionEvaluacionId { get; set; } //(int, not null)
		[Required]
		public int OpcionId { get; set; } //(int, not null)
		[Required]
		public bool Correcta { get; set; } //(bit, not null)
		public DateTime FechaRegistro { get; set; } //(datetime, null)
	}
}
