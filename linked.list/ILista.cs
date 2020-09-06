using System;
using System.Collections.Generic;
using System.Text;

namespace linked.list
{
    public interface ILista<T>
    {
        void Add(T dado);
        void ImprimirTodos();
        void ProcessarTodos();
    }

    public class ItemLista<T>
    {
        public ItemLista(T dado)
        {
            this.Dado = dado;
        }

        public T Dado { get; set; }
        public ItemLista<T> Proximo { get; set; }
    }
}
