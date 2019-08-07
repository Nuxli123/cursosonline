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
	public class TestimoniosDaoImpl : Abstracts.BaseDaoImpl, TestimoniosDao
	{
		public List<Testimonios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Testimonios>("dbo.usp_TestimoniosSelect @Id={0}", parameters).ToList();
		}

		public Testimonios SelectByKey(Testimonios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<Testimonios>("dbo.usp_TestimoniosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Testimonios Update(Testimonios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.Nombre, entity.Descripcion, entity.Imagen };
			return Context.Database.SqlQuery<Testimonios>("dbo.usp_TestimoniosUpdate @Id={0}, @Nombre={1}, @Descripcion={2}, @Imagen={3}", parameters).FirstOrDefault();
		}

		public Testimonios Insert(Testimonios entity)
		{
			object[] parameters = new object[] { entity.Nombre, entity.Descripcion, entity.Imagen };
			return Context.Database.SqlQuery<Testimonios>("dbo.usp_TestimoniosInsert @Nombre={0}, @Descripcion={1}, @Imagen={2}", parameters).FirstOrDefault();
		}

		public bool Delete(Testimonios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_TestimoniosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
