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
	public class OpcionesPreguntasServiceController : ApiController
	{
		[HttpGet]
		public List<OpcionesPreguntas> GetAll()
		{
		OpcionesPreguntasBo OpcionesPreguntasBo = new OpcionesPreguntasBo();
		return OpcionesPreguntasBo.GetAll();
		}
		[HttpGet]
		public OpcionesPreguntas GetOne(int Id)
		{
		OpcionesPreguntasBo OpcionesPreguntasBo = new OpcionesPreguntasBo();
		OpcionesPreguntas entity = new OpcionesPreguntas() { Id = Id };
		return OpcionesPreguntasBo.SelectByKey(entity);
		}
		[HttpPost]
		public OpcionesPreguntas New(OpcionesPreguntas entity)
		{
		OpcionesPreguntasBo OpcionesPreguntasBo = new OpcionesPreguntasBo();
		return OpcionesPreguntasBo.Insert(entity);
		}
		[HttpPut]
		public OpcionesPreguntas Update(OpcionesPreguntas entity)
		{
		OpcionesPreguntasBo OpcionesPreguntasBo = new OpcionesPreguntasBo();
		return OpcionesPreguntasBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		OpcionesPreguntasBo OpcionesPreguntasBo = new OpcionesPreguntasBo();
		OpcionesPreguntas entity = new OpcionesPreguntas() { Id = Id };
		return OpcionesPreguntasBo.Delete(entity);
		}
	}
}
