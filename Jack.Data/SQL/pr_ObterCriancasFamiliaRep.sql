USE [dbCECAMDev]
GO
/****** Object:  StoredProcedure [dbo].[pr_ObterCriancasFamiliaRep]    Script Date: 23/02/2016 12:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[pr_ObterCriancasFamiliaRep] (@id_familia int)
AS

	CREATE TABLE #tb_crianca(
	id_crianca				int				not null,
	nm_crianca				varchar(75)		not null,
	nr_idade				float			not null,
	ds_medida_idade			varchar(1)		not null,
	dt_nascimento			smalldatetime	not null,
	ds_sexo					varchar(1)		not null,
	nr_calcado				int				not null,
	nr_calcado_padrao		int				not null,
	nr_roupa				varchar(5)		not null,
	nr_roupa_padrao			varchar(5)		not null,
	id_kit					int     		not null,
	ds_kit					varchar(50)		not null,
	is_sacolinha			varchar(1)		not null,
	is_consistente			varchar(1)		not null,
	is_moral_crista			varchar(1)		not null,
	id_status				int      		not null,
	ds_status				varchar(50)		not null,	
	is_crianca_maior		varchar(1)		not null,
	is_necessidade_especial	varchar(1)		not null,
	ds_idade_nominal		varchar(20)		not null,
	ds_idade_nominal_resumido	varchar(6)	not null,
	dt_create				smalldatetime	not null,
	dt_update				smalldatetime	not null)
	
	DECLARE @id_crianca int	
	DECLARE @nr_roupa varchar(5)
	DECLARE @nr_calcado int	
	DECLARE @nr_idade int	
	DECLARE @ds_medida_idade varchar(1)
	DECLARE @sexo varchar(1)
		
	INSERT INTO #tb_crianca 	
	SELECT	cr.id_crianca,	nm_crianca,	nr_idade, ds_medida_idade,
	dt_nascimento, cr.ds_sexo, nr_calcado, nr_calcado, nr_roupa, 
	nr_roupa, cr.id_kit,	ds_kit,	is_sacolinha, is_consistente, 
	cr.is_moral_crista,	cr.id_status, ds_status, is_crianca_maior,
	cr.is_necessidade_especial, cr.ds_idade_nominal, 
	cr.ds_idade_nominal_resumido, cr.dt_create,cr.dt_update
 	FROM	tb_crianca cr
	JOIN	tb_familia_crianca fc
	ON		cr.id_crianca = fc.id_crianca
	AND		fc.id_familia = @id_familia
	JOIN	tb_status st
	ON		cr.id_status = st.id_status
	JOIN	tb_kit kt
	ON		cr.id_kit = kt.id_kit

	INSERT INTO #tb_crianca 	
	SELECT	cr.id_crianca,	nm_crianca,	nr_idade, ds_medida_idade,
	dt_nascimento, cr.ds_sexo, nr_calcado,nr_calcado, nr_roupa, 
	nr_roupa, cr.id_kit,	ds_kit,	is_sacolinha, is_consistente, 
	cr.is_moral_crista,	cr.id_status, ds_status, is_crianca_maior,
	cr.is_necessidade_especial, cr.ds_idade_nominal, 
	cr.ds_idade_nominal_resumido, cr.dt_create,cr.dt_update
 	FROM	tb_crianca cr
	JOIN	tb_familia_crianca fc
	ON		cr.id_crianca = fc.id_crianca
	AND		fc.id_familia IN (SELECT id_familia_representada FROM tb_representante_familia WHERE id_familia_representante = @id_familia)
	JOIN	tb_status st
	ON		cr.id_status = st.id_status
	JOIN	tb_kit kt
	ON		cr.id_kit = kt.id_kit
	
	DECLARE c_crianca CURSOR 
	FOR
	SELECT	cr.id_crianca, cr.nr_idade, cr.ds_sexo, cr.ds_medida_idade
	FROM #tb_crianca cr

	OPEN c_crianca
	
	FETCH NEXT FROM c_crianca INTO	@id_crianca, @nr_idade, @sexo, @ds_medida_idade
	WHILE @@FETCH_STATUS = 0
	BEGIN
	
		SELECT	@nr_roupa = '99', @nr_calcado = 99

		SELECT	@nr_roupa = ISNULL(ds_tamanho_sugerido,99)
		FROM	tb_roupa 
		WHERE	nr_idade = @nr_idade 
		AND		ds_medida_idade = @ds_medida_idade 

		SELECT	@nr_calcado = ISNULL(nr_calcado,99)
		FROM	tb_calcado
		WHERE	@nr_idade BETWEEN nr_inicio AND nr_fim 
		AND		ds_medida_idade = @ds_medida_idade
		AND		ds_sexo = @sexo

		UPDATE #tb_crianca
		SET		nr_calcado_padrao = @nr_calcado,
				nr_roupa_padrao = @nr_roupa
		WHERE  id_crianca = @id_crianca 
			
		FETCH NEXT FROM c_crianca INTO	@id_crianca, @nr_idade, @sexo, @ds_medida_idade

	END
	
	CLOSE c_crianca;
	DEALLOCATE c_crianca;


	SELECT  cr.*, fa.nm_mae , fa.id_familia
	FROM	#tb_crianca cr
	JOIN	tb_familia_crianca fc
	ON		cr.id_crianca = fc.id_crianca
	JOIN	tb_familia fa
	ON		fc.id_familia = fa.id_familia 
	ORDER BY fa.nm_mae, cr.nm_crianca 


	--[pr_ObterCriancasFamiliaRep] 89