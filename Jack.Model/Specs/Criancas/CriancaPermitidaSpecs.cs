﻿using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack.Model.Specs
{
    public class CriancaPermitidaSpecs : ISpecification<Criancas>
    {
        public bool IsSatisfiedBy(Criancas crianca)
        {
            return !crianca.IdadePermitida() && (crianca.IsMoralCrista == "N");
        }

    }
}
