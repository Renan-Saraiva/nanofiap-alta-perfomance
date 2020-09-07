using System;
using System.Collections.Generic;
using System.Text;

namespace linked.list
{
    public class Pilha<T>
    {
        private ItemLista<T> Ultimo { get; set; }

        public void Push(T dado) 
        {
            var item = new ItemLista<T>(dado);

            if (IsEmpty())
                this.Ultimo = item;
            else
            {
                item.Proximo = this.Ultimo;
                this.Ultimo = item;
            }
        }

        public Tuple<bool, T> Pop()
        {
            if (!IsEmpty()) 
            {
                ItemLista<T> Saida = Ultimo;
                Ultimo = Ultimo.Proximo;
                return Tuple.Create<bool, T>(true, Saida.Dado);
            }

            return Tuple.Create<bool, T>(false, default(T));
        }

        public Tuple<bool, T> Top()
        {
            if (IsEmpty())
                return Tuple.Create<bool, T>(false, default(T));

            return Tuple.Create<bool, T>(true, Ultimo.Dado);
        }

        public bool IsEmpty() => Ultimo is null;

        public void ImprimirTodos()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Nenhum item a ser impresso");
                return;
            }

            ImprimirItem(Ultimo, true);
        }

        private void ImprimirItem(ItemLista<T> item, bool recursivo = false)
        {
            Console.WriteLine($"Item pilha impresso: {item.Dado}");

            if (item.Proximo != null && recursivo)
                ImprimirItem(item.Proximo, recursivo);
        }

        public void ProcessarTodos()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Nenhum item a ser processado");
                return;
            }

            Processar(Ultimo, true);
        }

        private void Processar(ItemLista<T> item, bool recursivo = false)
        {
            Console.WriteLine($"Item pilha processado: {item.Dado}");

            Ultimo = item.Proximo;

            if (!IsEmpty() && recursivo)
                Processar(Ultimo, recursivo);
        }
    }
}
