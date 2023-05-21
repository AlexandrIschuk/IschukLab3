using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Homework5
{
    public class CycleDoubleLinkedList // Класс “Двусвязные циклические списки”
    {
        public DoubleNode head { get; set; }

        public CycleDoubleLinkedList()
        {
            head = null;
        }

        public void AddFirst(int value)
        {
            DoubleNode newNode = new DoubleNode(value);

            if (head == null)
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                newNode.Next = head;
                newNode.Prev = head.Prev;
                head.Prev.Next = newNode;
                head.Prev = newNode;
                head = newNode;
            }
        }

        public void AddLast(int data)
        {
            DoubleNode q;
            DoubleNode p = head;
            if (p != null)
            {
                q = new DoubleNode(data);
                q.Next = p;
                q.Prev = p.Prev;
                p.Prev.Next = q;
                p.Prev = q;

            }
        }

        public void DisplayList(ListBox listBox)
        {
            listBox.Items.Clear();
            if (head != null)
            {
                DoubleNode current = head;
                do
                {
                    listBox.Items.Add(current.Value);
                    current = current.Next;
                } while (current != head);
            }

            
        }
        public void ClearList(DoubleNode head)
        {
            if (head != null)
            {
                head.Next = head;
                head.Prev = head;
            }

            
        }
        public void CreateList(int[] arr)
        {
            if (arr.Length != 0)
            {
                head = new DoubleNode(arr[0]);
                DoubleNode current = head;

                for (int i = 1; i < arr.Length; i++)
                {
                    DoubleNode newNode = new DoubleNode(arr[i]);
                    current.Next = newNode;
                    newNode.Prev = current;
                    current = newNode;
                }

                current.Next = head;
                head.Prev = current;
            }

            
        }
        public void DestroyList()
        {
            if (head != null)
            {

                head = null;
            }

            
        }
        public void AddNode(int data, int position)
        {
            if (head == null)
            {
                head = new DoubleNode(data);
                head.Next = head;
                head.Prev = head;
                
            }
            else
            {
                int count = 1;
                DoubleNode current = head;
                while (count < position && current.Next != head)
                {
                    current = current.Next;
                    count++;
                }

                if (count == position)
                {
                    DoubleNode newNode = new DoubleNode(data);
                    newNode.Next = current.Next;
                    newNode.Prev = current;
                    current.Next.Prev = newNode;
                    current.Next = newNode;
                }
            }
            

        }
        public void RemoveFirst()
        {
            if (head != null)
            {
                    DoubleNode temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }

                    temp.Next = head.Next;
                    head = head.Next;
                    head.Prev = temp;
                    
            }

            
        }

        public void RemoveLast()
        {
            if (head != null)
            {
                DoubleNode p = head.Prev;
                if (p != null && p != head)
                {
                    p.Prev.Next = p.Next;
                    p.Next.Prev = p.Prev;
                }

            }

            
        }
        public void RemoveAt(int index,DoubleNode current)
        {
            if (head != null)
            {
                DoubleNode temp = head.Next;
                int i = 0;

                while (i < index && temp != head)
                {
                    temp = temp.Next;
                    i++;
                }

                if (i == index)
                {
                    if (temp == head)
                    {
                        head = head.Next;
                        current = head.Next;
                    }

                    temp.Prev.Next = temp.Next;
                    temp.Next.Prev = temp.Prev;
                }

                
            }

           
        }
        public void RemoveRange(int startIndex, int endIndex)
        {
            if (head != null)
            {
                if (startIndex == 0)
                {
                    for (int j = 0; j < endIndex && head != null; j++)
                    {
                        RemoveFirst();
                    }
                    
                }
                else
                {
                    DoubleNode temp = head;
                    int i = 0;
                        DoubleNode startNode = temp.Next;
                        for (int j = startIndex; j <= endIndex && startNode != head; j++)
                        {
                            startNode = startNode.Next;
                        }

                        temp.Next = startNode;
                        startNode.Prev = temp;
                    

                    
                }

                
            }

           
        }

    }






}



