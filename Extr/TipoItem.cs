
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class TipoItem : BaseData<Model.TipoItem, int>
{

	public TipoItem() : base()
	{
	}

	/// <summary>
	/// Método para inserir o registro
	/// </summary>
	/// <param name="oTipo">Entidade com os dados Preenchidos</param>
	/// <returns>Boolean. Se a operação foi um sucesso, true.</returns>
	/// <remarks></remarks>
	public override bool Insert(Model.TipoItem oTipo)
	{

		return base.Insert(oTipo);

	}

	/// <summary>
	/// Método para atualizar o registro
	/// </summary>
	/// <param name="oTipo">Entidade com os dados Preenchidos</param>
	/// <returns>Boolean. Se a operação foi um sucesso, true.</returns>
	/// <remarks></remarks>
	public override bool Update(Model.TipoItem oTipo)
	{

		return base.Update(oTipo);

	}

	/// <summary>
	/// Método para excluir o registro
	/// </summary>
	/// <param name="oTipo">Entidade com os dados Preenchidos</param>
	/// <returns>Boolean. Se a operação foi um sucesso, true.</returns>
	/// <remarks></remarks>
	public override bool Delete(Model.TipoItem oTipo)
	{

		return base.Delete(oTipo);

	}

	/// <summary>
	/// Método para procurar um registro
	/// </summary>
	/// <param name="Identifier">Código para a Procura do Valor</param>
	/// <returns>Entidade. Se a operação foi um sucesso, A Entidade Virá preenchida.</returns>
	/// <remarks></remarks>
	public override Model.TipoItem Find(int Identifier)
	{

		return base.Find(Identifier);

	}

	/// <summary>
	/// Método para carregar a lista dos registros
	/// </summary>
	/// <returns>Lista. Se a operação foi um sucesso, a lista virá carregada.</returns>
	/// <remarks></remarks>
	public override IList<Model.TipoItem> LoadAll()
	{

		return base.LoadAll;

	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================