﻿using System.Collections.Generic;
using Jack.Application.ViewModel;
using Jack.DomainValidator;

namespace Jack.Application.Interfaces
{
    public interface IKitServiceApp : IServiceBase<KitViewModel>
    {
        IEnumerable<KitViewModel> Filtrar(string nome);
        ValidationResult Gravar(KitViewModel entity);
        ValidationResult Excluir(int id);
    }
}