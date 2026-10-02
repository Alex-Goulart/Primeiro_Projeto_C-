// Mensagem que será exibida na tela inicial
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 5});
bandasRegistradas.Add("Evanescence", new List<int> ());

// Função responsável por exibir o logo e a mensagem de boas-vindas
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

// Função responsável por exibir o menu principal
void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opção desejada: "); // Solicita ao usuário que escolha uma opção
    string opcaoEscolhida = Console.ReadLine()!; // Lê a opção digitada pelo usuário
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); // Converte a opção de string para inteiro

    // Verifica qual opção foi escolhida
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas(); // Se escolher 1, chama a função para registrar uma banda
            break;
        case 2: MostrarBandasRegistradas(); // Se escolher 2, chama a função para mostrar as bandas cadastradas
            break;
        case 3: AvaliarUmaBanda(); // Se escolher 3, chama a função para avaliar uma banda
            Console.WriteLine("Você escolheu a opção:" + opcaoEscolhida);
            break;
        case 4: // Se escolher 4, futuramente chamará a função para exibir a média
            Console.WriteLine("Você escolheu a opção:" + opcaoEscolhida);
            break;
        case 0: // Se escolher 0, encerra o programa
            Console.WriteLine("Tchau!! Encerrar o programa..");
            break;
        default: // Caso o usuário digite uma opção que não existe
            Console.WriteLine("Opção Inválida!!");
            break;
    }
}

//Função para registrar as bandas
void RegistrarBandas()
{ 
    Console.Clear(); // Limpa o conteúdo atual do console
    ExibirTituloOpcao("Registrar Bandas"); // Exibe o título da opção escolhida
    Console.WriteLine("Registre uma Banda!"); // Informa ao usuário que ele está na tela de cadastro
    Console.Write("Digite o nome da banda que deseja registrar: "); // Solicita o nome da banda
    string nomeDaBanda = Console.ReadLine()!; // Armazena o nome digitado pelo usuário
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!"); // Informa que a banda foi cadastrada com sucesso
    Thread.Sleep(2000); // Aguarda 2 segundos antes de continuar
    Console.Clear();
    ExibirMenu(); // Retorna para o menu principal
}

 // Função responsável por mostrar todas as bandas cadastradas
void MostrarBandasRegistradas()
{
    Console.Clear(); // Limpa o conteúdo atual do console
    ExibirTituloOpcao("Mostrar Bandas Registradas"); // Exibe o título da opção
    Console.WriteLine("Exibindo todas as bandas registrads!!!\n"); // Exibe uma mensagem informando que as bandas serão mostradas

    // Percorre cada banda existente na lista
    foreach (string banda in bandasRegistradas.Keys) 
    {
        Console.WriteLine($"Banda: {banda}");
    }

    // Solicita que o usuário pressione uma tecla antes de retornar ao menu
    Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!"); 
    Console.ReadKey();
    Console.Clear(); // Limpa o console
    ExibirMenu(); // Retorna para o menu principal
}

void AvaliarUmaBanda()
{

}

// Função responsável por deixar o título de cada opção visualmente mais organizado
void ExibirTituloOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length; // Obtém a quantidade de caracteres existente no título
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*'); // Cria uma sequência de asteriscos com a mesma quantidade de caracteres existentes no título
    Console.WriteLine(asterisco); // Exibe os asteriscos acima do título
    Console.WriteLine(titulo); // Exibe o título
    Console.WriteLine(asterisco + "\n"); // Exibe os asteriscos abaixo do título e pula uma linha
}

// Inicia o programa chamando o menu principal
ExibirMenu();
