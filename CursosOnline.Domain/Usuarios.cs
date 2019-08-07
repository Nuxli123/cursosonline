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
	[Table("Usuarios")]
	public class Usuarios : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int CodigoActivacionId { get; set; } //(int, not null)
		[Required]
		[StringLength(60)]
		public string Nombre { get; set; } //(nvarchar(60), not null)
		[Required]
		[StringLength(60)]
		public string Paterno { get; set; } //(nvarchar(60), not null)
		[Required]
		[StringLength(60)]
		public string Materno { get; set; } //(nvarchar(60), not null)
		[Required]
		[StringLength(350)]
		public string Email { get; set; } //(nvarchar(350), not null)
		[Required]
		[StringLength(1000)]
		public string Password { get; set; } //(nvarchar(1000), not null)
		[StringLength(41)]
		public string Foto { get; set; } //(nvarchar(41), null)
		[Required]
		public DateTime FechaNacimiento { get; set; } //(datetime, not null)
		[Required]
		public DateTime FechaRegistro { get; set; } //(datetime, not null)
		[Required]
		public bool Bloqueado { get; set; } //(bit, not null)
		[StringLength(128)]
		public string ProviderKey { get; set; } //(nvarchar(128), null)
		[StringLength(128)]
		public string LoginProvider { get; set; } //(nvarchar(128), null)
		[Required]
		[StringLength(10)]
		public string Telefono { get; set; } //(nvarchar(10), not null)
		[Required]
		public bool EmailVerificado { get; set; } //(bit, not null)
		[Required]
		public bool TelefonoVerificado { get; set; } //(bit, not null)
		[Required]
		[StringLength(100)]
		public string Ciudad { get; set; } //(nvarchar(100), not null)
		[Required]
		[StringLength(70)]
		public string Estado { get; set; } //(nvarchar(70), not null)
		[Required]
		[StringLength(300)]
		public string Pais { get; set; } //(nvarchar(300), not null)
		[Required]
		[StringLength(6)]
		public string CodigoPostal { get; set; } //(nvarchar(6), not null)
		[StringLength(13)]
		public string Rfc { get; set; } //(nvarchar(13), null)
		public string Observaciones { get; set; } //(nvarchar(max), null)
		public DateTime FechaUltimaConexion { get; set; } //(datetime, null)
	}
}
