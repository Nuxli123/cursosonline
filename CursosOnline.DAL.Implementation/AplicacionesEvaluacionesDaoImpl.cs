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
	public class AplicacionesEvaluacionesDaoImpl : Abstracts.BaseDaoImpl, AplicacionesEvaluacionesDao
	{
		public List<AplicacionesEvaluaciones> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<AplicacionesEvaluaciones>("dbo.usp_AplicacionesEvaluacionesSelect @Id={0}", parameters).ToList();
		}

		public AplicacionesEvaluaciones SelectByKey(AplicacionesEvaluaciones entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<AplicacionesEvaluaciones>("dbo.usp_AplicacionesEvaluacionesSelect @Id={0}", parameters).FirstOrDefault();
		}

		public AplicacionesEvaluaciones Update(AplicacionesEvaluaciones entity)
		{
			object[] parameters = new object[] { entity.Id, entity.UsuarioId, entity.CursoId, entity.Resultado, entity.FechaRegistro };
			return Context.Database.SqlQuery<AplicacionesEvaluaciones>("dbo.usp_AplicacionesEvaluacionesUpdate @Id={0}, @UsuarioId={1}, @CursoId={2}, @Resultado={3}, @FechaRegistro={4}", parameters).FirstOrDefault();
		}

		public AplicacionesEvaluaciones Insert(AplicacionesEvaluaciones entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.CursoId, entity.Resultado, entity.FechaRegistro };
			return Context.Database.SqlQuery<AplicacionesEvaluaciones>("dbo.usp_AplicacionesEvaluacionesInsert @UsuarioId={0}, @CursoId={1}, @Resultado={2}, @FechaRegistro={3}", parameters).FirstOrDefault();
		}

		public bool Delete(AplicacionesEvaluaciones entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_AplicacionesEvaluacionesDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
