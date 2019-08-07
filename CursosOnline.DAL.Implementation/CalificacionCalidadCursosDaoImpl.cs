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
	public class CalificacionCalidadCursosDaoImpl : Abstracts.BaseDaoImpl, CalificacionCalidadCursosDao
	{
		public List<CalificacionCalidadCursos> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<CalificacionCalidadCursos>("dbo.usp_CalificacionCalidadCursosSelect @Id={0}", parameters).ToList();
		}

		public CalificacionCalidadCursos SelectByKey(CalificacionCalidadCursos entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<CalificacionCalidadCursos>("dbo.usp_CalificacionCalidadCursosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public CalificacionCalidadCursos Update(CalificacionCalidadCursos entity)
		{
			object[] parameters = new object[] { entity.Id, entity.CursoId, entity.UsuarioId, entity.Calificacion, entity.FechaRegistro };
			return Context.Database.SqlQuery<CalificacionCalidadCursos>("dbo.usp_CalificacionCalidadCursosUpdate @Id={0}, @CursoId={1}, @UsuarioId={2}, @Calificacion={3}, @FechaRegistro={4}", parameters).FirstOrDefault();
		}

		public CalificacionCalidadCursos Insert(CalificacionCalidadCursos entity)
		{
			object[] parameters = new object[] { entity.CursoId, entity.UsuarioId, entity.Calificacion, entity.FechaRegistro };
			return Context.Database.SqlQuery<CalificacionCalidadCursos>("dbo.usp_CalificacionCalidadCursosInsert @CursoId={0}, @UsuarioId={1}, @Calificacion={2}, @FechaRegistro={3}", parameters).FirstOrDefault();
		}

		public bool Delete(CalificacionCalidadCursos entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_CalificacionCalidadCursosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
