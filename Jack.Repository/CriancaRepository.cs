﻿using Dapper;
using Jack.Domain.Entity;
using Jack.Domain.Interfaces.Repository;
using Jack.Domain.ObjectValue;
using Jack.Repository.UnityOfWork;
using System.Collections.Generic;

namespace Jack.Repository
{
    public class CriancaRepository : BaseRepository<Crianca>, ICriancaRepository
    {
        private readonly IUnityOfWork UnitWork;
        public CriancaRepository(IUnityOfWork unitWork)
            : base(unitWork)
        {
            UnitWork = unitWork;
        }

        public IEnumerable<CriancaVestimenta> ObterDadosCriancaVestimentas(int familia)
        {
            var sql = @"SELECT	cr.Codigo, cr.Nome, cr.Idade, cr.MedidaIdade, cr.Sexo, cr.Calcado, 
                                cr.Roupa, 99 as CalcadoPadrao, '99' as RoupaPadrao, cr.NecessidadeEspecial, 
                                cr.CriancaGrande, cr.IdadeNominal, cr.IdadeNominalReduzida,
                                cr.TipoParentesco as TipoParentescoId, tp.Descricao as TipoParentesco,
                                st.Descricao as Status, fa.Nome as Familia, st.PermiteSacola
                        FROM	Crianca cr
                        JOIN	StatusCrianca st
                        ON		cr.Status = st.Codigo
                        JOIN	Familia fa
                        ON		cr.Familia = fa.Codigo
                        AND		cr.Familia = @familia
                        JOIN    TipoParentesco tp
                        ON      tp.Codigo = cr.TipoParentesco
                        UNION ALL
                        SELECT	cr.Codigo, cr.Nome, cr.Idade, cr.MedidaIdade, cr.Sexo, cr.Calcado, 
                                cr.Roupa, 99 as CalcadoPadrao, '99' as RoupaPadrao, cr.NecessidadeEspecial, 
                                cr.CriancaGrande, cr.IdadeNominal, cr.IdadeNominalReduzida,
                                cr.TipoParentesco as TipoParentescoId, tp.Descricao as TipoParentesco,
                                st.Descricao as Status, fa.Nome as Familia, st.PermiteSacola
                        FROM	Crianca cr
                        JOIN	StatusCrianca st
                        ON		cr.Status = st.Codigo
                        JOIN	Familia fa
                        ON		cr.Familia = fa.Codigo
                        AND		cr.Familia IN (SELECT FamiliaRepresentada 
                                               FROM Representante 
                                               WHERE FamiliaRepresentante = @familia)
                        JOIN    TipoParentesco tp
                        ON      tp.Codigo = cr.TipoParentesco
                        ORDER BY st.PermiteSacola DESC, fa.Nome, cr.Nome";

            var result = Session.Connection.Query<CriancaVestimenta>(sql, new { familia });
            return result;

        }
    }
}