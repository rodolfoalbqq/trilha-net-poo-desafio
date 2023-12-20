namespace trilha_net_poo_desafio.Models
{
    public class Iphone : Smartphone
    {
        // Implementação específica para instalar aplicativo em iPhone
        public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine("Metodo chamado com sucesso");
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no iPhone");
        }
    }
}
