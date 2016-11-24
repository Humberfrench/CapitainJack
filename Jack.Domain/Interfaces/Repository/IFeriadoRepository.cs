﻿using System;
using System.Collections.Generic;
using Jack.Domain.Entity;

namespace Jack.Domain.Interfaces.Repository
{
    public interface IFeriadoRepository : IRepositoryBase<Feriado>
    {
        IEnumerable<Feriado> ObterPorAnoEfetivo(int ano);
        Feriado ObterFeriado(int ano, DateTime dataReuniao);
    }
}