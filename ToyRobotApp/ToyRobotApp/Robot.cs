

namespace ToyRobotApp
{
    public class Robot
    {
        private int posX;
        private int posY;
        private string heading;

        public Robot()
        {
            posX = 0;
            posY = 0;
            heading = "NORTH";
        }

        public void Place(int x, int y, string f)
        {
            if ((x >= 0 && x <= 4) && (y >= 0 && y <= 4))
            {
                posX = x;
                posY = y;
                heading = f;
            }
        }

        public bool IsMoveValid()
        {
            if (heading == "WEST" && posX > 0)
            {
                return true;
            }
            else if (heading == "EAST" && posX < 4)
            {
                return true;
            }
            else if (heading == "SOUTH" && posY > 0)
            {
                return true;
            }
            else if (heading == "NORTH" && posY < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public (int, int, string) Report()
        {
            return (posX, posY, heading);
        }

        private void MoveRobot()
        {
            // moves robot one position forward
            if (heading == "WEST")
            {
                posX -= 1;
            }
            else if (heading == "EAST")
            {
                posX += 1;
            }
            else if (heading == "SOUTH")
            {
                posY -= 1;
            }
            else if (heading == "NORTH")
            {
                posY += 1;
            }
        }

        public void Move()
        {
            // moves forward if valid or stays still
            if (IsMoveValid())
            {
                MoveRobot();
            }
        }

        public void Left()
        {
            // turns robot left
            var d = new System.Collections.Generic.Dictionary<string, string>
        {
            {"WEST", "SOUTH"},
            {"SOUTH", "EAST"},
            {"EAST", "NORTH"},
            {"NORTH", "WEST"}
        };
            heading = d[heading];
        }

        public void Right()
        {
            // turns robot right
            var d = new System.Collections.Generic.Dictionary<string, string>
        {
            {"WEST", "NORTH"},
            {"NORTH", "EAST"},
            {"EAST", "SOUTH"},
            {"SOUTH", "WEST"}
        };
            heading = d[heading];
        }
    }
    }
