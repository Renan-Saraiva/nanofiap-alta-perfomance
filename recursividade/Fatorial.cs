namespace recursividade
{
    public class Fatorial
    {

        private int Valor { get; set; }

        public Fatorial(int valor)
        {
            this.Valor = valor;
        }

        public int Calcular()
        {
            return CalcularFatorial(Valor);
        }

        private int CalcularFatorial(int valor) 
            => valor == 0 ? 1 : valor * CalcularFatorial(valor - 1);
    }
}
