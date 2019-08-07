using System;
using CursosOnline.DataContext;
namespace CursosOnline.DAL.Implementation.Abstracts
{
	public abstract class BaseDaoImpl : IDisposable
	{
		DataContext.DataContext context = new DataContext.DataContext();
		public void Dispose()
		{
			if (context != null)
			{
				context.Dispose();
				context = null;
			}
		}
		public DataContext.DataContext Context
		{
			get { return context; }
		}
	}
}
