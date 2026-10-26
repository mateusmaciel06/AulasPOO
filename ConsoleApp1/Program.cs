using System;
using System.Collections.Generic;

// 1. Passar os produtos para um Dictionary<string, Produto>, indexado pelo Codigo
Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

produtos["PAR-001"] = new Produto("PAR-001", 50);
produtos["PAR-002"] = new Produto("PAR-002", 5);
produtos["PAR-003"] = new Produto("PAR-003", 8);

// 2. Ir buscar e mostrar um produto específico pelo código ("PAR-001")
if (produtos.ContainsKey("PAR-002"))
{
    Produto p = produtos["PAR-002"];
    p.Mostrar();
}

Console.WriteLine("--- todos os produtos ---");

// 3. Percorrer o dicionário todo com foreach (sobre .Values) e mostrar cada produto
foreach (Produto p in produtos.Values)
{
    p.Mostrar();
}

// ==========================================================
// Definição da classe Produto (necessária para o código correr)
// ==========================================================
public class Produto
{
    public string Codigo { get; set; }
    public int Quantidade { get; set; }

    public Produto(string codigo, int quantidade)
    {
        Codigo = codigo;
        Quantidade = quantidade;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Produto {Codigo}: {Quantidade} unidades");
    }
}