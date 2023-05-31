using DisjointSet;

namespace DisjointSetsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var disjointSet = new DistjointSets<int>();

            // Make set for elements 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                disjointSet.MakeSet(i);
            }
            //         7
            //       /   \
            //     5      4                   
            //    /      /  \
            //   6      8    9
            //  / \
            // 3   10

            //find(3) -->   


            //           7
            //       /  /  \  \
            //     5   6   3   4                   
            //        / \       /  \
            //       3   10     8   9
            //  
            // 

            // Perform unions
            // Perform unions
            disjointSet.Union(5, 6);
            disjointSet.Union(4, 8);
            disjointSet.Union(4, 9);
            disjointSet.Union(6, 3);
            disjointSet.Union(6, 10);
            disjointSet.Union(7, 5);
            disjointSet.Union(7, 4);

            // Before Path Compression

            // Find(3) operation
            Console.WriteLine("FindSet(3) before Path Compression: " + disjointSet.FindSet(3));

            // Apply path compression to all elements
            foreach (var item in disjointSet)
            {
                disjointSet.PathCompression(item);
            }



            // Find(3) operation after Path Compression
            Console.WriteLine("FindSet(3) after Path Compression: " + disjointSet.FindSet(3));


        }
    }
}