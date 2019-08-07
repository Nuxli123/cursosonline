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
	[Table("PagosOpenPay")]
	public class PagosOpenPay : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int Id { get; set; } //(int, not null)
		[Required]
		public int CursoId { get; set; } //(int, not null)
		[Required]
		[DataType(DataType.Currency)]
		public decimal Importe { get; set; } //(money, not null)
		[StringLength(15)]
		public string Autorizacion { get; set; } //(varchar(15), null)
		[StringLength(15)]
		public string Metodo { get; set; } //(varchar(15), null)
		[StringLength(15)]
		public string TipoOperacion { get; set; } //(varchar(15), null)
		[StringLength(15)]
		public string TipoTransaccion { get; set; } //(varchar(15), null)
		[StringLength(15)]
		public string TipoTarjeta { get; set; } //(varchar(15), null)
		[StringLength(10)]
		public string Marca { get; set; } //(varchar(10), null)
		[StringLength(4)]
		public string UltimosDigitos { get; set; } //(varchar(4), null)
		[StringLength(16)]
		public string TarjetaHabiente { get; set; } //(varchar(16), null)
		[StringLength(30)]
		public string Banco { get; set; } //(varchar(30), null)
		[StringLength(3)]
		public string CodigoBancario { get; set; } //(varchar(3), null)
		[StringLength(10)]
		public string Estatus { get; set; } //(varchar(10), null)
		[StringLength(250)]
		public string Token { get; set; } //(varchar(250), null)
		public DateTime Fecha { get; set; } //(datetime, null)
		[StringLength(200)]
		public string Descripcion { get; set; } //(varchar(200), null)
		[StringLength(150)]
		public string MensajeError { get; set; } //(varchar(150), null)
		[StringLength(10)]
		public string orderId { get; set; } //(varchar(10), null)
		[StringLength(18)]
		public string Tipo { get; set; } //(varchar(18), null)
	}
}
