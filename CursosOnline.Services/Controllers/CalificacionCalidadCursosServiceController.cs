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
	public class CalificacionCalidadCursosServiceController : ApiController
	{
		[HttpGet]
		public List<CalificacionCalidadCursos> GetAll()
		{
		CalificacionCalidadCursosBo CalificacionCalidadCursosBo = new CalificacionCalidadCursosBo();
		return CalificacionCalidadCursosBo.GetAll();
		}
		[HttpGet]
		public CalificacionCalidadCursos GetOne(int Id)
		{
		CalificacionCalidadCursosBo CalificacionCalidadCursosBo = new CalificacionCalidadCursosBo();
		CalificacionCalidadCursos entity = new CalificacionCalidadCursos() { Id = Id };
		return CalificacionCalidadCursosBo.SelectByKey(entity);
		}
		[HttpPost]
		public CalificacionCalidadCursos New(CalificacionCalidadCursos entity)
		{
		CalificacionCalidadCursosBo CalificacionCalidadCursosBo = new CalificacionCalidadCursosBo();
		return CalificacionCalidadCursosBo.Insert(entity);
		}
		[HttpPut]
		public CalificacionCalidadCursos Update(CalificacionCalidadCursos entity)
		{
		CalificacionCalidadCursosBo CalificacionCalidadCursosBo = new CalificacionCalidadCursosBo();
		return CalificacionCalidadCursosBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		CalificacionCalidadCursosBo CalificacionCalidadCursosBo = new CalificacionCalidadCursosBo();
		CalificacionCalidadCursos entity = new CalificacionCalidadCursos() { Id = Id };
		return CalificacionCalidadCursosBo.Delete(entity);
		}
	}
}
