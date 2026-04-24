using System;

while (true)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("STATUS DO SISTEMA: [OPERACIONAL]");
    Console.ResetColor();

    Console.WriteLine("----------------------------------");
    Console.WriteLine("COMANDOS DISPONÍVEIS:");
    Console.WriteLine("> PING  - Testar conexão");
    Console.WriteLine("> RESET - Reiniciar servidor (Crítico)");
    Console.WriteLine("> HELP  - Ajuda");
    Console.WriteLine("> SAIR  - Fechar terminal");

    Console.Write("\nDigite um comando: ");
    string comando = Console.ReadLine().ToUpper();

    if(comando == "PING")
    {
        Console.Clear();

        Console.WriteLine("=== DIAGNÓSTICO DE REDE ===");
        Console.WriteLine("Formato esperado: xxx.xxx.xxx.xxx");

        Console.Write("Digite o IP de destino: ");
        string ip = Console.ReadLine();

        if(string.IsNullOrEmpty(ip) || !ip.Contains("."))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERRO: IP inválido.");
            Console.WriteLine("Use formato xxx.xxx.xxx.xxx");
            Console.ResetColor();

            Console.ReadKey();
            continue;
        }

        Console.WriteLine("\nEnviando pacotes...");
        Thread.Sleep(1500);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Resposta recebida com sucesso.");
        Console.ResetColor();

        Console.ReadKey();
    }

    else if(comando=="RESET")
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("!!! AVISO DE SEGURANÇA !!!");
        Console.ResetColor();

        Console.WriteLine("Você solicitou reboot do servidor.");
        Console.Write("Tem certeza? (S/N): ");

        string conf = Console.ReadLine().ToUpper();

        if(conf=="S")
        {
            Console.WriteLine("\nReiniciando sistema...");
            Thread.Sleep(1500);

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Servidor Online.");
            Console.ResetColor();
        }

        else
        {
            Console.WriteLine("Operação cancelada.");
        }

        Console.ReadKey();
    }

    else if(comando=="HELP" || comando=="?")
    {
        Console.Clear();

        Console.WriteLine("=== CENTRAL DE AJUDA ===");
        Console.WriteLine("- PING: Testa conexão.");
        Console.WriteLine("- RESET: Reinicia servidor.");
        Console.WriteLine("- SAIR: Fecha terminal.");

        Console.ReadKey();
    }

    else if(comando=="SAIR")
    {
        break;
    }

    else
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("\nERRO: Comando não reconhecido.");
        Console.WriteLine("Digite HELP para ajuda.");
        Console.ResetColor();

        Console.ReadKey();
    }
}