using System;
using CursosOnline.Domain.Base;
namespace CursosOnline.DAL.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Delete operation
	/// </summary>
	public interface IDelete<TEntity> where TEntity : BaseObjectDomain
	{
		bool Delete(TEntity entity);
	}
}
