using Microsoft.VisualStudio.TestTools.UnitTesting;

//using TestRogue;

using Roy_T.AStar.Grids;
using Roy_T.AStar.Primitives;
using Roy_T.AStar.Paths;
using Roy_T.AStar.Graphs;

namespace UnitTestProject
{
    [TestClass]
    public class AstarPathFindingTest
    {
        private readonly PathFinder PathFinder;

        public AstarPathFindingTest()
        {
            this.PathFinder = new PathFinder();
        }

        [TestMethod]
        public void ShouldFindPath__StartNodeIsEndNode()
        {
            var node = new Node(Position.Zero);
            var path = this.PathFinder.FindPath(node, node, Velocity.FromMetersPerSecond(1));

            Assert.AreEqual(path.Type, PathType.Complete);
            Assert.AreEqual(path.Edges.Count, 0);
            Assert.AreEqual(path.Distance, Distance.FromMeters(0));
            Assert.AreEqual(path.Duration, Duration.Zero);
        }

        [TestMethod]
        public void ShouldFindPath_AcyclicGraph()
        {
            var nodeA = new Node(new Position(0, 0));
            var nodeB = new Node(new Position(10, 0));
            var nodeC = new Node(new Position(20, 0));

            nodeA.Connect(nodeB, Velocity.FromMetersPerSecond(1));
            nodeB.Connect(nodeC, Velocity.FromMetersPerSecond(1));

            var path = this.PathFinder.FindPath(nodeA, nodeC, Velocity.FromMetersPerSecond(1));

            Assert.AreEqual(path.Type, PathType.Complete);
            Assert.AreEqual(path.Edges.Count, 2);
            Assert.AreEqual(path.Distance, Distance.FromMeters(20));
            Assert.AreEqual(path.Duration, Duration.FromSeconds(20));
        }

        [TestMethod]
        public void ShouldFindPath_CyclicGraph()
        {
            var nodeA = new Node(new Position(0, 0));
            var nodeB = new Node(new Position(10, 0));
            var nodeC = new Node(new Position(20, 0));

            nodeA.Connect(nodeB, Velocity.FromMetersPerSecond(1));
            nodeB.Connect(nodeC, Velocity.FromMetersPerSecond(1));

            nodeB.Connect(nodeA, Velocity.FromMetersPerSecond(1));
            nodeC.Connect(nodeB, Velocity.FromMetersPerSecond(1));

            var path = this.PathFinder.FindPath(nodeA, nodeC, Velocity.FromMetersPerSecond(1));

            Assert.AreEqual(path.Type, PathType.Complete);
            Assert.AreEqual(path.Edges.Count, 2);
            Assert.AreEqual(path.Distance, Distance.FromMeters(20));
            Assert.AreEqual(path.Duration, Duration.FromSeconds(20));
        }

        [TestMethod]
        public void ShouldFindPath_GraphWithDeadEnds()
        {
            var nodeCenter = new Node(new Position(10, 10));
            var nodeLeft = new Node(new Position(0, 10));
            var nodeRight = new Node(new Position(20, 10));
            var nodeAbove = new Node(new Position(10, 0));
            var nodeBelow = new Node(new Position(10, 20));

            nodeCenter.Connect(nodeLeft, Velocity.FromMetersPerSecond(1));
            nodeLeft.Connect(nodeCenter, Velocity.FromMetersPerSecond(1));

            nodeCenter.Connect(nodeRight, Velocity.FromMetersPerSecond(1));
            nodeRight.Connect(nodeCenter, Velocity.FromMetersPerSecond(1));

            nodeCenter.Connect(nodeAbove, Velocity.FromMetersPerSecond(1));
            nodeAbove.Connect(nodeCenter, Velocity.FromMetersPerSecond(1));

            nodeCenter.Connect(nodeBelow, Velocity.FromMetersPerSecond(1));
            nodeBelow.Connect(nodeCenter, Velocity.FromMetersPerSecond(1));

            var path = this.PathFinder.FindPath(nodeLeft, nodeBelow, Velocity.FromMetersPerSecond(1));

            Assert.AreEqual(path.Type, PathType.Complete);
            Assert.AreEqual(path.Edges.Count, 2);
            Assert.AreEqual(path.Distance, Distance.FromMeters(20));
            Assert.AreEqual(path.Duration, Duration.FromSeconds(20));
        }
    }
}
