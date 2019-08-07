using CursosOnline.Domain;
using CursosOnline.DAL.Implementation;
namespace CursosOnline.Business
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Clase de negocio que hereda del CRUD
	/// </summary>
	public class TestimoniosBo : Base.CrudBase<Testimonios, TestimoniosDaoImpl>
	{
	}
}
