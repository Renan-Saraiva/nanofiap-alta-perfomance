using System;
using System.Collections.Generic;
using System.Text;

namespace linked.list
{
    public class Fila<T>
    {
        private ItemLista<T> Ultimo { get; set; }
        private ItemLista<T> Primeiro { get; set; }

        public void EnQueue(T dado)
        {
            var item = new ItemLista<T>(dado);

            if (this.Primeiro is null)
                this.Primeiro = item;
            else if (this.Ultimo is null)
            {
                this.Ultimo = item;
                this.Primeiro.Proximo = this.Ultimo;
            }
            else
            {
                this.Ultimo.Proximo = item;
                this.Ultimo = item;
            }
        }

        public Tuple<bool, T> DeQueue()
        {
            if (!IsEmpty())
            {
                ItemLista<T> Saida = Primeiro;
                Primeiro = Primeiro.Proximo;

                if (object.ReferenceEquals(Saida, Ultimo))
                    Ultimo = null;

                return Tuple.Create<bool, T>(true, Saida.Dado);
            }

            return Tuple.Create<bool, T>(false, default(T));
        }

        public Tuple<bool, T> First()
        {
            if (IsEmpty())
                return Tuple.Create<bool, T>(false, default(T));

            return Tuple.Create<bool, T>(true, Primeiro.Dado);
        }

        public bool IsEmpty() => Primeiro is null;

        public void ImprimirTodos()
        {
            if (Primeiro is null)
            {
                Console.WriteLine($"Nenhum item a ser impresso");
                return;
            }

            ImprimirItem(Primeiro, true);
        }

        private void ImprimirItem(ItemLista<T> item, bool imprimirProximo = false)
        {
            Console.WriteLine($"Item fila impresso: {item.Dado}");

            if (item.Proximo != null && imprimirProximo)
                ImprimirItem(item.Proximo, imprimirProximo);
        }

        public void ProcessarTodos()
        {
            if (Primeiro is null)
            {
                Console.WriteLine($"Nenhum item a ser processado");
                return;
            }

            Processar(Primeiro, true);
        }

        private void Processar(ItemLista<T> item, bool processarProximo = false)
        {
            Console.WriteLine($"Item fila processado: {item.Dado}");

            Primeiro = item.Proximo;

            if (object.ReferenceEquals(item, Ultimo))
                Ultimo = null;

            if (IsEmpty() && processarProximo)
                Processar(Primeiro, processarProximo);
        }
    }
}
