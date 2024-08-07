using System;
using System.Collections.Generic;


namespace ToyRobotApp
{
    public class Robot
    {
        private int posX;
        private int posY;
        private string heading;
        private static readonly string[] validHeadings = { "NORTH", "SOUTH", "EAST", "WEST" };

        public Robot()
        {
            // sets up default robot placement and heading
            posX = 0;
            posY = 0;
            heading = "NORTH";
        }

        public void Place(int x, int y, string f)
        {
            // places robot on the grid at x,y with heading f
            if (IsPositionValid(x, y) && IsHeadingValid(f))
            {
                posX = x;
                posY = y;
                heading = f;
            }
            else
            {
                throw new ArgumentException("Invalid position or direction");
            }
        }

        private bool IsPositionValid(int x, int y)
        {
            // checks that position exists on the 5x5 board
            return (x >= 0 && x <= 4) && (y >= 0 && y <= 4);
        }

        private bool IsHeadingValid(string f)
        {
            // ensures one of the 4 valid headings are provided by the incoming commands
            foreach (var heading in validHeadings)
            {
                if (heading == f)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsMoveValid()
        {
            // asserts that robot is not about to move out of bounds
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
            // returns robot location and heading
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
            // moves forward if valid move or stays still
            if (IsMoveValid())
            {
                MoveRobot();
            }
        }

        public void Left()
        {
            // turns robot counterclockwise
            var d = new Dictionary<string, string>
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
            // turns robot clockwise
            var d = new Dictionary<string, string>
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
