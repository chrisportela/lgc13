<!-- Technology logo picture and title -->
<img src="img/c_sharp_logo.png" width= 30% length= 30% align="right">
<h1>C# projects</h1>

<!-- Technology welcome message -->
C# was the first language that taught me object-oriented programming more in-depth. During some of my classes at Florida State University, I created a lot of console apps from scratch, or would backward engineer some other examples given to me. Most of these apps utilize object-oriented programming key concepts such as data encapsulation, abstraction of functionality, attribute and method inheritance, and basic polymorphism.

<h6>Click the title links if you want to see more details about a particular project.</h6>

<!-- Project section -->
<h2><a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c%23/CheeseMVCPersistent">1- Cheese Web App</a></h2>

<!-- Project BIO -->
This web application allows a user to do different actions with "cheese". A user can create a cheese type, create a cheese category which can have multiple cheese in it, and create a menu which can have multiple cheese and categories. This is a simple dynamic web application created while I taught at a organization called LaunchCode. The students and I both worked together on the creation of this dotnet app.

This application displays some of my skills with:

- Dotnet MVC web app with a Microsoft SqlServer database (through Docker)
- ViewModels being passed as parameters to the frontend
- Lambda expressions
- Utilization of DB migrator files
- Basic server-side validation
- Teaching and helping a group of beginner developers

<!-- Screenshots -->
<img src="c%23/CheeseMVCPersistent/img/home.png" width= 60% length= 60%>

<!-- Code explanation -->
I use dbContext in order to persist any data the users puts in the front end, onto my SqlServer database. The use of lambdas comes in handy when retrieving and adding items from queries. I also make good use of models/ViewModels in order to properly create the objects that should be displayed on each view.

<!-- Code snippet -->
You can see that in this code snippet:

```c#
  if (ModelState.IsValid)
  {
      CheeseCategory newCheeseCategory =
              context.Categories.Single(c => c.ID == addCheeseViewModel.CategoryID);

      // Add the new cheese to my existing cheeses
      Cheese newCheese = new Cheese
      {
          Name = addCheeseViewModel.Name,
          Description = addCheeseViewModel.Description,
          Category = newCheeseCategory
      };

      context.Cheeses.Add(newCheese);
      context.SaveChanges();

      return Redirect("/Cheese");
  }
```

<!-- ......................E N D  O F  P R O J E C T........................ -->

<!-- Project section -->
<h2><a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c%23/CreateRoom_objectCalculator_project">2- Create Room Calculator</a></h2>

<!-- Project BIO -->
This application creates different "Room" objects, by asking for user input for information such as a Room name, length, width, and height. Afterward, methods are called in order to return attribute values about this Room, such as its name, area, volume in cubed feet and in cubed yards. It also provides information about a default Room (from default constructor properties.)

This application displays some of my skills with:

- polymorphism: method overloading
- encapsulation: keeping private data hidden
- abstraction: calling methods from a class in a separate file
- use of default constructor, getter and setter methods
- mathematical algorithms

<!-- Screenshots -->
<img src="CreateRoom_objectCalculator_project/img/room_calculator2.png" width= 80% length= 80%>

<!-- Code explanation -->
I use Setter method calls from my main .cs file in order to change a given Room's attributes, such as their length, width, and height. The Setter methods have default values which if not changed, will be used by the default constructor of this program.

<!-- Code snippet -->
You can see that in this code snippet:

```c#

public void SetLength(double l = 0.0)
{ //setter method
  this.roomLength = l;
}

public void SetWidth(double w = 0.0)
{ //setter method
  this.roomWidth = w;
}

public void SetHeight(double h = 0.0)
{ //setter method
  this.roomHeight = h;
}


roomObject2.SetLength(rLength);
roomObject2.SetWidth(rWidth);
roomObject2.SetHeight(rHeight);

```

<!-- ......................E N D  O F  P R O J E C T........................ -->

<!-- Project section -->
<h2><a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c%23/LanguageIntegratedQuery_project">3- LINQ - Language Integrated Query project</a></h2>

<!-- Project BIO -->
This project demonstrates how someone can use LINQ - Language Integrated Query to interact with data. It can be used to query many different types of data including relational, XML, and even objects. LINQ uses SQL-like syntax to produce usable objects.

This application displays some of my skills with:

- LINQ methods
- Using SQL-like syntax expressions
- querying through objects and lists
- manipulation of arrays through for and foreach loops
- user input validation

<!-- Screenshots -->
<img src="LanguageIntegratedQuery_project/img/program.png" width= 80% length= 80%>

<!-- Code explanation -->
By importing the LINQ library, I have access to the SingleOrDefault method. This returns the only element of a sequence, or a default value if the sequence is empty. I use this in order to search in 'people' for a specific person who has last name given by the user. I can then return that entire object's information attributes from this simple search.

<!-- Code snippet -->
You can see that in this code snippet:

```c#

Console.Write("\nPlease enter the last name: ");
string searchName = Console.ReadLine();
Person Name = people.SingleOrDefault(x => x.LastName == searchName);
if (Name != null)
{
  Console.WriteLine("Matching criteria: " + Name.FirstName + " " + Name.LastName + " is a " + Name.Occupation + ", and is " + Name.Age + " years old.");
}

```

<!-- ......................E N D  O F  P R O J E C T........................ -->


# Practice:

Although these were my biggest projects with C#, I have worked on a lot of other smaller projects, practice problems, and trivia questions. You can see these by clicking this link:

[Practice Directory](https://github.com/lgc13/LucasCosta_portfolio/tree/master/c%23/practice)


To compile and build c#files, use the following cmd:

```c#
mcs file_name.cs
```
then run with:

```c#
mono file_name.exe
```

<!-- Contact info -->
# Let's Connect! Don't be shy...

Do you like what you see? Here are some other pages where you can get some more info, and/or connect with me!

<a href="mailto:lucas.gomes.costa@gmail.com"><img src="/img/gmail_favicon.png" height="30px" width="30px"></a> Email: lucas.gomes.costa@gmail.com

<a href="https://www.linkedin.com/in/lucas-gomes-costa/"> <img src="/img/linkedin_favicon.png" height="30px" width="30px"></a> LinkedIn: <a href="https://www.linkedin.com/in/lucas-gomes-costa/">  https://www.linkedin.com/in/lucas-gomes-costa/ </a>

<a href="https://lgc13.wordpress.com/"><img src="/img/wordpress_favicon.png" height="30px" width="30px"></a> Wordpress: <a href="https://lgc13.wordpress.com/">  https://lgc13.wordpress.com/ </a>

<!-- Adding a blank line -->
<br>

<!-- Back to LucasCosta_portfolio folder  -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/" class="previous">&laquo; Back to LucasCosta_portfolio</a>
