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
	public class PreguntasServiceController : ApiController
	{
		[HttpGet]
		public List<Preguntas> GetAll()
		{
		PreguntasBo PreguntasBo = new PreguntasBo();
		return PreguntasBo.GetAll();
		}
		[HttpGet]
		public Preguntas GetOne(int Id)
		{
		PreguntasBo PreguntasBo = new PreguntasBo();
		Preguntas entity = new Preguntas() { Id = Id };
		return PreguntasBo.SelectByKey(entity);
		}
		[HttpPost]
		public Preguntas New(Preguntas entity)
		{
		PreguntasBo PreguntasBo = new PreguntasBo();
		return PreguntasBo.Insert(entity);
		}
		[HttpPut]
		public Preguntas Update(Preguntas entity)
		{
		PreguntasBo PreguntasBo = new PreguntasBo();
		return PreguntasBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		PreguntasBo PreguntasBo = new PreguntasBo();
		Preguntas entity = new Preguntas() { Id = Id };
		return PreguntasBo.Delete(entity);
		}
	}
}
