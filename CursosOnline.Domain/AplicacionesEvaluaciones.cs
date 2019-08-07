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
	[Table("AplicacionesEvaluaciones")]
	public class AplicacionesEvaluaciones : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int UsuarioId { get; set; } //(int, not null)
		[Required]
		public int CursoId { get; set; } //(int, not null)
		public decimal Resultado { get; set; } //(decimal(4,2), null)
		[Required]
		public DateTime FechaRegistro { get; set; } //(datetime, not null)
	}
}
