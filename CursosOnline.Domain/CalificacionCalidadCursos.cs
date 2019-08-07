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
	[Table("CalificacionCalidadCursos")]
	public class CalificacionCalidadCursos : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int CursoId { get; set; } //(int, not null)
		public int UsuarioId { get; set; } //(int, null)
		[Required]
		public decimal Calificacion { get; set; } //(decimal(18,2), not null)
		public DateTime FechaRegistro { get; set; } //(datetime, null)
	}
}
