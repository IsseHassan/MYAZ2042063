using DisjointSet;

namespace DisjointSetTests
{
    public class DisjointSetTests
    {
        [Fact]
        public void Smoke_Test_DisJointSet()
        {
            var disjointSet = new DistjointSets<int>();

            for (int i = 1; i <= 7; i++)
            {
                disjointSet.MakeSet(i);
            }

            //IEnumerable test

            Assert.Equal(7, disjointSet.Count);

            disjointSet.Union(1,2);
            Assert.Equal(1, disjointSet.FindSet(2));

            disjointSet.Union(2, 3);
            Assert.Equal(1, disjointSet.FindSet(3));

            disjointSet.Union(4, 5);
            Assert.Equal(4, disjointSet.FindSet(4));

            disjointSet.Union(5, 6);
            Assert.Equal(4, disjointSet.FindSet(5));

            disjointSet.Union(6, 7);
            Assert.Equal(4, disjointSet.FindSet(6));

            Assert.Equal(4, disjointSet.FindSet(4));
            disjointSet.Union(3, 4);
            Assert.Equal(1, disjointSet.FindSet(4));

            //IEnumerable tets
            Assert.Equal(7, disjointSet.Count);
        }

        [Fact]
        public void Implementation_Test()
        {
            var ds = new DistjointSets<int>();
            for (int i = 1; i <= 8; i++)
            {
                ds.MakeSet(i);
            }

            ds.Union(1, 2);
            ds.Union(2, 3);
            ds.Union(3, 4);
            ds.Union(1, 5);
            ds.Union(5, 6);
            ds.Union(1, 7);
            ds.Union(7, 8);

            Assert.Equal(1, ds.FindSet(1));
            Assert.Equal(1, ds.FindSet(2));
            Assert.Equal(1, ds.FindSet(6));
            Assert.Equal(1, ds.FindSet(5)); 
            Assert.Equal(1, ds.FindSet(8));
            Assert.Equal(1, ds.FindSet(7));
            Assert.Equal(1, ds.FindSet(4));

            Assert.Equal(8, ds.Count);
        }

        [Fact]
        public void PathCompression_Test()   
        {
            var disjointSet = new DistjointSets<int>();

            
            for (int i = 1; i <= 10; i++)
            {
                disjointSet.MakeSet(i);

            }

            // Perform unions to create the following tree:

            //         7
            //       /   \
            //     5      4                   
            //    /      /  \
            //   6      8    9
            //  / \
            // 3   10
            

            disjointSet.Union(5, 6);
            disjointSet.Union(4, 8);
            disjointSet.Union(4, 9);
            disjointSet.Union(6, 3);
            disjointSet.Union(6, 10);
            disjointSet.Union(7, 5);
            disjointSet.Union(7, 4);

            for (int i = 1; i <= 10; i++)
            {
                disjointSet.PathCompression(i);
            }
            Assert.Equal(7, disjointSet.FindSet(3));

            //-->  find(3)   

            //           7
            //       /  /  \  \
            //     5   6   3   4                   
            //        / \       /  \
            //       3   10     8   9
            //  

    
            Assert.Equal(7, disjointSet.FindSet(10));
            Assert.Equal(7, disjointSet.FindSet(9));

            Assert.Equal(7, disjointSet.FindSet(6));
            Assert.Equal(7, disjointSet.FindSet(4));
            Assert.Equal(7, disjointSet.FindSet(5));
            Assert.Equal(7, disjointSet.FindSet(7));

            // These are not Performing unions
            Assert.Equal(1, disjointSet.FindSet(1));
            Assert.Equal(2, disjointSet.FindSet(2));
        }
    }
}
