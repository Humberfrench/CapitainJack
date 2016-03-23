﻿using System;
using System.Collections.Generic;

namespace Jack.Business
{
    public class CriancaMoralCrista : ICrud<Model.CriancaMoralCrista, int>
    {
        public CriancaMoralCrista()
        {

        }

        public bool Delete(Model.CriancaMoralCrista oTipo)
        {
            Data.CriancaMoralCrista oDados = null;
            bool blnRetorno = false;

            try
            {
                oDados = new Data.CriancaMoralCrista();
                blnRetorno = oDados.Delete(oTipo);
            }
            catch (Exception ex)
            {
                blnRetorno = false;
                throw ex;
            }
            finally
            {
                oDados = null;
            }

            return blnRetorno;

        }

        public Model.CriancaMoralCrista Find(int Identifier)
        {

            Data.CriancaMoralCrista oDados = null;
            Model.CriancaMoralCrista oRetorno = null;

            try
            {
                oDados = new Data.CriancaMoralCrista();
                oRetorno = oDados.Find(Identifier);
            }
            catch (Exception ex)
            {
                oRetorno = null;
                throw ex;
            }
            finally
            {
                oDados = null;
            }

            return oRetorno;

        }

        public bool Insert(Model.CriancaMoralCrista oTipo)
        {
            Data.CriancaMoralCrista oDados = null;
            bool blnRetorno = false;

            try
            {
                oDados = new Data.CriancaMoralCrista();
                blnRetorno = oDados.Insert(oTipo);
            }
            catch (Exception ex)
            {
                blnRetorno = false;
                throw ex;
            }
            finally
            {
                oDados = null;
            }

            return blnRetorno;
        }

        public IList<Model.CriancaMoralCrista> LoadAll()
        {
            Data.CriancaMoralCrista oDados = null;
            IList<Model.CriancaMoralCrista> lstRetorno = null;

            try
            {
                oDados = new Data.CriancaMoralCrista();
                lstRetorno = oDados.LoadAll();
            }
            catch (Exception ex)
            {
                lstRetorno = null;
                throw ex;
            }
            finally
            {
                oDados = null;
            }

            return lstRetorno;

        }

        public bool Update(Model.CriancaMoralCrista oTipo)
        {
            Data.CriancaMoralCrista oDados = null;
            bool blnRetorno = false;

            try
            {
                oDados = new Data.CriancaMoralCrista();
                blnRetorno = oDados.Update(oTipo);
            }
            catch (Exception ex)
            {
                blnRetorno = false;
                throw ex;
            }
            finally
            {
                oDados = null;
            }

            return blnRetorno;
        }
    }
}