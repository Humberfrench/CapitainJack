﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack.Business
{
    public class FamiliaCrianca
    {

        public FamiliaCrianca() : base()
        {
        }

        /// <summary>
        /// Método para inserir o registro
        /// </summary>
        /// <param name="intCrianca">Criança</param>
        /// <param name="intFamilia">Familia</param>
        /// <returns>Boolean. Se a operação foi um sucesso, true.</returns>
        /// <remarks></remarks>
        public bool Insert(int intFamilia, int intCrianca)
        {
            bool blnRetorno = false;
            Data.FamiliaCrianca oDados = null;
            try
            {
                oDados = new Data.FamiliaCrianca();
                blnRetorno = oDados.Insert(intFamilia, intCrianca);

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


        /// <summary>
        /// Método para excluir o registro
        /// </summary>
        /// <param name="intFamilia">Familia</param>
        /// <returns>Boolean. Se a operação foi um sucesso, true.</returns>
        /// <remarks></remarks>
        public bool DeleteFamilia(int intFamilia)
        {
            bool blnRetorno = false;
            Data.FamiliaCrianca oDados = null;
            try
            {
                oDados = new Data.FamiliaCrianca();
                blnRetorno = oDados.DeleteFamilia(intFamilia);

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


        /// <summary>
        /// Método para excluir o registro
        /// </summary>
        /// <param name="intFamilia">Familia</param>
        /// <param name="intCrianca">Criança</param>
        /// <returns>Boolean. Se a operação foi um sucesso, true.</returns>
        /// <remarks></remarks>
        public bool DeleteCrianca(int intFamilia, int intCrianca)
        {
            bool blnRetorno = false;
            Data.FamiliaCrianca oDados = null;
            try
            {
                oDados = new Data.FamiliaCrianca();
                blnRetorno = oDados.DeleteCrianca(intFamilia, intCrianca);

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

        public List<Model.Criancas> ObterCriancasByFamilia(int intFamilia)
        {

            List<Model.Criancas> lstDados = null;
            Data.FamiliaCrianca oDados = null;
            try
            {
                oDados = new Data.FamiliaCrianca();
                lstDados = oDados.ObterCriancasByFamilia(intFamilia);

            }
            catch (Exception ex)
            {
                lstDados = null;
                throw ex;
            }
            finally
            {
                oDados = null;
            }

            return lstDados;

        }

        public List<Model.Criancas> ObterCriancasByFamiliaWithRep(int intFamilia)
        {

            List<Model.Criancas> lstDados = null;
            Data.FamiliaCrianca oDados = null;
            try
            {
                oDados = new Data.FamiliaCrianca();
                lstDados = oDados.ObterCriancasByFamiliaWithRep(intFamilia);

            }
            catch (Exception ex)
            {
                lstDados = null;
                throw ex;
            }
            finally
            {
                oDados = null;
            }

            return lstDados;

        }
    }
}