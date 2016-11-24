﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Jack.Domain.Entity;

namespace Jack.Repository.Mappings
{
    class MapSacola : ClassMap<Sacola>
    {
        public MapSacola()
        {
            //Table
            Table("Sacolas");
            LazyLoad();

            //Fields
            Id(x => x.Codigo).Column("Codigo");
            Map(x => x.SacolaFamilia).Column("SacolaFamilia").Not.Nullable();
            //Map(x => x.Familia).Column("Familia").Not.Nullable();
            //Map(x => x.FamiliaRepresentante).Column("FamiliaRepresentante").Not.Nullable();
            //Map(x => x.Crianca).Column("Crianca").Not.Nullable();
            Map(x => x.Sexo).Column("Sexo").Not.Nullable();
            //Map(x => x.Kit).Column("Kit").Not.Nullable();
            //Map(x => x.Nivel).Column("Nivel").Not.Nullable();
            Map(x => x.Impressa).Column("Impressa").Not.Nullable();
            Map(x => x.Liberado).Column("Liberado").Not.Nullable();

            //References
            References(x => x.Familia).Column("Familia").Not.Nullable().Not.LazyLoad();
            References(x => x.FamiliaRepresentante).Column("FamiliaRepresentante").Not.Nullable().Not.LazyLoad();
            References(x => x.Crianca).Column("Crianca").Not.Nullable().Not.LazyLoad();
            References(x => x.Kit).Column("Kit").Not.Nullable().Not.LazyLoad();
            References(x => x.Nivel).Column("Nivel").Not.Nullable().Not.LazyLoad();

        }
    }
}
