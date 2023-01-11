// Boleto; Cartão; Pix; Dinheiro

class Program
    {
        static void Main(string[] args)
        {
            var cartao = new Cartão();
            Console.WriteLine(cartao.Mensagem());
            Console.WriteLine(cartao.CodigoTransacao());
            Console.ReadKey();
        }
    }

abstract class Pagamento
{
    public virtual string Mensagem()
    {
        return "Método Inexistente.";
    }
    public virtual int ValorTransacao()
    {
        return 00;
    }
    public virtual string CodigoTransacao()
    {
        return "00000000000000";
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
        public override string CodigoTransacao()
        {
            string result = base.CodigoTransacao();
            result = "Código de barras: 67890880203908987";
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
            public override string CodigoTransacao()
        {
            string result = base.CodigoTransacao();
            result = "Valor da fatura: R$55,60";
            return result;
        }
}
class Pix : Pagamento
{
    public void Pagar(ModosPix modo)
    {
        Console.WriteLine("Pago");
    }

    public override string Mensagem()
    {
        string result = base.Mensagem();
        result = "Método: Pix.";
        return result;
    }
   public override string CodigoTransacao()
    {
        string result = base.CodigoTransacao();
        result = "Solução indisponível.";
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
   public override string CodigoTransacao()
    {
        string result = base.CodigoTransacao();
        result = "Tamo grande!";
        return result;
    }
    
}
