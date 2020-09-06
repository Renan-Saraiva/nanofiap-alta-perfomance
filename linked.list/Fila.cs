using System;
using System.Collections.Generic;
using System.Text;

namespace linked.list
{
    public class Fila<T> : ILista<T>
    {
        private ItemLista<T> Ultimo { get; set; }
        private ItemLista<T> Primeiro { get; set; }

        public void Add(T dado)
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

        public void ImprimirTodos()
        {
            if (Primeiro is null)
            {
                Console.WriteLine($"Nenhum item a ser impresso");
                return;
            }

            ImprimirItem(Primeiro, true);
        }

        private void ImprimirItem(ItemLista<T> item, bool recursivo = false)
        {
            Console.WriteLine($"Item fila impresso: {item.Dado}");

            if (item.Proximo != null && recursivo)
                ImprimirItem(item.Proximo, recursivo);
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

        public void Processar(ItemLista<T> item, bool processarProximo = false)
        {
            Console.WriteLine($"Item fila processado: {item.Dado}");

            Primeiro = item.Proximo;

            if (item.Equals(Ultimo))
                Ultimo = null;

            if (Primeiro != null && processarProximo)
                Processar(Primeiro, processarProximo);
        }
    }
}
