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
	public class OpcionesPreguntasDaoImpl : Abstracts.BaseDaoImpl, OpcionesPreguntasDao
	{
		public List<OpcionesPreguntas> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<OpcionesPreguntas>("dbo.usp_OpcionesPreguntasSelect @Id={0}", parameters).ToList();
		}

		public OpcionesPreguntas SelectByKey(OpcionesPreguntas entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<OpcionesPreguntas>("dbo.usp_OpcionesPreguntasSelect @Id={0}", parameters).FirstOrDefault();
		}

		public OpcionesPreguntas Update(OpcionesPreguntas entity)
		{
			object[] parameters = new object[] { entity.Id, entity.PreguntaId, entity.Descripcion, entity.Orden, entity.Correcta };
			return Context.Database.SqlQuery<OpcionesPreguntas>("dbo.usp_OpcionesPreguntasUpdate @Id={0}, @PreguntaId={1}, @Descripcion={2}, @Orden={3}, @Correcta={4}", parameters).FirstOrDefault();
		}

		public OpcionesPreguntas Insert(OpcionesPreguntas entity)
		{
			object[] parameters = new object[] { entity.PreguntaId, entity.Descripcion, entity.Orden, entity.Correcta };
			return Context.Database.SqlQuery<OpcionesPreguntas>("dbo.usp_OpcionesPreguntasInsert @PreguntaId={0}, @Descripcion={1}, @Orden={2}, @Correcta={3}", parameters).FirstOrDefault();
		}

		public bool Delete(OpcionesPreguntas entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_OpcionesPreguntasDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
