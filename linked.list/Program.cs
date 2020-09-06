using System;

namespace linked.list
{
    class Program
    {
        static void Main(string[] args)
        {

            ILista<int> itemsPilha = new Pilha<int>();

            itemsPilha.Add(1);
            itemsPilha.Add(2);
            itemsPilha.Add(3);
            itemsPilha.Add(4);
            itemsPilha.Add(5);
            itemsPilha.Add(6);
            itemsPilha.Add(7);

            Testar(itemsPilha);

            itemsPilha.Add(1);
            itemsPilha.Add(2);
            itemsPilha.Add(3);

            Testar(itemsPilha);

            ILista<int> itemsFila = new Fila<int>();

            itemsFila.Add(1);
            itemsFila.Add(2);
            itemsFila.Add(3);
            itemsFila.Add(4);
            itemsFila.Add(5);
            itemsFila.Add(6);
            itemsFila.Add(7);

            Testar(itemsFila);

            itemsFila.Add(1);
            itemsFila.Add(2);
            itemsFila.Add(3);

            Testar(itemsFila);
        }


        public static void Testar(ILista<int> items) 
        {
            items.ImprimirTodos();
            items.ProcessarTodos();
            items.ImprimirTodos();
        }
    }
}
