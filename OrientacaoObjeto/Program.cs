string telefone, celular, email;
Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Pessoa p3 = new Pessoa();


Pessoa AdicionarContato()
{
    Pessoa p = new Pessoa();
    p.Nome = p.DefinirNome();
    p.Sobrenome = p.DefinirSobrenome();
    p.Idade = p.DefinirIdade();

    Console.Write("Informe o telefone: ");
    telefone = Console.ReadLine();
    p.DefinirTelefone(telefone);

    Console.Write("Informe o celular: ");
    celular = Console.ReadLine();
    p.DefinirCelular(celular);

    Console.Write("Informe o Email: ");
    email = Console.ReadLine();
    p.DefinirEmail(email);

    return p;
}

Console.WriteLine("Informe os dados do Contato 1");
p1 = AdicionarContato();

Console.WriteLine("Informe os dados do Contato 2");
p2 = AdicionarContato();

Console.WriteLine("Informe os dados do Contato 3");
p3 = AdicionarContato();


Console.WriteLine("----Dados----");
Console.WriteLine("Contato 1 ");
p1.MostrarDados();

Console.WriteLine();
Console.WriteLine("Contato 2");
p2.MostrarDados();

Console.WriteLine();
Console.WriteLine("Contato 3");
p3.MostrarDados();

Console.ReadLine();