﻿2023-10-30@12:10pm
Started the project by creating new project by my name PawanBookStore in asp.net5.0 version
Then, authenticated it for individual accounts.
I got my readymade folders such as controllers, area and data.
Added, another text file in my project to get description of it named "README.txt".
Then i commented out the port number to get the output.

@12:15pm
Checked the _ViewStart.cshtml file whether razor class library linked with _Layout.cshtml file.
Also looked whether all the deafult necessary folders are there or not.
After checking the database access, looked at the methods in the startup.cs file for the connection of https pipeline.

@12:25pm
Update database by running command in the terminal.
At first got errors because forgot to put "-" in between the update database.
 Now its time to test the project before putting it to the github.com.
 Yeehhhhhh!!!!its a successful attempt.
 Then i set password and other login details. and i successfully logged into my bookstore app.
 After, i logged out the app and log in again to verify.
 
 @12:31pm
 Created my project to git hub and made new file in repository named as "README.md" for brief project description.
 
 @12:32pm
 Started the 1.1 step of the project to review all folders and razor commands.

 @12:35pm finished the step 1.1.
 
 @12:36pm 
 Move further towards the 1.2 step "Debugging".
 Put breakpoints on Index and Privacy in HomeController.cs file.
 Added README.md file in repository.
 Then run  the project again and due to breakpoints not able to get it.
 Then continue the issexpress to run the server to get output till first breakpoint.
 Then continued it for one more time to get privacy policy page.
 And with this, i completed my part 1.2 of the assignment.

 @12:41pm
 Went to website bootstrapwatch.com to get a specific bootstrap theme.
 I choosed "Quartz" as my bootstrap theme and i download it.
 Then i drag and drop the downloaded theme into the wwwroot>lib>bootstrap>css file and rename the built-in bootstrap.
 
 @14:12pm

 Then, I copy and pasted the given site.css file into the running project.
 Changed the nav class from navbar-light to navbar-dark and bg-white to bg-primary.
 Edit the footer class with "text-white-50 bg-primary".
 Remove the "text-dark" in the 23rd line in same file.
 Also, removed the "text-dark" from the "_layout.cshtml" file.

 @14:15pm
 tested the project and it ran successfully.
 added additional script and css files into "_layout.cshtml".

 @14:29pm
 added dropdown in navbar and edit it according to the instruction.
 tested the code and it run successfully.

 @17:45pm
 added new project class library named "PawandeepBookStore.DataAccess"

 @22:08pm
Add another two new projects and updated README.txt file.
Then i cut the data folder from original project and pasted it in the "PawansBooks.DataAccess" project.
Installed the required packages.

@22:38pm
Deleted the migrations folder.
Added another package named "Identity.EntityFrameworkCore" in the project.


@22:52pm
oopzzzz!!!! found an error in "Startup.css" file and then in removed "using PawandeepBookStore.Data;" from the top of the file.
now : no errors are showings and i am good to go.
Deleted the default "Class1.cs" folder in all three new projects.
run the project it run successfully.
build the project successfully.
cut and paste models folder into PawandeepBooks.Models project.
edited the error.cshtml file but got errors about the namespace then fix those errors after lots of struggle.
Modify startup.cs with using statement and add context with "using Microsoft.AspNetCore.Mvc;" and "services.AddRazorPages();".
Run the application it run successfully 
i  didnot get  errors 
removed the using statement
review the errors and run the application again.
add SD.cs in utility project and modify class with properties.
add project reference to main project.
added reference to models and utility in DataAccess project.
add new area in Area named as "Customers".
changed the routes in startup.cs as mentioned in the scaffoldingReadMe.txt file.
moved homecontroller.cs into areas>customers>controllers folder and deleted the models and data folder in customers folder.
[Area("Customer")] // Added this Area attribute to specify the area
moved the Views>home into cutomers>views
it does not run now.
following further steps whether it run or not.
Copy and pasted "_ViewImports.cshtml" and "_ViewStart.cshtml" into Customer Area.
Updated the path of "_layout.cshtml" in "_ViewStart.cshtml.
Run the Website its not working 
Started part 2 
2023-11-09@22:28pm
created the migrations and modify the database name and saved it.
added migrations into .DataAccess.
Reviewed the file for the sql like syntax, clumns 
updated database by commanding in the console.
checked tables in sql server and run the application. 
It run successfully.
added category  class into .Models project and added migration via console.
added public class  into the category.cs
added using statement in Category.cs
re-run the add migration command in console.
Delete migration and re run the command add migration .
successfully got the migrations again.
added Repositoryand IRepository folder and IRepository interface in .DataAccess.
Modified  IRepository.cs to do all CRUD operation.
added the Repository.cs class and modify the code to create the constructors and dependency injection(DI).
created CategoryRepository and ICategoryRepository and modify the code of both.
modified the code in CategoryRepository.cs and ICategoryRepository.cs
made ISP_Call.cs class in IRepository and modified the code according to the instruction.
added new class "SP_Call.cs" in which i implemented ISP_Call interface, added connection to Database and updated the implementation
i got some errors and solved it BY HAVING potential solution but on error is still there which says"object does not contain a definition for Open and no accessible extension method Open accepting a first argument of type'object' could be found". and i decide to fic later on.

2023-11-13 @ 14:00pm
added new interface "UnitOfWork" and new class unit of work.
added the code into the class file.
deleted the auto generated folder"IUnitOfWork" and then added reference in UnitOfWork of IUnitOfWork to fix the final errors.
edited CS_Call.cs file to fix error and created CategoryController and controller view in the PawanSekhonBookStore folder.
Created index.cshtml razor view in the Areas>Admin>Views>Category.
Modified the code according to the given CategoryView.txt file.
Run the application and successfully got the output.
Added the category link into the dropdown menu.
modified the index.cshtml file to add the icon into the category.
Commented out the icon in the index.cshtml file and ﻿2023-10-30@12:10pm
Started the project by creating new project by my name PawanBookStore in asp.net5.0 version
Then, authenticated it for individual accounts.
I got my readymade folders such as controllers, area and data.
Added, another text file in my project to get description of it named "README.txt".
Then i commented out the port number to get the output.

@12:15pm
Checked the _ViewStart.cshtml file whether razor class library linked with _Layout.cshtml file.
Also looked whether all the deafult necessary folders are there or not.
After checking the database access, looked at the methods in the startup.cs file for the connection of https pipeline.

@12:25pm
Update database by running command in the terminal.
At first got errors because forgot to put "-" in between the update database.
 Now its time to test the project before putting it to the github.com.
 Yeehhhhhh!!!!its a successful attempt.
 Then i set password and other login details. and i successfully logged into my bookstore app.
 After, i logged out the app and log in again to verify.
 
 @12:31pm
 Created my project to git hub and made new file in repository named as "README.md" for brief project description.
 
 @12:32pm
 Started the 1.1 step of the project to review all folders and razor commands.

 @12:35pm finished the step 1.1.
 
 @12:36pm 
 Move further towards the 1.2 step "Debugging".
 Put breakpoints on Index and Privacy in HomeController.cs file.
 Added README.md file in repository.
 Then run  the project again and due to breakpoints not able to get it.
 Then continue the issexpress to run the server to get output till first breakpoint.
 Then continued it for one more time to get privacy policy page.
 And with this, i completed my part 1.2 of the assignment.

 @12:41pm
 Went to website bootstrapwatch.com to get a specific bootstrap theme.
 I choosed "Quartz" as my bootstrap theme and i download it.
 Then i drag and drop the downloaded theme into the wwwroot>lib>bootstrap>css file and rename the built-in bootstrap.
 
 @14:12pm

 Then, I copy and pasted the given site.css file into the running project.
 Changed the nav class from navbar-light to navbar-dark and bg-white to bg-primary.
 Edit the footer class with "text-white-50 bg-primary".
 Remove the "text-dark" in the 23rd line in same file.
 Also, removed the "text-dark" from the "_layout.cshtml" file.

 @14:15pm
 tested the project and it ran successfully.
 added additional script and css files into "_layout.cshtml".

 @14:29pm
 added dropdown in navbar and edit it according to the instruction.
 tested the code and it run successfully.

 @17:45pm
 added new project class library named "PawandeepBookStore.DataAccess"

 @22:08pm
Add another two new projects and updated README.txt file.
Then i cut the data folder from original project and pasted it in the "PawansBooks.DataAccess" project.
Installed the required packages.

@22:38pm
Deleted the migrations folder.
Added another package named "Identity.EntityFrameworkCore" in the project.


@22:52pm
oopzzzz!!!! found an error in "Startup.css" file and then in removed "using PawandeepBookStore.Data;" from the top of the file.
now : no errors are showings and i am good to go.
Deleted the default "Class1.cs" folder in all three new projects.
run the project it run successfully.
build the project successfully.
cut and paste models folder into PawandeepBooks.Models project.
edited the error.cshtml file but got errors about the namespace then fix those errors after lots of struggle.
Modify startup.cs with using statement and add context with "using Microsoft.AspNetCore.Mvc;" and "services.AddRazorPages();".
Run the application it run successfully 
i  didnot get  errors 
removed the using statement
review the errors and run the application again.
add SD.cs in utility project and modify class with properties.
add project reference to main project.
added reference to models and utility in DataAccess project.
add new area in Area named as "Customers".
changed the routes in startup.cs as mentioned in the scaffoldingReadMe.txt file.
moved homecontroller.cs into areas>customers>controllers folder and deleted the models and data folder in customers folder.
[Area("Customer")] // Added this Area attribute to specify the area
moved the Views>home into cutomers>views
it does not run now.
following further steps whether it run or not.
Copy and pasted "_ViewImports.cshtml" and "_ViewStart.cshtml" into Customer Area.
Updated the path of "_layout.cshtml" in "_ViewStart.cshtml.
Run the Website its not working 

Started part 2 

2023-11-09@22:28pm
created the migrations and modify the database name and saved it.
added migrations into .DataAccess.
Reviewed the file for the sql like syntax, clumns 
updated database by commanding in the console.
checked tables in sql server and run the application. 
It run successfully.
added category  class into .Models project and added migration via console.
added public class  into the category.cs
added using statement in Category.cs

re-run the add migration command in console.


Delete migration and re run the command add migration (20231114165158_AddCategoryToDb.cs)


successfully got the migrations again.
added Repositoryand IRepository folder and IRepository interface in .DataAccess.
Modified  IRepository.cs to do all CRUD operation.
added the Repository.cs class and modify the code to create the constructors and dependency injection(DI).
created CategoryRepository and ICategoryRepository and modify the code of both.
modified the code in CategoryRepository.cs and ICategoryRepository.cs
made ISP_Call.cs class in IRepository and modified the code according to the instruction.
added new class "SP_Call.cs" in which i implemented ISP_Call interface, added connection to Database and updated the implementation
i got some errors and solved it BY HAVING potential solution but on error is still there which says"object does not contain a definition for Open and no accessible extension method Open accepting a first argument of type'object' could be found". and i decide to fic later on.

2023-11-13 @ 14:00pm
added new interface "UnitOfWork" and new class unit of work.
added the code into the class file.
deleted the auto generated folder"IUnitOfWork" and then added reference in UnitOfWork of IUnitOfWork to fix the final errors.
edited CS_Call.cs file to fix error and created CategoryController and controller view in the PawanSekhonBookStore folder.
Created index.cshtml razor view in the Areas>Admin>Views>Category.
Modified the code according to the given CategoryView.txt file.
Run the application and successfully got the output.
Added the category link into the dropdown menu.
modified the index.cshtml file to add the icon into the category.
Commented out the icon in the index.cshtml file and added the javascript file into the wwwroot>js named as "category.js" file.
Also added the provided code into the category.js file.
Added the @section call to the category.js script.
Added the IAction result to the controller and added a view.
Added the Upsert view in the Category and added the given code from the Category Upsert View.txt into the new Upsert.cshtml.
Then created a partial view for EDIT|BACK in general Views>Shared folder for "_CreateAndBackToListButton.cshtml".
Added new partial view named as "_EditAndBackToList" and then added the code with modifies razoe term.
Run the application
Changed the "Title" in Upsert.cshtml to "Edit Category".
added the @ section call to Scripts to validate input on client side.
created  Upsert POST method and save and void save method in category controller .cs.
Removed the "_db.SaveChanges()" mthod in categoryRepository.cs.
moved the "_unitOfWork.Save" method with "RedirectToAction" method.

2023-11-14
@ 11:54
From last night i was trying to run the application but when i tried to add new category it was showing an exceptional error.
did many attempts to resolve that error but today finally got to know that the category exceptional error was due to my un updated migration and then
i create new migration file to get the output. 
added the API call for HTTPDelete in categoryController.cs
Implemented the HTTPDelete with a delete method in category.js to add the functionality to the application and call the API.
12:25pm
added the Delete function url code into the category.js in which sweet alert is used for success and error message and toastr for notification.
run the application.
didnot run properly 
corrected the spelling mistakes in delete url and run it again. 

2023/11/20 @ 23:11pm************************PART-3.1**********************
added new coverType CRUD  in PawanBooks.Models and included properties like name and id in it.
added CoverType to UnitOfWork and IUnitOfWork.
Pushed CoverType in to the Database.


added migration and updated database            STAMP : 20231121063646_AddCoverTypeToDb.cs*************************************



added CoverType to NavBar, CoverType Controller, CoverType Index, Upsert View for updating and creating CoverType.
added the coverType.js file 

added product class in .Models project and made the class public in it amd added code to build the blueprints of this class.


added the migration and updated the database.     


              STAMP :       20231121074611_AddProductToDb.cs*********************************************



updated product.cs with "required method".

Create migartion and ad validation and uodated database.

            STAMP  :         20231121082011_AddValidationToProduct.cs*****************************************


Created ProductRepository.cs and IProductRepository and modified the ProductRepository.cs to include ImageUrl of Product Object.
Added Product into UnitOfWork and IUnitOfWork. 
Then i build the solution and it run successfully

***********PART-3.2**********************************************

i modified the ProductController.cs
i created a ProductVM.cs  view model
Then
i installed package "Microsoft.AspNetCore.Mvc.ViewFeatures" in packager install

i modified ProductController.cs file 
update API call to include the Category 
CoverType Properties.....
i modified the product index view file,
added Title, ISBN, Price, Author and Category
updated URL in  product.js file 
i modify the _Layout.cshtml file to add a
new link of product in nav bar


run the application to test
yupppppppppppp 
its working

its time to move Forword
