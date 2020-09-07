using System;

namespace linked.list
{
    class Program
    {
        static void Main(string[] args)
        {

            Pilha<int> itemsPilha = new Pilha<int>();

            itemsPilha.Push(1);
            itemsPilha.Push(2);
            itemsPilha.Push(3);
            itemsPilha.Push(4);
            itemsPilha.Push(5);
            itemsPilha.Push(6);
            itemsPilha.Push(7);

            itemsPilha.ImprimirTodos();

            itemsPilha.Pop();
            itemsPilha.Pop();
            itemsPilha.Pop();

            itemsPilha.ImprimirTodos();

            itemsPilha.Pop();
            itemsPilha.Pop();
            itemsPilha.Pop();
            itemsPilha.Pop();
            itemsPilha.Pop();

            itemsPilha.ImprimirTodos();

            Fila<int> itemsFila = new Fila<int>();

            itemsFila.EnQueue(1);
            itemsFila.EnQueue(2);
            itemsFila.EnQueue(3);
            itemsFila.EnQueue(4);
            itemsFila.EnQueue(5);
            itemsFila.EnQueue(6);
            itemsFila.EnQueue(7);

            itemsFila.ImprimirTodos();

            itemsFila.DeQueue();
            itemsFila.DeQueue(); 
            itemsFila.DeQueue();
            itemsFila.DeQueue();

            itemsFila.ImprimirTodos();

            itemsFila.DeQueue();
            itemsFila.DeQueue();
            itemsFila.DeQueue();
            
            itemsFila.ImprimirTodos();

            itemsFila.EnQueue(1);
            itemsFila.EnQueue(2);
            itemsFila.EnQueue(3);

            itemsFila.ImprimirTodos();
        }
    }
}
