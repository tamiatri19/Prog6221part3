Set Up Your Development Environment:

Ensure you have Visual Studio installed. You can download it from Visual Studio.
Install the .NET Desktop Development workload during Visual Studio installation.
Create a New WPF Project:

Open Visual Studio.
Select "Create a new project."
Choose "WPF App (.NET Framework)" and click "Next."
Name your project and solution (e.g., RecipeManagerWPF) and choose a save location.
Click "Create."
Add Code Files:

In Solution Explorer, right-click on the project name and select "Add" > "New Item."
Choose "Class" and name it RecipeManager.cs. Repeat this step to create Recipe.cs and Ingredient.cs files.
Replace the content of RecipeManager.cs, Recipe.cs, and Ingredient.cs with the appropriate classes from your code.
Update MainWindow.xaml and MainWindow.xaml.cs:

Open MainWindow.xaml and design your UI. For simplicity, add four buttons (btnEnterRecipe, btnListRecipes, btnDisplayRecipe, and btnClearData) and a TextBox (txtOutput).
Open MainWindow.xaml.cs and replace the content with the code provided for the MainWindow class.
Resolve Namespaces and Dependencies:

Ensure all namespaces are correctly referenced. Your MainWindow.xaml.cs should include:
csharp code:
using System;
using System.Linq;
using System.Windows;
The other classes should include:
csharpcode:
using System;
using System.Collections.Generic;
using System.Linq;
Build and Run the Project:

Click "Build" > "Build Solution" to compile the project.
Fix any compilation errors that may appear.
Once successfully built, click "Debug" > "Start Debugging" or press F5 to run the application.
Your application should now open, allowing you to interact with the Recipe Manager through the UI. Each button triggers its respective method, displaying outputs in the txtOutput TextBox.

link to respository:https://github.com/tamiatri19/Prog6221part3/blob/main/Prog6221Part3/Brief%20Description
