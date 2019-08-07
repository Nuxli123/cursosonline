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
	public class CursosServiceController : ApiController
	{
		[HttpGet]
		public List<Cursos> GetAll()
		{
		CursosBo CursosBo = new CursosBo();
		return CursosBo.GetAll();
		}
		[HttpGet]
		public Cursos GetOne(int Id)
		{
		CursosBo CursosBo = new CursosBo();
		Cursos entity = new Cursos() { Id = Id };
		return CursosBo.SelectByKey(entity);
		}
		[HttpPost]
		public Cursos New(Cursos entity)
		{
		CursosBo CursosBo = new CursosBo();
		return CursosBo.Insert(entity);
		}
		[HttpPut]
		public Cursos Update(Cursos entity)
		{
		CursosBo CursosBo = new CursosBo();
		return CursosBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		CursosBo CursosBo = new CursosBo();
		Cursos entity = new Cursos() { Id = Id };
		return CursosBo.Delete(entity);
		}
	}
}
