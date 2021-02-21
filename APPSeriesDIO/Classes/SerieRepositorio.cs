using System;
using System.Collections.Generic;
using APPSeriesDIO.Interfaces;

// Projeto, integralmente, criado seguindo os passos do curso "Criando um APP simples de cadastro de séries em .NET - Eliézer Zarpelão (Github: elizarp)" - DIO
namespace APPSeriesDIO
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
		private List<Serie> listaSerie = new List<Serie>();

		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}