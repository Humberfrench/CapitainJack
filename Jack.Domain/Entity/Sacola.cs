﻿using Jack.Domain.Interfaces;

namespace Jack.Domain.Entity
{
    public class Sacola : IEntidade
    {
        public Sacola()
        {
            id = 0;
            codigo = 0;
            sacolaFamilia = 0;
            sexo = string.Empty;
            impressa = false;
            liberado = false;
        }

        private int id;
        private int codigo;
        private int sacolaFamilia;
        private Familia familia;
        private Familia familiaRepresentante;
        private Crianca crianca;
        private string sexo;
        private Kit kit;
        private Nivel nivel;
        private bool impressa;
        private bool liberado;
        private byte[] qrCode;

        public virtual int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public virtual int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public virtual int SacolaFamilia
        {
            get
            {
                return sacolaFamilia;
            }
            set
            {
                sacolaFamilia = value;
            }
        }

        public virtual Familia Familia
        {
            get
            {
                return familia;
            }
            set
            {
                familia = value;
            }
        }

        public virtual Familia FamiliaRepresentante
        {
            get
            {
                return familiaRepresentante;
            }
            set
            {
                familiaRepresentante = value;
            }
        }

        public virtual Crianca Crianca
        {
            get
            {
                return crianca;
            }
            set
            {
                crianca = value;
            }
        }

        public virtual string Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }

        public virtual Kit Kit
        {
            get
            {
                return kit;
            }
            set
            {
                kit = value;
            }
        }

        public virtual Nivel Nivel
        {
            get
            {
                return nivel;
            }
            set
            {
                nivel = value;
            }
        }

        public virtual bool Impressa
        {
            get
            {
                return impressa;
            }
            set
            {
                impressa = value;
            }
        }

        public virtual bool Liberado
        {
            get
            {
                return liberado;
            }
            set
            {
                liberado = value;
            }
        }

        public virtual byte[] QrCode
        {
            get
            {
                return qrCode;
            }
            set
            {
                qrCode = value;
            }
        }




    }
}