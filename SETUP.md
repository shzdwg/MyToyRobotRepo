# Toy Robot Simulator

This is a simple console application that simulates a toy robot moving on a square tabletop.

## Table of Contents

- [Setup](#setup)
- [Running the Program](#running-the-program)

## Setup

1. **Clone the Repository:**

   git clone https://github.com/YourUsername/Toy-Robot.git
   cd Toy-Robot

Open the Solution:

Open Visual Studio.
Open the ToyRobotSolution.sln file located in the cloned repository.
Build the Solution:

In Visual Studio, right-click on the solution in Solution Explorer.
Select Build Solution.

Running the Program
-------------------
You can run the program either by providing commands via standard input or by reading commands from a file.

Running from Standard Input
---------------------------
Set ToyRobotApp as the Startup Project:

In Solution Explorer, right-click on the ToyRobotApp project.
Select Set as StartUp Project.
Run the Program:

Press F5 or click on Debug > Start Debugging.
Enter Commands:

Enter commands one by one, and each command will be processed immediately.
Type END to finish entering commands.

PLACE 0,0,NORTH
MOVE
REPORT
LEFT
REPORT
END

Running from a File
-------------------

Create a Command File:

Create a text file (e.g., commands.txt) with the list of commands.
Run the Program with the File Path:

Open a terminal and navigate to the project directory.
Run the following command:

dotnet run commands.txt
View Output:

The program will process all commands in the file and display the results.
The console will remain open until you press Enter to exit.