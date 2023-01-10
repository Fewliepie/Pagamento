// Boleto; Cartão; Pix; Dinheiro

class Program
    {
        static void Main(string[] args)
        {
            Pix pix = new Pix();
            Console.WriteLine(pix.Mensagem());
            Console.ReadKey();
        }
    }

abstract class Pagamento
{
    public virtual string Mensagem()
    {
        return "Método inexistente.";
    }
}
class Boleto : Pagamento
    {
        public override string Mensagem()
        {
            string result = base.Mensagem();
            result = "Método: boleto.";
            return result;
        }

    }
class Cartão : Pagamento
{
    public override string Mensagem()
    {
        string result = base.Mensagem();
        result = "Método: Cartão.";
        return result;
    }
}
class Pix : Pagamento
{
    public override string Mensagem()
    {
        string result = base.Mensagem();
        result = "Método: Pix.";
        return result;
    }
}
class Dinheiro : Pagamento
{
    public override string Mensagem()
    {
        string result = base.Mensagem();
        result = "Método: Dinheiro.";
        return result;
    }
}
