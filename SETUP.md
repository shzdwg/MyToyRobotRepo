# Toy Robot Simulator

This is a simple console application that simulates a toy robot moving on a square tabletop.

## Table of Contents

- [Setup](#setup)
- [Running the Program](#running-the-program)

## Setup

1. **Clone the Repository:**

git clone https://github.com/shzdwg/Toy-Robot.git
cd Toy-Robot

### Open the Solution

- Open Visual Studio.
- Open the `ToyRobotApp.sln` file located in the cloned repository.

### Build the Solution

- In Visual Studio, right-click on the solution in Solution Explorer.
- Select `Build Solution`.

## Running the Program

You can run the program either by providing commands via standard input or by specifying a file path with commands.

### Running with a Specified Commands File

1. **Set `ToyRobotApp` as the Startup Project:**

- In Solution Explorer, right-click on the `ToyRobotApp` project.
- Select `Set as StartUp Project`.

2. **Run the Program from Terminal:**

- Open the Terminal in Visual Studio or Command Prompt.
- Navigate to the project directory and run:

dotnet run --project ToyRobotApp path/to/commands.txt

3. **View Output:**

- The program will process all commands in the specified file and display the results.
- The console will remain open until you press Enter to exit.

### Running from Standard Input

1. **Run the Program:**

- Press `F5` or click on `Debug > Start Debugging`.

2. **Enter Commands:**

- Enter commands one by one, and each command will be processed immediately.
- Type `END` to finish entering commands.

Example:

PLACE 0,0,NORTH
MOVE
REPORT
LEFT
REPORT
END

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request with your improvements. All contributions are welcome!

## License

This project is licensed under the MIT License - see the LICENSE file for details.
