//using System;
//using System.Collections.Generic;

//class LinkedList
//{


//    public Node head;


//    public class Node
//    {
//        public int data;
//        public Node next;
//        public Node(int x)
//        {
//            data = x;
//            next = null;
//        }
//    }

//    public void push(int new_data)
//    {

//        Node new_node = new Node(new_data);

//        new_node.next = head;

//        head = new_node;
//    }

//    public static bool detectLoop(Node example)
//    {
//        HashSet<Node> s = new HashSet<Node>();
//        while (example != null)
//        {

//            if (s.Contains(example))
//                return true;

//            s.Add(example);

//            example = example.next;
//        }

//        return false;
//    }

//    public static void Main()
//    {
//        LinkedList list = new LinkedList();

//        list.push(35);
//        list.push(1);
//        list.push(47);
//        list.push(80);

//        list.head.next.next.next.next = list.head;

//        if (detectLoop(list.head))
//            Console.WriteLine("Loop Found");
//        else
//            Console.WriteLine("No Loop");
//    }
//}

//Arda KARAMAN