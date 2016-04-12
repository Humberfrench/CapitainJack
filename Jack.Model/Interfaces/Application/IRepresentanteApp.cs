﻿using System.Collections.Generic;


namespace Jack.Model
{
    public interface IRepresentanteApp
    {
        bool Add(int intFamilaRepresentante, int intFamilaRepresentada);
        bool Del(int intFamilaRepresentante, int intFamilaRepresentada);
        List<Familia> ObterMaes(int intFamilia);
    }
}