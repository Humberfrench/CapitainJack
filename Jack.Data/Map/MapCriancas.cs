﻿using FluentNHibernate.Mapping;
using System;


namespace Jack.Data.Map
{
    class MapCriancas : ClassMap<Model.Criancas>
    {
        public MapCriancas()
        {
            //Table
            Table("id_crianca");

            //Fields
            Id(x => x.Codigo);
            Map(x => x.Nome).Column("nm_crianca").Not.Nullable();
            Map(x => x.Idade).Column("nr_idade").Not.Nullable();
            Map(x => x.MedidaIdade).Column("ds_medida_idade").Not.Nullable();
            Map(x => x.DataNascimento).Column("dt_nascimento").Not.Nullable();
            Map(x => x.Sexo).Column("ds_sexo").Not.Nullable();
            Map(x => x.Calcado).Column("nr_calcado").Not.Nullable();
            Map(x => x.Roupa).Column("nr_roupa").Not.Nullable();
            Map(x => x.IsSacolinha).Column("is_sacolinha").Not.Nullable();
            Map(x => x.IsConsistente).Column("is_consistente").Not.Nullable();
            Map(x => x.IsNecessidadeEspecial).Column("is_necessidade_especial").Nullable().Default("N");
            Map(x => x.IsMoralCrista).Column("is_moral_crista").Not.Nullable().Default("N");
            Map(x => x.DataAtualizacao).Column("ds_sexo").Not.Nullable();
            Map(x => x.DataAtualizacao).Column("dt_update").Nullable().Default(DateTime.Now.ToString());

            //References
            References(x => x.Status).Column("id_status");
            References(x => x.Kit).Column("id_kit");

        }
    }
}
