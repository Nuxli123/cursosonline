using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CursosOnline.Business;
using CursosOnline.Domain;
namespace CursosOnline.Services
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Clase de servicio Restful que soporta CRUD
	/// </summary>
	public class PagosOpenPayServiceController : ApiController
	{
		[HttpGet]
		public List<PagosOpenPay> GetAll()
		{
		PagosOpenPayBo PagosOpenPayBo = new PagosOpenPayBo();
		return PagosOpenPayBo.GetAll();
		}
		[HttpGet]
		public PagosOpenPay GetOne(int Id)
		{
		PagosOpenPayBo PagosOpenPayBo = new PagosOpenPayBo();
		PagosOpenPay entity = new PagosOpenPay() { Id = Id };
		return PagosOpenPayBo.SelectByKey(entity);
		}
		[HttpPost]
		public PagosOpenPay New(PagosOpenPay entity)
		{
		PagosOpenPayBo PagosOpenPayBo = new PagosOpenPayBo();
		return PagosOpenPayBo.Insert(entity);
		}
		[HttpPut]
		public PagosOpenPay Update(PagosOpenPay entity)
		{
		PagosOpenPayBo PagosOpenPayBo = new PagosOpenPayBo();
		return PagosOpenPayBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		PagosOpenPayBo PagosOpenPayBo = new PagosOpenPayBo();
		PagosOpenPay entity = new PagosOpenPay() { Id = Id };
		return PagosOpenPayBo.Delete(entity);
		}
	}
}
