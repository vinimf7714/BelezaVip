--Procedure para busca de atendimentos
use [BelezaVip];

GO

ALTER PROCEDURE [USP_FindAtendimento] 

AS BEGIN

select
a.id,
p.nome as 'nomeProfissional',
proced.descricao as 'nomeProcedimento',
c.nome as 'nomeCliente',
a.dtAtendimento as 'dataAtendimento',
pv.valor as 'valorProcedimento',
d.desconto as 'valorDesconto'
from tb_atendimento a inner join tb_atendimento_item ai
on a.id = ai.idAtendimentoFK
inner join tb_cliente c on c.id = a.idClienteFK
inner join tb_profissional p on p.id = ai.idProfissionalFK
inner join tb_procedimento proced on proced.id = ai.idProcedimentoFK
inner join tb_procedimento_valor pv on pv.id = ai.idProcedimentoValorFK
inner join tb_desconto d on d.id = ai.idDescontoFK 
group by 
a.id,
p.nome,
proced.descricao,
c.nome,
a.dtAtendimento,
pv.valor,
d.desconto 
END