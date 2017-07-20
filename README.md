# MCdb
CsharpDotNetMondayProject

This is my C# project.  It is a simple database of motorcycle models that you can view, edit, delete, and add to.  

In order to run the app, you must first download the SRC folder to your local computer and open the MotorCycleDB solution file with Visual Studio 2017.  

When that is done, you must:
1) Open the NuGet Package Manager by clicking "Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution..."
2) In the NuGet Package Manager screen, there should be a yellow bar at the top of the screen.  Click the RESTORE button.  Entity Framework should install.
3) Open the Package Manager Console by clicking "Tools -> NuGet Package Manager -> Package Manager Console"
4) in the Package Manager Console, type Update-Database and press Enter.  You should see "Running Seed Method" as output.  

You are now ready to run the app.
