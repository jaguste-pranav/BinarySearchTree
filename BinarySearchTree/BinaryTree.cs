using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeProgram
{
    class BinaryTree<T> where T : IComparable
    {
        Node<T> root;
        Node<T> current;
        int count = 0;
        bool result = false;
        public void addToData(T data)
        {
            if (root == null)
            {
                this.root = new Node<T>(data);
                this.current = root;
                count++;
                return;
            }
            if (this.current.NodeValue.CompareTo(data) > 0)
            {
                if (this.current.LeftNode == null)
                {
                    this.current.LeftNode = new Node<T>(data);
                    this.current = root;
                    count++;

                }
                else
                {
                    this.current = this.current.LeftNode;
                    addToData(data);
                }
            }
            else
            {
                if (this.current.RightNode == null)
                {
                    this.current.RightNode = new Node<T>(data);
                    this.current = root;
                    count++;
                }
                else
                {
                    this.current = this.current.RightNode;
                    addToData(data);
                }
            }

        }


        public Node<T> getRoot()
        {
            return this.root;
        }
        public void display(Node<T> node)
        {
            if (node != null)
            {
                display(node.LeftNode);
                Console.WriteLine(" " + node.NodeValue);
                display(node.RightNode);
            }

        }
        public int getSize()
        {
            return count;
        }

        public bool search(int data, Node<T> node)
        {

            if (node == null)
            {
                return false;
            }
            else
            {
                if (this.current.NodeValue.Equals(data))
                {
                    result = true;
                }
                else if (this.current.NodeValue.CompareTo(data) > 0)
                {
                    this.current = this.current.LeftNode;
                    search(data, current);
                }
                else
                {
                    this.current = this.current.RightNode;
                    search(data, current);
                }

                return result;
            }
        }

    }
}
