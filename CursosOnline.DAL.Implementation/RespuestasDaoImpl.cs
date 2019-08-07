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
	public class RespuestasDaoImpl : Abstracts.BaseDaoImpl, RespuestasDao
	{
		public List<Respuestas> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Respuestas>("dbo.usp_RespuestasSelect @Id={0}", parameters).ToList();
		}

		public Respuestas SelectByKey(Respuestas entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<Respuestas>("dbo.usp_RespuestasSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Respuestas Update(Respuestas entity)
		{
			object[] parameters = new object[] { entity.Id, entity.PreguntaId, entity.AplicacionEvaluacionId, entity.OpcionId, entity.Correcta, entity.FechaRegistro };
			return Context.Database.SqlQuery<Respuestas>("dbo.usp_RespuestasUpdate @Id={0}, @PreguntaId={1}, @AplicacionEvaluacionId={2}, @OpcionId={3}, @Correcta={4}, @FechaRegistro={5}", parameters).FirstOrDefault();
		}

		public Respuestas Insert(Respuestas entity)
		{
			object[] parameters = new object[] { entity.PreguntaId, entity.AplicacionEvaluacionId, entity.OpcionId, entity.Correcta, entity.FechaRegistro };
			return Context.Database.SqlQuery<Respuestas>("dbo.usp_RespuestasInsert @PreguntaId={0}, @AplicacionEvaluacionId={1}, @OpcionId={2}, @Correcta={3}, @FechaRegistro={4}", parameters).FirstOrDefault();
		}

		public bool Delete(Respuestas entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_RespuestasDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
