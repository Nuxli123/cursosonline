using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursosOnline.Domain;
using CursosOnline.DAL;
using CursosOnline.DataContext;
namespace CursosOnline.DAL.Implementation
{
	public class PagosOpenPayDaoImpl : Abstracts.BaseDaoImpl, PagosOpenPayDao
	{
		public List<PagosOpenPay> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<PagosOpenPay>("dbo.usp_PagosOpenPaySelect @Id={0}", parameters).ToList();
		}

		public PagosOpenPay SelectByKey(PagosOpenPay entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<PagosOpenPay>("dbo.usp_PagosOpenPaySelect @Id={0}", parameters).FirstOrDefault();
		}

		public PagosOpenPay Update(PagosOpenPay entity)
		{
			object[] parameters = new object[] { entity.Id, entity.CursoId, entity.Importe, entity.Autorizacion, entity.Metodo, entity.TipoOperacion, entity.TipoTransaccion, entity.TipoTarjeta, entity.Marca, entity.UltimosDigitos, entity.TarjetaHabiente, entity.Banco, entity.CodigoBancario, entity.Estatus, entity.Token, entity.Fecha, entity.Descripcion, entity.MensajeError, entity.orderId, entity.Tipo };
			return Context.Database.SqlQuery<PagosOpenPay>("dbo.usp_PagosOpenPayUpdate @Id={0}, @CursoId={1}, @Importe={2}, @Autorizacion={3}, @Metodo={4}, @TipoOperacion={5}, @TipoTransaccion={6}, @TipoTarjeta={7}, @Marca={8}, @UltimosDigitos={9}, @TarjetaHabiente={10}, @Banco={11}, @CodigoBancario={12}, @Estatus={13}, @Token={14}, @Fecha={15}, @Descripcion={16}, @MensajeError={17}, @orderId={18}, @Tipo={19}", parameters).FirstOrDefault();
		}

		public PagosOpenPay Insert(PagosOpenPay entity)
		{
			object[] parameters = new object[] { entity.CursoId, entity.Importe, entity.Autorizacion, entity.Metodo, entity.TipoOperacion, entity.TipoTransaccion, entity.TipoTarjeta, entity.Marca, entity.UltimosDigitos, entity.TarjetaHabiente, entity.Banco, entity.CodigoBancario, entity.Estatus, entity.Token, entity.Fecha, entity.Descripcion, entity.MensajeError, entity.orderId, entity.Tipo };
			return Context.Database.SqlQuery<PagosOpenPay>("dbo.usp_PagosOpenPayInsert @CursoId={0}, @Importe={1}, @Autorizacion={2}, @Metodo={3}, @TipoOperacion={4}, @TipoTransaccion={5}, @TipoTarjeta={6}, @Marca={7}, @UltimosDigitos={8}, @TarjetaHabiente={9}, @Banco={10}, @CodigoBancario={11}, @Estatus={12}, @Token={13}, @Fecha={14}, @Descripcion={15}, @MensajeError={16}, @orderId={17}, @Tipo={18}", parameters).FirstOrDefault();
		}

		public bool Delete(PagosOpenPay entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PagosOpenPayDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
