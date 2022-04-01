# WPF Challenges

## Project Description
- Project divided in Easy, Medium and Hard
- **Easy project** 
  - C# console application
  - Read a text file with an unordered array of numbers
  - Order the array
  - Write a new text file with the previous array, now ordered
- **Easy tests**
  - Program of unit tests
  - Test if the .txt file is read
  - Test if the .txt is successfully converted into an int array
  - Test if the new .txt file is created
- **Medium project**
  - C# WPF application
  - Simple 3D project scene
  - Used Abd3d.PowerToys nuget
  - Project with simple rotation

## [ATTENTION] How to run all projects
- **Easy**
  - Change the save path and name of file in Easy/Util.cs/createTextFile
    - Where is @"C:\Users\Usuario\Downloads\Test01-Done" chancge to @"C:\YourUser\YourUser\Downloads\NameOfTheFile"
    - It will be saved in your Downloads folder
  - Copy Test01.txt full file path and use it as input in the console
  - After that you can run the app normaly
- **Easy tests**
  - Open the class UtilTests.cs
  - Change each path on each method
    - Where is @"C:\Users\Usuario\source\repos\O-PitBlast Tests\Easy\Test01.txt" replace for the full path of Easy/Test01.txt file
    - Then it should be like @"fullPath"
  - After that the tests should run smoothly 
- **Medium**
  - To see the 3D object here theres no need for changes
  - Just run the application
  - Then use the slider to rotate the object
