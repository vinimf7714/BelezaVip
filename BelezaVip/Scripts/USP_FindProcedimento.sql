exec [USP_FindProcedimentos] 'cor'

--Procedure para busca de atendimentos
use [BelezaVip];

GO

ALTER PROCEDURE [USP_FindProcedimentos] @nmProcedimento VARCHAR(20)

AS BEGIN

select * from tb_procedimento WHERE descricao LIKE '%' + @nmProcedimento + '%'

END
