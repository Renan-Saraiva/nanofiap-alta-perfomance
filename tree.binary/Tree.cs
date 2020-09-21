using System;
using System.Collections.Generic;
using System.Text;

namespace tree.binary
{
    public class TreeBinary
    {
        private TreeItem Root { get; set; }

        public bool IsEmpty() => Root == null;

        public void Add(int data)
        {
            var treeItem = new TreeItem(data);

            if (IsEmpty())
                Root = treeItem;
            else
                Add(Root, treeItem);
        }

        private void Add(TreeItem currentItem, TreeItem newItem)
        {
            if (currentItem.Data == newItem.Data)
                return;
            else
            {
                if (newItem.Data > currentItem.Data) 
                {
                    if (currentItem.Right is null)
                        currentItem.Right = newItem;
                    else
                    {
                        Add(currentItem.Right, newItem);
                    }
                }
                else 
                {
                    if (currentItem.Left is null)
                        currentItem.Left = newItem;
                    else
                    {
                        Add(currentItem.Left, newItem);
                    }
                }
            }
        }

        public void Print(Order order = Order.Asc)
        {
            if (IsEmpty())
                Console.WriteLine("Tree is empty");
            else
            {
                if (Order.Asc == order)
                    PrintAsc(Root);
                else
                    PrintDesc(Root);

            }
        }

        private void PrintAsc(TreeItem item)
        {
            if (item is null)
                return;

            PrintAsc(item.Left);
            Console.Write($"{item.Data},");
            PrintAsc(item.Right);
        }

        private void PrintDesc(TreeItem item)
        {
            if (item is null)
                return;

            PrintDesc(item.Right);
            Console.Write($"{item.Data},");
            PrintDesc(item.Left);
        }
    }

    class TreeItem
    {
        public TreeItem Left { get; set; }
        public int Data { get; set; }
        public TreeItem Right { get; set; }

        public TreeItem(int data) 
        {
            Data = data;
        }
    }

    public enum Order
    {
        Asc = 1,
        Desc = 2
    }
}
