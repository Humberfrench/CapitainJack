﻿using FluentNHibernate.Mapping;
using System;
using Jack.Domain.Entity;

namespace Jack.Repository.Mappings
{
    class MapParametro : ClassMap<Parametro>
    {
        public MapParametro()
        {
            //Table
            Table("Parametro");

            Id(x => x.Codigo).Column("Codigo").Not.Nullable();
            LazyLoad();

            //Fields
            Map(x => x.CalcadoLimite).Column("CalcadoLimite").Not.Nullable();
            Map(x => x.IdadeLimite).Column("IdadeLimite").Not.Nullable();
            Map(x => x.IdadeLimiteExcecao).Column("IdadeLimiteExcecao").Not.Nullable();
            Map(x => x.NumeroMaximoCricancas).Column("NumeroMaximoCricancas").Not.Nullable();
            Map(x => x.TemIdadeLimiteExcecao).Column("TemIdadeLimiteExcecao").Nullable();
            Map(x => x.PrimeiroSabado).Column("PrimeiroSabado").Nullable();
            Map(x => x.SegundoSabado).Column("SegundoSabado").Nullable();
            Map(x => x.TerceiroSabado).Column("TerceiroSabado").Nullable();

        }
    }
}

