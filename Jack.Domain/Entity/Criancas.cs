﻿using Jack.DomainValidator;
using System;
using System.Collections.Generic;
using Jack.Domain.Interfaces;
using Jack.Extensions;

namespace Jack.Domain.Entity
{
    public class Criancas : IEntidade
    {

        public Criancas():base()
        {
            nome = string.Empty;
            idade = 0;
            dataNascimento = new DateTime();
            sexo = string.Empty;
            kit = new Kit();
            medidaIdade = string.Empty;
            calcado = 99;
            roupa = "99";
            idadeNominal = string.Empty;
            idadeNominalReduzida = string.Empty;
            sacolinha = false;
            consistente = false;
            necessidadeEspecial = false;
            moralCrista = false;
            status = new Status();
            dataCriacao = new DateTime();
            dataAtualizacao = new DateTime();

        }

        private int codigo;
        private Familia familia;
        private string nome;
        private int idade;
        private string medidaIdade;
        private DateTime dataNascimento;
        private string idadeNominal;
        private string idadeNominalReduzida;
        private string sexo;
        private int calcado;
        private string roupa;
        private Kit kit;
        private bool sacolinha;
        private bool consistente;
        private bool necessidadeEspecial;
        private bool moralCrista;
        private bool criancaMaior;
        private Status status;
        private DateTime dataAtualizacao;
        private DateTime dataCriacao;

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

        public virtual string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public virtual int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        public virtual string MedidaIdade
        {
            get
            {
                return medidaIdade;
            }
            set
            {
                medidaIdade = value;
            }
        }

        public virtual DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
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

        public virtual int Calcado
        {
            get
            {
                return calcado;
            }
            set
            {
                calcado = value;
            }
        }

        public virtual string Roupa
        {
            get
            {
                return roupa;
            }
            set
            {
                roupa = value;
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

        public virtual bool Sacolinha
        {
            get
            {
                return sacolinha;
            }
            set
            {
                sacolinha = value;
            }
        }

        public virtual bool Consistente
        {
            get
            {
                return consistente;
            }
            set
            {
                consistente = value;
            }
        }

        public virtual bool NecessidadeEspecial
        {
            get
            {
                return necessidadeEspecial;
            }
            set
            {
                necessidadeEspecial = value;
            }
        }

        public virtual bool MoralCrista
        {
            get
            {
                return moralCrista;
            }
            set
            {
                moralCrista = value;
            }
        }

        public virtual bool CriancaMaior
        {
            get
            {
                return criancaMaior;
            }
            set
            {
                criancaMaior = value;
            }
        }

        public virtual string IdadeNominal
        {
            get
            {
                return idadeNominal;
            }
            set
            {
                idadeNominal = value;
            }
        }

        public virtual string IdadeNominalReduzida
        {
            get
            {
                return idadeNominalReduzida;
            }
            set
            {
                idadeNominalReduzida = value;
            }
        }

        public virtual Status Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }


        public virtual DateTime DataAtualizacao
        {
            get
            {
                return dataAtualizacao;
            }
            set
            {
                dataAtualizacao = value;
            }
        }

        public virtual DateTime DataCriacao
        {
            get
            {
                return dataCriacao;
            }
            set
            {
                dataCriacao = value;
            }
        }

        public virtual bool VerifyRoupa()
        {
            return Calcado != 99;
        }

        public virtual bool VerifyCalcado()
        {

            return Roupa != "99";
        }

        public virtual bool IdadePermitida()
        {
            DateTime dataBase = new DateTime(DateTime.Now.Year, 12, 31);
            int anos = dataBase.Year - dataNascimento.Year;

            if (dataBase.Month < dataNascimento.Month || 
                (dataBase.Month == dataNascimento.Month && dataBase.Day < dataNascimento.Day))
                anos--;

            return (anos < 11);
        }

        public virtual void CalculaIdade()
        {
            Helpers.Idade oIdade = new Helpers.Idade(DataNascimento,
                                                     new DateTime(DateTime.Now.Year, 12, 31));

            idade = oIdade.Anos;
            idadeNominal = string.Format("{0} anos e {1} Meses", oIdade.Anos, oIdade.Meses);
            idadeNominalReduzida = string.Format("{0}A{1}M", oIdade.Anos, oIdade.Meses);

            //acertar status
        }

    }

}
