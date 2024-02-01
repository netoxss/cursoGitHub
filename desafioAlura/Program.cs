void TituloOpcao(string titulo)
{
    int tamanho = titulo.Length;
    string asterisco = "";

    for (int i = 0; i < titulo.Length; i++)
    {
        asterisco = String.Empty.PadLeft(tamanho, '*');
    }
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco);
}

TituloOpcao("teste");