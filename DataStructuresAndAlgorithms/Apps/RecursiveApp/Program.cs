﻿// Sum of numbers with iteration

int iter_sum(int n)
{
    if (n == 0)
        return 0;
    int sum = 0;
    for (int  i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

// Sum of numbers with recursive
int recursive_sum(int n)
{
    if (n == 1)
        return 1;

    return n + recursive_sum(n - 1);
}


// Factorial with iteration
int iter_fact(int n)
{
    if (n == 0)
        return 1;

    int mult = 1;
    for (int i = 1; i <= n; i++)
    {
        mult *= i;
    }
    return mult;
}

// Factorial with recursive
int recursive_fact(int n)
{
    if (n == 0)
        return 1;
    if (n == 1)
        return 1;
    return n * recursive_fact(n - 1);
}

// Linked List Traversal with iteration
void iter_traversal(LinkedListNode<int> node)
{
    var Current = node;
    Console.Write("Iteration Traversal: ");
    while (Current != null)
    {
        Console.Write(Current.Value + " ");
        Current = Current.Next;
    }
}

// Linked List Traversal with recursive
void recursive_traversal(LinkedListNode<int> node)
{
    //base
    if (node is null)
        return;
  
    Console.Write(node.Value + " ");
    recursive_traversal(node.Next);
}
LinkedList<int> list = new LinkedList<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });

int n = 5;
Console.WriteLine("Iteration sum : " + iter_sum(n));
Console.WriteLine("Recursive Sum: " + recursive_sum(n));
Console.WriteLine("Iteration Factorial: " + iter_fact(n));
Console.WriteLine("Recursive Factorial: " + iter_fact(n));
iter_traversal(list.First);
Console.WriteLine();
recursive_traversal(list.First);
Console.ReadKey();