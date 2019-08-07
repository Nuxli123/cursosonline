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
	[Table("sysdiagrams")]
	public class sysdiagrams : Base.BaseObjectDomain
	{
		[Required]
		[StringLength(128)]
		public string name { get; set; } //(nvarchar(128), not null)
		[Required]
		public int principal_id { get; set; } //(int, not null)
		[Required]
		[Key, Column(Order=0)]
		public int diagram_id { get; set; } //(int, not null)
		public int version { get; set; } //(int, null)
		public byte[] definition { get; set; } //(varbinary(max), null)
	}
}
