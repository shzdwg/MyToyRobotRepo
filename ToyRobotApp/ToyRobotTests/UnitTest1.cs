using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotApp;

namespace ToyRobotTests
{
    [TestClass]
    public class RobotTests
    {
        private Robot robot;

        [TestInitialize]
        public void Setup()
        {
            robot = new Robot();
        }

        [TestMethod]
        public void TestPlaceValidCoordinates()
        {
            robot.Place(2, 3, "EAST");
            var report = robot.Report();
            Assert.AreEqual((2, 3, "EAST"), report);
        }

        [TestMethod]
        public void TestPlaceInvalidCoordinates()
        {
            robot.Place(5, 5, "NORTH");
            var report = robot.Report();
            Assert.AreNotEqual((5, 5, "NORTH"), report);
        }

        [TestMethod]
        public void TestMoveValid()
        {
            robot.Place(0, 0, "NORTH");
            robot.Move();
            var report = robot.Report();
            Assert.AreEqual((0, 1, "NORTH"), report);
        }

        [TestMethod]
        public void TestMoveInvalid()
        {
            robot.Place(0, 0, "SOUTH");
            robot.Move();
            var report = robot.Report();
            Assert.AreEqual((0, 0, "SOUTH"), report);
        }

        [TestMethod]
        public void TestTurnLeft()
        {
            robot.Place(0, 0, "NORTH");
            robot.Left();
            var report = robot.Report();
            Assert.AreEqual((0, 0, "WEST"), report);
        }

        [TestMethod]
        public void TestTurnRight()
        {
            robot.Place(0, 0, "NORTH");
            robot.Right();
            var report = robot.Report();
            Assert.AreEqual((0, 0, "EAST"), report);
        }
    }
}
