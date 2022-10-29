using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<string> node1 = new Node<string>("Mike", null);
            Node<string> node2 = new Node<string>("Raymond", node1);
            Console.WriteLine($"Node1 Data: {node1.GetData()}\nNode1 Link: {node1.GetLink()}");
            Console.WriteLine($"Node2 Data: {node2.GetData()}\nNode2 Link: node1 data: {node2.GetLink().Data} or node1 link: {node2.GetLink().Link}");

            int num1 = 100;
            int num2 = 200;
            Console.WriteLine($"num1: {num1}\nnum2: {num2}");
            Swap<int>(ref num1, ref num2);
            Console.WriteLine($"new num1: {num1}\nnew num2: {num2}");

            string str1 = "Yunus";
            string str2 = "Emre";
            Console.WriteLine($"str1: {str1}\nstr2: {str2}");
            Swap<string>(ref str1, ref str2);
            Console.WriteLine($"new str1: {str1}\nnew str2: {str2}");
            Console.ReadLine();
        }
        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
    public class Node<T>
    {
        T data;
        Node<T> link;
        public Node(T data, Node<T> link)
        {
            this.data = data;
            this.link = link;
        }
        public T Data
        {
            get { return data; }
            set { data = value; }
            //set { data = Data; }
        }
        public Node<T> Link
        {
            get { return link; }
            set { link = value; }
            //set { link = Link; }
        }
        public T GetData()
        {
            return data;
        }
        public Node<T> GetLink()
        {
            return link;
        }
    }
}
