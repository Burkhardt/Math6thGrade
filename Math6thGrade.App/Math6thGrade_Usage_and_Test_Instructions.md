
# Math6thGrade Program Usage and Test Instructions

## Introduction
The Math6thGrade program is a simple command-line application that provides functionality to calculate the Greatest Common Factor (GCF) and the Least Common Multiple (LCM) of two numbers. This document explains how to use the program and how to run its associated unit tests.

## Usage
To use the Math6thGrade program, you need to pass command-line arguments to specify the operation (GCF or LCM) and the two numbers for which you want to perform the calculation.

### Running the Program
Navigate to the `Math6thGrade.App` directory in your solution and use the `dotnet run` command followed by the operation and numbers. The available operations are:

- `-gcf`: To calculate the Greatest Common Factor
- `-lcm`: To calculate the Least Common Multiple

#### Examples
1. To calculate the LCM of 15 and 20:
   ```
   dotnet run -- -lcm 15 20
   ```

2. To calculate the GCF of 15 and 20:
   ```
   dotnet run -- -gcf 15 20
   ```

## Running the Tests
The Math6thGrade solution includes a test project (`Math6thGrade.Tests`) that contains unit tests for the program.

### Test Execution Instructions
To run the tests, follow these steps:

1. Open the Terminal application.
2. Navigate to the root directory of the Math6thGrade solution.
3. Execute the command `dotnet test`. This will run all the tests in the solution.

#### Running Specific Tests
If you wish to run tests only for the `Math6thGrade.Tests` project, navigate to the `Math6thGrade.Tests` directory in your terminal and execute `dotnet test` there.

```
cd Math6thGrade.Tests
dotnet test
```

The output will show the summary of the tests, including the total number of tests, number of passed, failed, and skipped tests.
