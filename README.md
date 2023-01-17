# C# byte array serialitzation and Python deserilization

## Project Description:

This project demonstrates how to serialize a byte array in C# and deserialize it in Python. The primary use case is to work with images. The project contains two files:

**Program.cs**: A C# console project that creates a byte array of a specified image size, serializes it, and saves it to a file. It also includes a timestamp to measure the execution time.

**main.py**: A Python script that reads the byte array from the file created by the C# project, deserializes it, and converts it to a numpy array. It also includes a timestamp to measure the execution time.

## Installation Instructions:

1. Make sure you have C# and Python installed on your machine.
2. Clone or download the project.
3. Open the project in Visual Studio and run the C# code to generate the byte array and serialize it.
4. Run the Python script to read it.

## How to Run the Project:

1. Run the C# code to generate the byte array and serialize it.
2. Run the Python script to read it.

Note: You can disable print results by setting 'print_results' variable as False.

## Technologies Used:

*  C#
*  Python

## Dependencies:

In C#:
* using System;
* using System.Linq;
* using System.Runtime.Serialization.Formatters.Binary;
* using System.IO;

In Python:
*  numpy
*  time

## License Information:

This project is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

## Contact Information:

Sergio Redondo: https://github.com/rodo1985

## Features:

*  Serialization of byte arrays in C#
*  Deserialization of byte arrays in Python
*  Timestamp for measuring execution time
*  Option to disable print results

## Roadmap or Roadmap Timeline:

*  Add more data types for serialization and deserialization
*  Add support for more file formats
*  Optimize the execution time

## Keywords:

*  csharp byte array serialization
*  python byte array deserialization
*  csharp python byte array communication
*  csharp image serialization
*  python image deserialization
