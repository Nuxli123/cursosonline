using System;
using System.Collections.Generic;
using CursosOnline.Domain.Base;
namespace CursosOnline.Business.Base
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Clase de negocio
	/// </summary>
	public interface ICrudBase<TEntity> where TEntity : BaseObjectDomain
	{
		List<TEntity> GetAll();
		TEntity Insert(TEntity entity);
		TEntity Update(TEntity entity);
		bool Delete(TEntity entity);
		TEntity SelectByKey(TEntity entity);
	}
}
