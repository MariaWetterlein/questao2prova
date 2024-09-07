using System;
using System.Collections.Generic;

public class Cliente
{
	private string nome;
	private string endereco;


	public Cliente(string nome, string endereco)
	{
		this.nome = nome;
		this.endereco = endereco;
	}

	public string GetNome()
	{
		return nome;
	}

	public string GetEndereco()
	{
		return endereco;
	}
}
