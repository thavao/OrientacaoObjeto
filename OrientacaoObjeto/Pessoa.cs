using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pessoa
{
    public string Nome;
    public string Sobrenome;
    public int Idade;
    public string Telefone;
    public string Celular;
    public string Email;

    public Pessoa()
    {

    }

    public string  DefinirNome()
    {
        Console.Write("Digite o nome: ");
        return Console.ReadLine();
    }
    public string DefinirSobrenome()
    {
        Console.Write("Digite o sobrenome: ");
        return Console.ReadLine();
    }
    public int DefinirIdade()
    {
        Console.Write("Digite a idade: ");
        return int.Parse(Console.ReadLine());
    }
    
    public void DefinirTelefone(string telefone)
    {
        this.Telefone = telefone;
    }
    public void DefinirCelular(string celular)
    {
        this.Celular = celular;
    }

    public void DefinirEmail(string email)
    {
        this.Email = email;
    }

    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Sobrenome: " + this.Sobrenome);
        Console.WriteLine("Idade: " + this.Idade);
        Console.WriteLine($"Telefone: {this.Telefone}");
        Console.WriteLine($"Celular: {this.Celular}");
        Console.WriteLine("Email: " + this.Email);
    }
}

