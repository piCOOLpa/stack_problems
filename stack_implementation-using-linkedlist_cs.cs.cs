/*
    push()      : Insert the element into linked list nothing but which is the top node of Stack.
    pop()       : Return top element from the Stack and move the top pointer to the second node of linked list or Stack.
    peek()      : Return the top element.
    display()   : Print all element of Stack.

 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace stack_implement_stack_using_list
{

    // A linked list node  
    public class Node
    {
        // data-members

        // integer data  
        public int data;
        // reference variable Node type  
        public Node link;

        // Constructor  
        public Node(int value)
        {
            // initialize the data-members of the current node.
            this.data  = value;
            this.link  = null;
        }
    }

    class Program
    {

        public static Node Push(Node head , int Node_value)
        {
           
            Node  Top = new Node(Node_value);
            // create a node with Node_value and refer it by Top.

            if( Top != null )
            {
                // actual memory allocation happens to the node.
                // make the link between head and top referances.
                // make head referance  point Root.

                Top.link = head;
                head  = Top;
            }
            return head;
            // return the new head.
        }

        public static Node  Pop(Node head)
        {
            Node Top = head;
            // declare the top and make it point to current head.

            if (Top == null)
            {
                // check underflow conddition. no element to delete [pop]
                Console.WriteLine("no element to pop.");
                return head;
            }
            else
            {
                // atleast one element to delete , referred by Top.
                Console.WriteLine("the element deleted is : " + head.data + ".");

                head = head.link;
                // move the link to the next node.

                return head;
                // return the current head.
            }
        }

        public static void Peek(Node head)
        {
            Node Top = head;
            // make the Top node point to head.


            if (Top == null)
            {
                // check underflow condition : no element to display.
                Console.WriteLine("stack is empty ,no-element  to  display");
                return;
            }
            Console.WriteLine("the top element :" + Top.data);
            // print the data of the top element.
           
        }

        public static void Display(Node head)
        {
            // objective is to iterate over all the elements one by one , starting from the top.

            if (head != null)
            {
                // node is not null. if the stack exists. Iterate one by one , starting from the top.

                Node temp = head;
                // iterate through the stack from Top till the last element using the temporary referance.

                Console.WriteLine();
                while (temp != null)
                {
                    Console.Write(temp.data + ",");
                    temp = temp.link;
                }
            }
        }
        static void Main(string[] args)
        {

            Node head = null;
            // head referance of the linked-list.

            string choice = "1";
            // choice variable iterator. Initial default value set to 1 , so as iterarte atleast 1 time.

             while (Convert.ToInt32(choice) == 1)
            {

                Console.WriteLine("welcome to stack problem: ");
                Console.WriteLine("Menu for differnt operations : ");
                Console.WriteLine(" press 1.push \n press 2.pop an element \n press 3.peek the top element \n press 4.Display all elements");
                Console.Write("enter ur choice :");
                int user_choice = Convert.ToInt32(Console.ReadLine());

                switch (user_choice)
                {
                    case 1:
                            Console.WriteLine(" u have selected the push option :");
                            Console.Write(" enter an element to push into the stack :");
                            int push_element = Convert.ToInt32(Console.ReadLine());
                            //  push()      : Insert the element into linked list nothing but which is the top node of Stack.
                            head = Push(head, push_element);
                            // 1. root referance  , 2. element to be pushed
                            break;
                    case 2:
                            //pop()       : Return top element from the Stack and move the top pointer to the second node of linked list or Stack.
                            Console.WriteLine("u have selected the pop [delete] option :");
                            head = Pop(head);
                            break;
                    case 3:
                            //peek()      : Return the top element.
                            Console.WriteLine("u have selected the peek option :");
                            Peek(head);
                            break;

                    case 4:
                            //display()   : Print all element of Stack. Print all the elements from the top to all the elements.
                            Console.WriteLine("the elements in the stack are :");
                            Display(head);
                            break;

                    default:
                            Console.WriteLine(" u entered a wrong option ");
                            break;
                }

                Console.Write("Do you want to continue \n press 1 to continue \n  any-other key to discontinue \n");
                choice = Console.ReadLine();
            }
        }
    }
}


/*
 
        // insert Stack value  
        obj.push(11);  
        obj.push(22);  
        obj.push(33);  
        obj.push(44);  
  
        // print Stack elements  
        obj.display();  
  
        // print Top element of Stack  
        Console.Write("\nTop element is {0}\n", obj.peek());  
  
        // Delete top element of Stack  
        obj.pop();  
        obj.pop();  
  
        // print Stack elements  
        obj.display(); 
 */
