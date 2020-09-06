using System;
using System.Collections.Generic;
using System.Text;

namespace linked.list
{
    public class Pilha<T> : ILista<T>
    {
        private ItemLista<T> Ultimo { get; set; }

        public void Add(T dado) 
        {
            var item = new ItemLista<T>(dado);

            if (this.Ultimo is null)
                this.Ultimo = item;
            else
            {
                item.Proximo = this.Ultimo;
                this.Ultimo = item;
            }
        }

        public void ImprimirTodos()
        {
            if (Ultimo is null)
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
            if (Ultimo is null) 
            {
                Console.WriteLine($"Nenhum item a ser processado");
                return;
            }

            Processar(Ultimo, true);
        }

        public void Processar(ItemLista<T> item, bool recursivo = false)
        {
            Console.WriteLine($"Item pilha processado: {item.Dado}");

            Ultimo = item.Proximo;

            if (Ultimo != null && recursivo)
                Processar(Ultimo, recursivo);
        }
    }
}
