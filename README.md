# Heuristics.TechEval

## Setting up your environment

This project requires the following:

1. Visual Studio 2017 (Community Edition should be fine)
2. SQL Server Express

If you already have a machine with those tools on it, you should be able to open this solution, run the database migration (see below), and be good to go.

If you do NOT already have a machine with those tools, you can either install them or you can [download a development VM from Microsoft](https://developer.microsoft.com/en-us/windows/downloads/virtual-machines). These VMs come with all of the tools you'll need pre-installed but typically expire after a month or two.

## Compiling and running the project

To get started, you need to:

1. Open the _Heuristics.TechEval.sln_ file in Visual Studio
2. Compile the solution (either <kbd>F6</kbd> or <kbd>Ctrl-Shift-B</kbd>, depending on your keyboard mappings)
3. Open the Package Manager Console and execute the `Update-Database` command, which will create and seed a local database
4. Run the app (<kbd>F5</kbd> starts with the debugger attached, <kbd>Ctrl-F5</kbd> starts without a debugger)

![Running the migrations](https://github.com/spetryjohnson/Heuristics.TechEval/blob/master/docs/Heuristics.TechEval.docs-migrations.png)

## What next?

Follow the in-app prompts for a list of tasks that you can choose to complete. 

*REMEMBER:* It's OK if you don't know how to do something, and you don't have to complete all of the tasks. The goal is to create a code sample that helps us understand how you think, how you figure things out, and how you can talk about the challenges you face as a programmer. 

Go ahead and put your best foot forward with the code, just remember that what really matters will be the discussion we have _about_ the code later.