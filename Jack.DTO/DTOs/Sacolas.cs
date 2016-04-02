﻿using System;

namespace Jack.DTO
{
    [Serializable()]
    public class Sacolas
    {

        public virtual int NumeroSacola { get; set; }
        public virtual int NumeroSacolaFamilia { get; set; }
        public virtual int CodigoFamilia { get; set; }
        public virtual int CodigoFamiliaRep { get; set; }
        public virtual int CodigoCrianca { get; set; }
        public virtual string Sexo { get; set; }
        public virtual string NomeMae { get; set; }
        public virtual string NomeMaeRep { get; set; }
        public virtual string NomeCrianca { get; set; }
        public virtual int Calcado { get; set; }
        public virtual string Roupa { get; set; }
        public virtual int Idade { get; set; }
        public virtual string MedidaIdade { get; set; }
        public virtual int CodigoKit { get; set; }
        public virtual string DescricaoKit { get; set; }
        public virtual int NumeroNivel { get; set; }
        public virtual string Impresso { get; set; }
        public virtual int CodigoStatus { get; set; }
        public virtual string DescricaoStatus { get; set; }

        public virtual string IdadeCrianca
        {
            get { return Idade.ToString() + " " + MedidaIdade; }
        }

    }

}