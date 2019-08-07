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
	public class AplicacionesEvaluacionesServiceController : ApiController
	{
		[HttpGet]
		public List<AplicacionesEvaluaciones> GetAll()
		{
		AplicacionesEvaluacionesBo AplicacionesEvaluacionesBo = new AplicacionesEvaluacionesBo();
		return AplicacionesEvaluacionesBo.GetAll();
		}
		[HttpGet]
		public AplicacionesEvaluaciones GetOne(int Id)
		{
		AplicacionesEvaluacionesBo AplicacionesEvaluacionesBo = new AplicacionesEvaluacionesBo();
		AplicacionesEvaluaciones entity = new AplicacionesEvaluaciones() { Id = Id };
		return AplicacionesEvaluacionesBo.SelectByKey(entity);
		}
		[HttpPost]
		public AplicacionesEvaluaciones New(AplicacionesEvaluaciones entity)
		{
		AplicacionesEvaluacionesBo AplicacionesEvaluacionesBo = new AplicacionesEvaluacionesBo();
		return AplicacionesEvaluacionesBo.Insert(entity);
		}
		[HttpPut]
		public AplicacionesEvaluaciones Update(AplicacionesEvaluaciones entity)
		{
		AplicacionesEvaluacionesBo AplicacionesEvaluacionesBo = new AplicacionesEvaluacionesBo();
		return AplicacionesEvaluacionesBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		AplicacionesEvaluacionesBo AplicacionesEvaluacionesBo = new AplicacionesEvaluacionesBo();
		AplicacionesEvaluaciones entity = new AplicacionesEvaluaciones() { Id = Id };
		return AplicacionesEvaluacionesBo.Delete(entity);
		}
	}
}
