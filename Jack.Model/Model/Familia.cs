﻿using System;
using System.Collections.Generic;
using DomainValidation.Interfaces.Validation;
using DomainValidation.Validation;
using Jack.Model.Validations;
using Jack.Model.Enum;

namespace Jack.Model
{
    [Serializable]
    public class Familia : BaseModel<Familia>, ISelfValidator
    {

        #region "Construtor"

        public Familia() :base()
        {
            nome = string.Empty;
            isSacolinha = string.Empty;
            isConsistente = string.Empty;
            contato = string.Empty;
            nivel = 99;
            status = new Status();
            criancas = new List<Criancas>();
        }

        #endregion

        #region Fields

        private string nome ;
        private string isSacolinha ;
        private string isConsistente;
        private string contato ;
        private int nivel ;
        private Status status ;
        private IList<Criancas> criancas ;
        private DateTime dataAtualizacao;
        private ValidationResult validationResult;
        #endregion

        #region Properties

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

        public virtual string IsSacolinha
        {
            get
            {
                return isSacolinha;
            }
            set
            {
                isSacolinha = value;
            }
        }

        public virtual string IsConsistente
        {
            get
            {
                return isConsistente;
            }
            set
            {
                isConsistente = value;
            }
        }

        public virtual string Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
            }
        }

        public virtual int Nivel
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

        public virtual IList<Criancas> Criancas
        {
            get
            {
                return criancas;
            }
            set
            {
                criancas = value;
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

        public virtual ValidationResult ValidationResult
        {
            get
            {
                return validationResult;
            }
        }

        #endregion

        #region Methods

        public virtual void AddCriancas(Criancas pCrianca)
        {
            pCrianca.Familia.Add(this);
            Criancas.Add(pCrianca);
        }

        public virtual bool IsValid()
        {
            var familiaValidation = new FamiliaValidValidation();
            validationResult = familiaValidation.Validate(this);
            return validationResult.IsValid;
        }

        #endregion
    }
}
