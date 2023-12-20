namespace trilha_net_poo_desafio.Models
{
    public class Samsung : Smartphone
    {
        // Implementação específica para instalar aplicativo em Samsung
        public Samsung(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no Samsung");
        }
    }

}
