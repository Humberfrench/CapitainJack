﻿using System.Collections.Generic;
using Jack.Domain.Entity;
using Jack.DomainValidator;

namespace Jack.Domain.Interfaces.Services
{
    public interface INivelService : IServiceBase<Nivel>
    {
        IEnumerable<Nivel> Filtrar(string nome);
        ValidationResult Gravar(Nivel entity);
        ValidationResult Excluir(int id);
    }
}