using System;
using System.Collections.Generic;


public class Produto
{
    private string nome;
    private double preco;

    public Produto(string nome, double preco)
    {
        this.nome = nome;
        this.preco = preco;
    }

    public string GetNome()
    {
        return nome;
    }

    public double GetPreco()
    {
        return preco;
    }
}