﻿using System.Collections.Generic;

namespace Jack.Application.ViewModel
{
    public class SacolaValueViewModel
    {
        public int Numero { get; set; }
        public int SacolaFamilia { get; set; }
        public int Familia { get; set; }
        public int Representante { get; set; }
        public int Crianca { get; set; }
        public string Sexo { get; set; }
        public int Kit { get; set; }
        public string KitNome { get; set; }
        public string NomeFamilia { get; set; }
        public string NomeRepresentante { get; set; }
        public string NomeColaborador { get; set; }
        public string NomeCrianca { get; set; }
        public int Calcado { get; set; }
        public string Roupa { get; set; }
        public string IdadeNominal { get; set; }
        public string Colaborador { get; set; }
        public IEnumerable<ItemValueViewModel> Itens { get; set; }
        public byte[] QrCode { get; set; }

    }
}