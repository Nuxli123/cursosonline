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
	public class RespuestasServiceController : ApiController
	{
		[HttpGet]
		public List<Respuestas> GetAll()
		{
		RespuestasBo RespuestasBo = new RespuestasBo();
		return RespuestasBo.GetAll();
		}
		[HttpGet]
		public Respuestas GetOne(int Id)
		{
		RespuestasBo RespuestasBo = new RespuestasBo();
		Respuestas entity = new Respuestas() { Id = Id };
		return RespuestasBo.SelectByKey(entity);
		}
		[HttpPost]
		public Respuestas New(Respuestas entity)
		{
		RespuestasBo RespuestasBo = new RespuestasBo();
		return RespuestasBo.Insert(entity);
		}
		[HttpPut]
		public Respuestas Update(Respuestas entity)
		{
		RespuestasBo RespuestasBo = new RespuestasBo();
		return RespuestasBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		RespuestasBo RespuestasBo = new RespuestasBo();
		Respuestas entity = new Respuestas() { Id = Id };
		return RespuestasBo.Delete(entity);
		}
	}
}
