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
	public class UsuariosDaoImpl : Abstracts.BaseDaoImpl, UsuariosDao
	{
		public List<Usuarios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Usuarios>("dbo.usp_UsuariosSelect @Id={0}", parameters).ToList();
		}

		public Usuarios SelectByKey(Usuarios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<Usuarios>("dbo.usp_UsuariosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Usuarios Update(Usuarios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.CodigoActivacionId, entity.Nombre, entity.Paterno, entity.Materno, entity.Email, entity.Password, entity.Foto, entity.FechaNacimiento, entity.FechaRegistro, entity.Bloqueado, entity.ProviderKey, entity.LoginProvider, entity.Telefono, entity.EmailVerificado, entity.TelefonoVerificado, entity.Ciudad, entity.Estado, entity.Pais, entity.CodigoPostal, entity.Rfc, entity.Observaciones, entity.FechaUltimaConexion };
			return Context.Database.SqlQuery<Usuarios>("dbo.usp_UsuariosUpdate @Id={0}, @CodigoActivacionId={1}, @Nombre={2}, @Paterno={3}, @Materno={4}, @Email={5}, @Password={6}, @Foto={7}, @FechaNacimiento={8}, @FechaRegistro={9}, @Bloqueado={10}, @ProviderKey={11}, @LoginProvider={12}, @Telefono={13}, @EmailVerificado={14}, @TelefonoVerificado={15}, @Ciudad={16}, @Estado={17}, @Pais={18}, @CodigoPostal={19}, @Rfc={20}, @Observaciones={21}, @FechaUltimaConexion={22}", parameters).FirstOrDefault();
		}

		public Usuarios Insert(Usuarios entity)
		{
			object[] parameters = new object[] { entity.CodigoActivacionId, entity.Nombre, entity.Paterno, entity.Materno, entity.Email, entity.Password, entity.Foto, entity.FechaNacimiento, entity.FechaRegistro, entity.Bloqueado, entity.ProviderKey, entity.LoginProvider, entity.Telefono, entity.EmailVerificado, entity.TelefonoVerificado, entity.Ciudad, entity.Estado, entity.Pais, entity.CodigoPostal, entity.Rfc, entity.Observaciones, entity.FechaUltimaConexion };
			return Context.Database.SqlQuery<Usuarios>("dbo.usp_UsuariosInsert @CodigoActivacionId={0}, @Nombre={1}, @Paterno={2}, @Materno={3}, @Email={4}, @Password={5}, @Foto={6}, @FechaNacimiento={7}, @FechaRegistro={8}, @Bloqueado={9}, @ProviderKey={10}, @LoginProvider={11}, @Telefono={12}, @EmailVerificado={13}, @TelefonoVerificado={14}, @Ciudad={15}, @Estado={16}, @Pais={17}, @CodigoPostal={18}, @Rfc={19}, @Observaciones={20}, @FechaUltimaConexion={21}", parameters).FirstOrDefault();
		}

		public bool Delete(Usuarios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_UsuariosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
