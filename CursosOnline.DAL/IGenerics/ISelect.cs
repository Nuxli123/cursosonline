using System;
using System.Collections.Generic;
using CursosOnline.Domain.Base;
namespace CursosOnline.DAL.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Update operation
	/// </summary>
	public interface ISelect<TEntity> where TEntity : BaseObjectDomain
	{
		List<TEntity> SelectAll();
		TEntity SelectByKey(TEntity entity);
	}
}
