USE [CursosIndustrial];
GO

/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_CursosSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CursosSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[Cursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CursosSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [Nombre], [Icono], [Color], [Instructor]
	FROM [dbo].[Cursos]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_CursosInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CursosInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[Cursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CursosInsert]
		@Nombre varchar(1000),
		@Icono varchar(400),
		@Color varchar(10),
		@Instructor varchar(150)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[Cursos] ([Nombre], [Icono], [Color], [Instructor])
	SELECT @Nombre, @Icono, @Color, @Instructor

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [Nombre], [Icono], [Color], [Instructor]
	FROM [dbo].[Cursos]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_CursosUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CursosUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[Cursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CursosUpdate]
		@Id int,
		@Nombre varchar(1000),
		@Icono varchar(400),
		@Color varchar(10),
		@Instructor varchar(150)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[Cursos]
	SET [Nombre] = @Nombre, [Icono] = @Icono, [Color] = @Color, [Instructor] = @Instructor
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [Nombre], [Icono], [Color], [Instructor]
	FROM [dbo].[Cursos]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_CursosDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CursosDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[Cursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CursosDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[Cursos]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_PreguntasSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PreguntasSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[Preguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PreguntasSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [CursoId], [Numero], [Descripcion]
	FROM [dbo].[Preguntas]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_PreguntasInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PreguntasInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[Preguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PreguntasInsert]
		@CursoId int,
		@Numero int,
		@Descripcion varchar(2000)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[Preguntas] ([CursoId], [Numero], [Descripcion])
	SELECT @CursoId, @Numero, @Descripcion

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CursoId], [Numero], [Descripcion]
	FROM [dbo].[Preguntas]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_PreguntasUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PreguntasUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[Preguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PreguntasUpdate]
		@Id int,
		@CursoId int,
		@Numero int,
		@Descripcion varchar(2000)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[Preguntas]
	SET [CursoId] = @CursoId, [Numero] = @Numero, [Descripcion] = @Descripcion
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CursoId], [Numero], [Descripcion]
	FROM [dbo].[Preguntas]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_PreguntasDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PreguntasDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[Preguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PreguntasDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[Preguntas]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_AplicacionesEvaluacionesSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_AplicacionesEvaluacionesSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[AplicacionesEvaluaciones]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_AplicacionesEvaluacionesSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [UsuarioId], [CursoId], [Resultado], [FechaRegistro]
	FROM [dbo].[AplicacionesEvaluaciones]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_AplicacionesEvaluacionesInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_AplicacionesEvaluacionesInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[AplicacionesEvaluaciones]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_AplicacionesEvaluacionesInsert]
		@UsuarioId int,
		@CursoId int,
		@Resultado decimal(4,2),
		@FechaRegistro datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[AplicacionesEvaluaciones] ([UsuarioId], [CursoId], [Resultado], [FechaRegistro])
	SELECT @UsuarioId, @CursoId, @Resultado, @FechaRegistro

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [UsuarioId], [CursoId], [Resultado], [FechaRegistro]
	FROM [dbo].[AplicacionesEvaluaciones]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_AplicacionesEvaluacionesUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_AplicacionesEvaluacionesUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[AplicacionesEvaluaciones]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_AplicacionesEvaluacionesUpdate]
		@Id int,
		@UsuarioId int,
		@CursoId int,
		@Resultado decimal(4,2),
		@FechaRegistro datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[AplicacionesEvaluaciones]
	SET [UsuarioId] = @UsuarioId, [CursoId] = @CursoId, [Resultado] = @Resultado, [FechaRegistro] = @FechaRegistro
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [UsuarioId], [CursoId], [Resultado], [FechaRegistro]
	FROM [dbo].[AplicacionesEvaluaciones]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_AplicacionesEvaluacionesDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_AplicacionesEvaluacionesDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[AplicacionesEvaluaciones]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_AplicacionesEvaluacionesDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[AplicacionesEvaluaciones]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_OpcionesPreguntasSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_OpcionesPreguntasSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[OpcionesPreguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_OpcionesPreguntasSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [PreguntaId], [Descripcion], [Orden], [Correcta]
	FROM [dbo].[OpcionesPreguntas]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_OpcionesPreguntasInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_OpcionesPreguntasInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[OpcionesPreguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_OpcionesPreguntasInsert]
		@PreguntaId int,
		@Descripcion varchar(2000),
		@Orden int,
		@Correcta bit
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[OpcionesPreguntas] ([PreguntaId], [Descripcion], [Orden], [Correcta])
	SELECT @PreguntaId, @Descripcion, @Orden, @Correcta

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [PreguntaId], [Descripcion], [Orden], [Correcta]
	FROM [dbo].[OpcionesPreguntas]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_OpcionesPreguntasUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_OpcionesPreguntasUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[OpcionesPreguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_OpcionesPreguntasUpdate]
		@Id int,
		@PreguntaId int,
		@Descripcion varchar(2000),
		@Orden int,
		@Correcta bit
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[OpcionesPreguntas]
	SET [PreguntaId] = @PreguntaId, [Descripcion] = @Descripcion, [Orden] = @Orden, [Correcta] = @Correcta
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [PreguntaId], [Descripcion], [Orden], [Correcta]
	FROM [dbo].[OpcionesPreguntas]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_OpcionesPreguntasDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_OpcionesPreguntasDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[OpcionesPreguntas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_OpcionesPreguntasDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[OpcionesPreguntas]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_RespuestasSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RespuestasSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[Respuestas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RespuestasSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [PreguntaId], [AplicacionEvaluacionId], [OpcionId], [Correcta], [FechaRegistro]
	FROM [dbo].[Respuestas]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_RespuestasInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RespuestasInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[Respuestas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RespuestasInsert]
		@PreguntaId int,
		@AplicacionEvaluacionId int,
		@OpcionId int,
		@Correcta bit,
		@FechaRegistro datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[Respuestas] ([PreguntaId], [AplicacionEvaluacionId], [OpcionId], [Correcta], [FechaRegistro])
	SELECT @PreguntaId, @AplicacionEvaluacionId, @OpcionId, @Correcta, @FechaRegistro

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [PreguntaId], [AplicacionEvaluacionId], [OpcionId], [Correcta], [FechaRegistro]
	FROM [dbo].[Respuestas]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_RespuestasUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RespuestasUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[Respuestas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RespuestasUpdate]
		@Id int,
		@PreguntaId int,
		@AplicacionEvaluacionId int,
		@OpcionId int,
		@Correcta bit,
		@FechaRegistro datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[Respuestas]
	SET [PreguntaId] = @PreguntaId, [AplicacionEvaluacionId] = @AplicacionEvaluacionId, [OpcionId] = @OpcionId, [Correcta] = @Correcta, [FechaRegistro] = @FechaRegistro
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [PreguntaId], [AplicacionEvaluacionId], [OpcionId], [Correcta], [FechaRegistro]
	FROM [dbo].[Respuestas]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_RespuestasDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RespuestasDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[Respuestas]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RespuestasDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[Respuestas]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_UsuariosSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[Usuarios]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [CodigoActivacionId], [Nombre], [Paterno], [Materno], [Email], [Password], [Foto], [FechaNacimiento], [FechaRegistro], [Bloqueado], [ProviderKey], [LoginProvider], [Telefono], [EmailVerificado], [TelefonoVerificado], [Ciudad], [Estado], [Pais], [CodigoPostal], [Rfc], [Observaciones], [FechaUltimaConexion]
	FROM [dbo].[Usuarios]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_UsuariosInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[Usuarios]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosInsert]
		@CodigoActivacionId int,
		@Nombre nvarchar(60),
		@Paterno nvarchar(60),
		@Materno nvarchar(60),
		@Email nvarchar(350),
		@Password nvarchar(1000),
		@Foto nvarchar(41),
		@FechaNacimiento datetime,
		@FechaRegistro datetime,
		@Bloqueado bit,
		@ProviderKey nvarchar(128),
		@LoginProvider nvarchar(128),
		@Telefono nvarchar(10),
		@EmailVerificado bit,
		@TelefonoVerificado bit,
		@Ciudad nvarchar(100),
		@Estado nvarchar(70),
		@Pais nvarchar(300),
		@CodigoPostal nvarchar(6),
		@Rfc nvarchar(13),
		@Observaciones nvarchar(max),
		@FechaUltimaConexion datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[Usuarios] ([CodigoActivacionId], [Nombre], [Paterno], [Materno], [Email], [Password], [Foto], [FechaNacimiento], [FechaRegistro], [Bloqueado], [ProviderKey], [LoginProvider], [Telefono], [EmailVerificado], [TelefonoVerificado], [Ciudad], [Estado], [Pais], [CodigoPostal], [Rfc], [Observaciones], [FechaUltimaConexion])
	SELECT @CodigoActivacionId, @Nombre, @Paterno, @Materno, @Email, @Password, @Foto, @FechaNacimiento, @FechaRegistro, @Bloqueado, @ProviderKey, @LoginProvider, @Telefono, @EmailVerificado, @TelefonoVerificado, @Ciudad, @Estado, @Pais, @CodigoPostal, @Rfc, @Observaciones, @FechaUltimaConexion

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CodigoActivacionId], [Nombre], [Paterno], [Materno], [Email], [Password], [Foto], [FechaNacimiento], [FechaRegistro], [Bloqueado], [ProviderKey], [LoginProvider], [Telefono], [EmailVerificado], [TelefonoVerificado], [Ciudad], [Estado], [Pais], [CodigoPostal], [Rfc], [Observaciones], [FechaUltimaConexion]
	FROM [dbo].[Usuarios]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_UsuariosUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[Usuarios]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosUpdate]
		@Id int,
		@CodigoActivacionId int,
		@Nombre nvarchar(60),
		@Paterno nvarchar(60),
		@Materno nvarchar(60),
		@Email nvarchar(350),
		@Password nvarchar(1000),
		@Foto nvarchar(41),
		@FechaNacimiento datetime,
		@FechaRegistro datetime,
		@Bloqueado bit,
		@ProviderKey nvarchar(128),
		@LoginProvider nvarchar(128),
		@Telefono nvarchar(10),
		@EmailVerificado bit,
		@TelefonoVerificado bit,
		@Ciudad nvarchar(100),
		@Estado nvarchar(70),
		@Pais nvarchar(300),
		@CodigoPostal nvarchar(6),
		@Rfc nvarchar(13),
		@Observaciones nvarchar(max),
		@FechaUltimaConexion datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[Usuarios]
	SET [CodigoActivacionId] = @CodigoActivacionId, [Nombre] = @Nombre, [Paterno] = @Paterno, [Materno] = @Materno, [Email] = @Email, [Password] = @Password, [Foto] = @Foto, [FechaNacimiento] = @FechaNacimiento, [FechaRegistro] = @FechaRegistro, [Bloqueado] = @Bloqueado, [ProviderKey] = @ProviderKey, [LoginProvider] = @LoginProvider, [Telefono] = @Telefono, [EmailVerificado] = @EmailVerificado, [TelefonoVerificado] = @TelefonoVerificado, [Ciudad] = @Ciudad, [Estado] = @Estado, [Pais] = @Pais, [CodigoPostal] = @CodigoPostal, [Rfc] = @Rfc, [Observaciones] = @Observaciones, [FechaUltimaConexion] = @FechaUltimaConexion
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CodigoActivacionId], [Nombre], [Paterno], [Materno], [Email], [Password], [Foto], [FechaNacimiento], [FechaRegistro], [Bloqueado], [ProviderKey], [LoginProvider], [Telefono], [EmailVerificado], [TelefonoVerificado], [Ciudad], [Estado], [Pais], [CodigoPostal], [Rfc], [Observaciones], [FechaUltimaConexion]
	FROM [dbo].[Usuarios]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_UsuariosDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[Usuarios]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[Usuarios]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_RolesSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RolesSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[Roles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RolesSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [Nombre]
	FROM [dbo].[Roles]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_RolesInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RolesInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[Roles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RolesInsert]
		@Nombre varchar(50)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[Roles] ([Nombre])
	SELECT @Nombre

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [Nombre]
	FROM [dbo].[Roles]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_RolesUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RolesUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[Roles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RolesUpdate]
		@Id int,
		@Nombre varchar(50)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[Roles]
	SET [Nombre] = @Nombre
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [Nombre]
	FROM [dbo].[Roles]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_RolesDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_RolesDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[Roles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_RolesDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[Roles]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_UsuariosRolesSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosRolesSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[UsuariosRoles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosRolesSelect]
		@UsuarioId int
		, @RoleId int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [UsuarioId], [RoleId]
	FROM [dbo].[UsuariosRoles]
	WHERE  ([UsuarioId] = @UsuarioId OR @UsuarioId IS NULL) AND ([RoleId] = @RoleId OR @RoleId IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_UsuariosRolesInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosRolesInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[UsuariosRoles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosRolesInsert]
		@UsuarioId int,
		@RoleId int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[UsuariosRoles] ([UsuarioId], [RoleId])
	SELECT @UsuarioId, @RoleId

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [UsuarioId], [RoleId]
	FROM [dbo].[UsuariosRoles]
	WHERE  [UsuarioId] = @UsuarioId AND [RoleId] = @RoleId
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_UsuariosRolesUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosRolesUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[UsuariosRoles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosRolesUpdate]
		@UsuarioId int,
		@RoleId int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[UsuariosRoles]
	SET [UsuarioId] = @UsuarioId, [RoleId] = @RoleId
	WHERE  [UsuarioId] = @UsuarioId AND [RoleId] = @RoleId

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [UsuarioId], [RoleId]
	FROM [dbo].[UsuariosRoles]
	WHERE  [UsuarioId] = @UsuarioId AND [RoleId] = @RoleId
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_UsuariosRolesDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_UsuariosRolesDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[UsuariosRoles]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_UsuariosRolesDelete]
		@UsuarioId int
		, @RoleId int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[UsuariosRoles]
	WHERE  [UsuarioId] = @UsuarioId AND [RoleId] = @RoleId

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_CalificacionCalidadCursosSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CalificacionCalidadCursosSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[CalificacionCalidadCursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CalificacionCalidadCursosSelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [CursoId], [UsuarioId], [Calificacion], [FechaRegistro]
	FROM [dbo].[CalificacionCalidadCursos]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_CalificacionCalidadCursosInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CalificacionCalidadCursosInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[CalificacionCalidadCursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CalificacionCalidadCursosInsert]
		@CursoId int,
		@UsuarioId int,
		@Calificacion decimal(18,2),
		@FechaRegistro datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[CalificacionCalidadCursos] ([CursoId], [UsuarioId], [Calificacion], [FechaRegistro])
	SELECT @CursoId, @UsuarioId, @Calificacion, @FechaRegistro

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CursoId], [UsuarioId], [Calificacion], [FechaRegistro]
	FROM [dbo].[CalificacionCalidadCursos]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_CalificacionCalidadCursosUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CalificacionCalidadCursosUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[CalificacionCalidadCursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CalificacionCalidadCursosUpdate]
		@Id int,
		@CursoId int,
		@UsuarioId int,
		@Calificacion decimal(18,2),
		@FechaRegistro datetime
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[CalificacionCalidadCursos]
	SET [CursoId] = @CursoId, [UsuarioId] = @UsuarioId, [Calificacion] = @Calificacion, [FechaRegistro] = @FechaRegistro
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CursoId], [UsuarioId], [Calificacion], [FechaRegistro]
	FROM [dbo].[CalificacionCalidadCursos]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_CalificacionCalidadCursosDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_CalificacionCalidadCursosDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[CalificacionCalidadCursos]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_CalificacionCalidadCursosDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[CalificacionCalidadCursos]
	WHERE  [Id] = @Id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_sysdiagramsSelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_sysdiagramsSelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[sysdiagrams]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_sysdiagramsSelect]
		, @diagram_id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [name], [principal_id], [diagram_id], [version], [definition]
	FROM [dbo].[sysdiagrams]
	WHERE  ([diagram_id] = @diagram_id OR @diagram_id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_sysdiagramsInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_sysdiagramsInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[sysdiagrams]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_sysdiagramsInsert]
		@name nvarchar(128),
		@principal_id int,
		@version int,
		@definition varbinary(max)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[sysdiagrams] ([name], [principal_id], [version], [definition])
	SELECT @name, @principal_id, @version, @definition

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [name], [principal_id], [diagram_id], [version], [definition]
	FROM [dbo].[sysdiagrams]
	WHERE  [diagram_id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_sysdiagramsUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_sysdiagramsUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[sysdiagrams]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_sysdiagramsUpdate]
		@name nvarchar(128),
		@principal_id int,
		@diagram_id int,
		@version int,
		@definition varbinary(max)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[sysdiagrams]
	SET [name] = @name, [principal_id] = @principal_id, [version] = @version, [definition] = @definition
	WHERE  [diagram_id] = @diagram_id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [name], [principal_id], [diagram_id], [version], [definition]
	FROM [dbo].[sysdiagrams]
	WHERE  [diagram_id] = @diagram_id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_sysdiagramsDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_sysdiagramsDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[sysdiagrams]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_sysdiagramsDelete]
		, @diagram_id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[sysdiagrams]
	WHERE  [diagram_id] = @diagram_id

	COMMIT
GO
/*============================================================================================================*/
/*============================================================================================================*/
IF OBJECT_ID('[dbo].[usp_PagosOpenPaySelect]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PagosOpenPaySelect]
END
GO
/*
	SP para el Select de la tabla [dbo].[PagosOpenPay]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PagosOpenPaySelect]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	SELECT [Id], [CursoId], [Importe], [Autorizacion], [Metodo], [TipoOperacion], [TipoTransaccion], [TipoTarjeta], [Marca], [UltimosDigitos], [TarjetaHabiente], [Banco], [CodigoBancario], [Estatus], [Token], [Fecha], [Descripcion], [MensajeError], [orderId], [Tipo]
	FROM [dbo].[PagosOpenPay]
	WHERE  ([Id] = @Id OR @Id IS NULL)

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_PagosOpenPayInsert]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PagosOpenPayInsert]
END
GO
/*
	SP para el Insert de la tabla [dbo].[PagosOpenPay]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PagosOpenPayInsert]
		@CursoId int,
		@Importe money,
		@Autorizacion varchar(15),
		@Metodo varchar(15),
		@TipoOperacion varchar(15),
		@TipoTransaccion varchar(15),
		@TipoTarjeta varchar(15),
		@Marca varchar(10),
		@UltimosDigitos varchar(4),
		@TarjetaHabiente varchar(16),
		@Banco varchar(30),
		@CodigoBancario varchar(3),
		@Estatus varchar(10),
		@Token varchar(250),
		@Fecha datetime,
		@Descripcion varchar(200),
		@MensajeError varchar(150),
		@orderId varchar(10),
		@Tipo varchar(18)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[PagosOpenPay] ([CursoId], [Importe], [Autorizacion], [Metodo], [TipoOperacion], [TipoTransaccion], [TipoTarjeta], [Marca], [UltimosDigitos], [TarjetaHabiente], [Banco], [CodigoBancario], [Estatus], [Token], [Fecha], [Descripcion], [MensajeError], [orderId], [Tipo])
	SELECT @CursoId, @Importe, @Autorizacion, @Metodo, @TipoOperacion, @TipoTransaccion, @TipoTarjeta, @Marca, @UltimosDigitos, @TarjetaHabiente, @Banco, @CodigoBancario, @Estatus, @Token, @Fecha, @Descripcion, @MensajeError, @orderId, @Tipo

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CursoId], [Importe], [Autorizacion], [Metodo], [TipoOperacion], [TipoTransaccion], [TipoTarjeta], [Marca], [UltimosDigitos], [TarjetaHabiente], [Banco], [CodigoBancario], [Estatus], [Token], [Fecha], [Descripcion], [MensajeError], [orderId], [Tipo]
	FROM [dbo].[PagosOpenPay]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_PagosOpenPayUpdate]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PagosOpenPayUpdate]
END
GO
/*
	SP para el Update de la tabla [dbo].[PagosOpenPay]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PagosOpenPayUpdate]
		@Id int,
		@CursoId int,
		@Importe money,
		@Autorizacion varchar(15),
		@Metodo varchar(15),
		@TipoOperacion varchar(15),
		@TipoTransaccion varchar(15),
		@TipoTarjeta varchar(15),
		@Marca varchar(10),
		@UltimosDigitos varchar(4),
		@TarjetaHabiente varchar(16),
		@Banco varchar(30),
		@CodigoBancario varchar(3),
		@Estatus varchar(10),
		@Token varchar(250),
		@Fecha datetime,
		@Descripcion varchar(200),
		@MensajeError varchar(150),
		@orderId varchar(10),
		@Tipo varchar(18)
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	UPDATE [dbo].[PagosOpenPay]
	SET [CursoId] = @CursoId, [Importe] = @Importe, [Autorizacion] = @Autorizacion, [Metodo] = @Metodo, [TipoOperacion] = @TipoOperacion, [TipoTransaccion] = @TipoTransaccion, [TipoTarjeta] = @TipoTarjeta, [Marca] = @Marca, [UltimosDigitos] = @UltimosDigitos, [TarjetaHabiente] = @TarjetaHabiente, [Banco] = @Banco, [CodigoBancario] = @CodigoBancario, [Estatus] = @Estatus, [Token] = @Token, [Fecha] = @Fecha, [Descripcion] = @Descripcion, [MensajeError] = @MensajeError, [orderId] = @orderId, [Tipo] = @Tipo
	WHERE  [Id] = @Id

	-- Inicia el Select para retornar la entidad NO REMOVER
	SELECT [Id], [CursoId], [Importe], [Autorizacion], [Metodo], [TipoOperacion], [TipoTransaccion], [TipoTarjeta], [Marca], [UltimosDigitos], [TarjetaHabiente], [Banco], [CodigoBancario], [Estatus], [Token], [Fecha], [Descripcion], [MensajeError], [orderId], [Tipo]
	FROM [dbo].[PagosOpenPay]
	WHERE  [Id] = @Id
	-- Fin de el Select para retornar la entidad NO REMOVER

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_PagosOpenPayDelete]') IS NOT NULL
BEGIN
	DROP PROC [dbo].[usp_PagosOpenPayDelete]
END
GO
/*
	SP para el Delete de la tabla [dbo].[PagosOpenPay]
	Autor: CursosOnline
	Proyecto: CursosOnline
	Comentarios: Sentencia SQL CRUD
	Fecha de creación: 29/07/2019
	Autogenerado con la herramienta de Novatek ORM
*/
	CREATE PROC [dbo].[usp_PagosOpenPayDelete]
		@Id int
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	DELETE FROM [dbo].[PagosOpenPay]
	WHERE  [Id] = @Id

	COMMIT
GO
