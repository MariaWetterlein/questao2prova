using System;
using System.Collections.Generic;

public class Pedido
{

	private List<Produto> produtos;
	private Cliente cliente;
	public Pedido (Cliente cliente)
	
	{
		this.cliente = cliente;
		this.produtos = new List<Produto> ;
	}
	
	public void AdicionarProduto(Produto produto)
	{
		produtos.Add(produto);
	}

	public object BuscarPorNome(string nome) 
	{
	
		
			if (produto.GetNome() == nome)
			{
				return produto;
			}
		

		if (cliente.GetNome() == nome)
		{
			return cliente;
		}

		return null;
	}