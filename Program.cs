using Atividade;

float value;
string type;
string name;
string address;


Console.Clear();


while (true)
{
    Console.WriteLine("Informar nome: ");
    name = Console.ReadLine();
    if (name == string.Empty)
    {
        Console.WriteLine("Digite um nome");
    }
    else
    {
        Console.Clear();
        break;
    }
}

while (true)
{
    Console.WriteLine("Informar endereço: ");
    address = Console.ReadLine();

    if (address == string.Empty)
    {
        Console.WriteLine("Digite um endereço");
    }
    else
    {
        Console.Clear();
        break;
    }
}



while (true)
{
    Console.WriteLine("Pessoa Física ou Jurídica? (PF / PJ)");
    type = Console.ReadLine();
    if (type == "" || type != "pf" && type != "PF" && type != "pj" && type != "PJ")
    {
        Console.WriteLine("Digite um tipo válido para pessoa");
    }
    else
    {
        Console.Clear();
        break;
    }
}

if (type == "pf" || type == "PF")
{
    Console.Clear();
    Pessoa_física pf = new Pessoa_física();
    pf.nome = name;
    pf.endereco = address;

    while (true)
    {
        Console.WriteLine("Informar CPF: ");
        pf.cpf = Console.ReadLine();
        Console.WriteLine("\n");


        Console.WriteLine("Informar RG: \n");
        pf.rg = Console.ReadLine();
        Console.WriteLine("\n");


        Console.WriteLine("informar valor da compra: \n");
        value = float.Parse(Console.ReadLine());

        if (pf.cpf.Length != 11)
        {
            Console.Clear();
            Console.WriteLine("Um CPF válido deve conter 11 dígitos \n");
        }
        else if (pf.rg.Length < 9)
        {
            Console.Clear();
            Console.WriteLine("Um RG válido de conter ao menos 9 dígitos \n");
        }
        else if (value == 0 || value < 0)
        {
            Console.Clear();
            Console.WriteLine("Digite um valor de compra maior do que zero \n");
        }
        else
        {
            break;
        }
    }
    Console.Clear();

    pf.Pagar_imposto(value);
    Console.WriteLine("---------- Pessoa Física ----------\n");
    Console.WriteLine("Nome ...........: " + pf.nome);
    Console.WriteLine("Endereço .......: " + pf.endereco);
    Console.WriteLine("CPF ............: " + pf.cpf);
    Console.WriteLine("RG .............: " + pf.rg);
    Console.WriteLine("Valor de Compra : " + pf.valor.ToString("C"));
    Console.WriteLine("Imposto ........: " + pf.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar   : " + pf.total.ToString("C"));
}
else if (type == "pj" || type == "PJ")
{
    Console.Clear();
    Pessoa_juridica pj = new Pessoa_juridica();
    pj.nome = name;
    pj.endereco = address;

    while (true)
    {
        Console.WriteLine("Informar CNPJ: ");
        pj.cnpj = Console.ReadLine();
        Console.WriteLine("\n");


        Console.WriteLine("Informar IE (Inscrição Estadual): \n");
        pj.ie = Console.ReadLine();
        Console.WriteLine("\n");


        Console.WriteLine("informar valor da compra: \n");
        value = float.Parse(Console.ReadLine());

        if (pj.cnpj.Length < 14)
        {
            Console.Clear();
            Console.WriteLine("Um CNPJ válido deve conter 14 dígitos \n");
        }
        else if (pj.ie.Length <= 0)
        {
            Console.Clear();
            Console.WriteLine("Digite uma IE válida! \n");
        }
        else if (value == 0 || value < 0)
        {
            Console.Clear();
            Console.WriteLine("Digite um valor de compra maior do que zero \n");
        }
        else
        {
            break;
        }
    }
    Console.Clear();

    pj.Pagar_imposto(value);
    Console.WriteLine("---------- Pessoa Jurídica ----------\n");
    Console.WriteLine("Nome ...........: " + pj.nome);
    Console.WriteLine("Endereço .......: " + pj.endereco);
    Console.WriteLine("CNPJ ...........: " + pj.cnpj);
    Console.WriteLine("IE .............: " + pj.ie);
    Console.WriteLine("Valor de Compra : " + pj.valor.ToString("C"));
    Console.WriteLine("Imposto ........: " + pj.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar   : " + pj.total.ToString("C"));
}
