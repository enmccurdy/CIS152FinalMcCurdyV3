/***************************************************************
* Name       : DrinkShopV3ConsoleAppCodeFirst Program.cs Driver
*   File - CIS 152 Final Project version 3
* Author     : Elizabeth McCurdy
* Created    : 04/26/2024
* Course     : CIS 152 - Data Structures - Spring 2024
* Version    : 3.0
* OS         : Windows 11
* IDE        : Visual Studio 2022 Community
* Copyright  : This is my own original work based on
*              specifications issued by our instructor
* Description: CIS 152 Final Project version 3: The
*   DrinkShopV3ConsoleAppCodeFirstConsole App is the 3rd version
*   of my final project since the ASP.NET Core MVC Web App v1 & 
*   the ASP.NET Web App with Razor Pages v3 both versions were not
*   working with the Database correctly and the neither version
*   allowed the .cshtml web pages to work with more than one model
*   at a time - each model could only be used to operate its set
*   of CRUD related web pages making interelated models/class that
*   used join table unable to create/edit an entity and work with 
*   the database correctly.  
*   
*   This program creates gets user input to create an Order object 
*   with related Customer and Drink(s) objects. The Order object is
*   then placed into a Queue data structure to be 'filled' in the
*   order in which they were recieved/created.  The Customer objects
*   in the database will be able to be put into a List data structure,
*   sorted alphabetically, then be displayed or searched for a specific
*   customer name. Objects will be saved to a local SQL database. 
*   
*   This version of the Console app is code first rather than database
*   first version of using ASP.NET's Entity Framework Core.
*   
*              Input: User inputs field values - . Which are used to
*              create an instance/object of the Order/Customer and Drink
*              class. The customer will be able to add more than one
*              Drink to the Order object - the properties of the classes 
*              will help validate user data.
*              Output: Display details about the instances of the 
*              class objects using the class's ToString() method which 
*              returns a string to display to the user. 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace DrinkShopV3ConsoleAppCodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
