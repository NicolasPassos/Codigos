namespace _5___ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        private int _agenciaConta;
        public int numeroConta;
        private double _saldoConta;

        public static int TotalContasCriadas { get; private set; }


        public double Saldo
        {
            get
            {
                return _saldoConta;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldoConta = value;
            }
        }

        public int Agencia
        {
            get
            {
                return _agenciaConta;
            }
            set
            {
                if(value <= 0)
                { 
                    return; 
                }
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            numeroConta = numero;
            _agenciaConta = agencia;

            TotalContasCriadas++;
        }


        public bool Sacar(double valorSaque)
        {
            if (this._saldoConta < valorSaque)
            {
                return false;
            }
            else
            {
                this._saldoConta -= valorSaque;
                return true;
            }
        }
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            this._saldoConta += valorDeposito;
        }

        public bool Transferir(double valorTransferencia, ContaCorrente contaDestino)
        {
            if (this._saldoConta < valorTransferencia)
            {
                return false;
            }
            else
            {
                this._saldoConta -= valorTransferencia;
                contaDestino.Depositar(valorTransferencia);

                return true;

            }
        }
    }
}