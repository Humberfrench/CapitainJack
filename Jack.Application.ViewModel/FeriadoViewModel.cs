﻿using System;

namespace Jack.Application.ViewModel
{
    public class FeriadoViewModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public int AnoEfetivo { get; set; }
        public DateTime ReuniaoAnterior { get; set; }
        public DateTime ProximaReuniao { get; set; }
        public bool PodeTerReuniao { get; set; }
    }
}
