namespace _5___ByteBank
{   
    public class ContaCorrente
    {
        public Cliente titular;
        public int agenciaConta;
        public int numeroConta;
        private double saldoConta;
        
        public double ObterSaldo()
        {
            return saldoConta;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.saldoConta < valorSaque)
            {
                return false;
            }
            else
            {
                this.saldoConta -= valorSaque;
                return true;
            }
        }
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            this.saldoConta += valorDeposito;
        }

        public bool Transferir(double valorTransferencia, ContaCorrente contaDestino)
        {
            if (this.saldoConta < valorTransferencia)
            {
                return false;
            }
            else
            {
                this.saldoConta -= valorTransferencia;
                contaDestino.Depositar(valorTransferencia);

                return true;

            }
        }
    }
}