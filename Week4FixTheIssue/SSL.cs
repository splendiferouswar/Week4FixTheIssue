using System;

namespace Week4FixTheIssue
{
    class SSL
    {
        public Item head; // a pointer to the head item
        public Item tail; // a pointer to the tail item

        public SSL() { head = null; tail = null; } // constructor

        // adding to the head of the singly linked list
        public Item addToHead(Item it)
        {
            if (head == null) //if the head is pointing to null, 
            {
                head = it; //then the number is attached to head and tail
                tail = it;
            }
            else //else if the head is not directly pointing to null
            {
                it.next = head; //Make next of new Node as head
                head = it; //Move the head to point to new Node
            }
            return head;
        }

        // adding to the tail of the singly linked list
        public Item addToTail(Item it)
        {
            if (head == null)
            {
                head = it;
                tail = it;
            }
            else
            {
                tail.next = it;
                tail = it;
            }
            return tail;
        }

        // adding to the middle of the singly linked list
        public Item addInBetween(Item prev_node, Item it)
        {
            // display the message if the prev_node does not exist in the linked list
            if (prev_node == null)
            {
                Console.WriteLine("Node does not exist, unable to insert node {0}", it.num);
            }
            if (prev_node.next != null)
            {
                it.next = prev_node.next;
                prev_node.next = it;
            }
            else
            {
                it.next = prev_node.next;
                prev_node.next = it;
                tail = it;
            }
            return tail;

        }

        public void print()
        {
            // print the numbers one by one in one line
            // Complete this function by yourself
            Item it = head;

            while (it != null)
            {
                Console.WriteLine(it.num);
                it = it.next;
            }
        }
        public bool searchIssue(int x)
        {
            bool checker = false;
            Item it = head;

            while (it != null)
            {
                if (it.num == x)
                {
                    checker = true;
                }
                it = it.next;
            }
            return checker;
        }

        public Item deleteANode(Item prev_node, int x)
        {
            Item temp = head, prev = null;

            if (temp != null && head.num == x)
            {
                temp.next = head;
            }

            while (head != null && head.num != x)
            {
                prev_node.next = 
                prev = temp;
                temp = temp.next;

            }

            return head;
        }
    }
}
