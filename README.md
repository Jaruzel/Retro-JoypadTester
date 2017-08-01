# Retro-JoypadTester
**A DirectInput Joypad/Joystick Tester for Windows - shows all the input values of your controllers**

It's only about 30 lines of code, but I needed something so I could track what EmulationStation and RetroArch were seeing and why my buttons were swapped in MAME. Others may find it useful, or want to expand on it, so please feel free to fork and pull etc.

## Compiling the Source

* Code is written in Visual Studio 2008 (I know, I know, it's ancient) and targets .NET framework 2.0. It's simple code though, and should work in any version of Visual Studio.
* You need to add a reference to the 'Microsoft.DirectX.DirectInput' DLL which can be found in 'C:\Windows\Microsoft.NET\DirectX for Managed Code' or it won't work
* If you don't have that DLL then you need to install the DirectX SDK.

## Using the Binary

* Just run it.

## Screenshot

![Retro-JoypadTester](https://raw.githubusercontent.com/Jaruzel/Retro-JoypadTester/master/screenshot.png)
