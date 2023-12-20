using trilha_net_poo_desafio.Models;

        Console.WriteLine("Smartphone Samsung");
        Smartphone samsung = new Samsung(numero:"92712360,", modelo: "Galaxy s23 ultra", imei:"689751364079821",memoria:500);
        samsung.Ligar();
        samsung.ReceberLigacao();
        samsung.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iPhone");
        Smartphone iphone = new Iphone(numero:"86579402", modelo: "iPhone 15 plus", imei:"798467849257381", memoria: 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

