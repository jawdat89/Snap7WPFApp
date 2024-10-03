# Snap7WPFApp

Snap7App is a WPF application developed using the .NET Core. It provides a user interface for connecting to a Siemens PLC using the Sharp7 library. The application includes functionality for bit manipulation and managing PLC connections.

## Features

- Connect to a Siemens PLC using the Sharp7 library.
- Perform bit manipulation operations such as setting, clearing, checking, and toggling bits.
- Display connection status in the user interface.

## Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version compatible with your development environment)
- [Sharp7 Library](https://github.com/mesta1/Sharp7) for PLC communication
- Siemens PLC (e.g., S7-1200, S7-1500) for testing connections

## Installation

1. Clone the repository to your local machine:
`bash
git clone https://github.com/yourusername/Snap7App.git
`
2. Open the solution in Visual Studio.

3. Restore NuGet packages to ensure all dependencies are installed.

4. Build the solution to compile the application.

## Usage

1. **Configure PLC Connection:**
   - Open `MainWindow.xaml.cs`.
   - Set the `IP`, `Rack`, and `Slot` variables to match your PLC configuration.

2. **Run the Application:**
   - Start the application from Visual Studio or by running the compiled executable.

3. **Connect to PLC:**
   - Use the "Connect" button in the application to establish a connection with the PLC.
   - The connection status will be displayed in the application.

4. **Disconnect from PLC:**
   - Use the "Disconnect" button to terminate the connection.

## Bit Manipulation Functions

The application includes a set of static methods for bit manipulation, located in the `BitManipulationHelper` class:

- `SetBit(ref byte InByte, byte Bit)`: Sets the specified bit in a byte.
- `ClearBit(ref byte InByte, byte Bit)`: Clears the specified bit in a byte.
- `IsBitSet(byte InByte, byte Bit)`: Checks if the specified bit in a byte is set.
- `ToggleBit(ref byte InByte, byte Bit)`: Toggles the specified bit in a byte.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgments

- [Sharp7 Library](https://github.com/mesta1/Sharp7) for providing the PLC communication functionality.
- Siemens for their automation technology and tools.

Notes
Replace https://github.com/yourusername/Snap7App.git with the actual URL of your repository if you plan to host it on a platform like GitHub.
Ensure that the prerequisites and installation steps match your actual project setup.
You may need to adjust the license section based on your project's licensing terms.
