﻿23/11/2022
i would like to mention one thing here
actually 
i do have five project in previous project that on github 
because of that i decided to make it from starting 
the project that i have are 
LovepreetBokkStore.Data and 
LovepreetBookStore.Data
because that i was facing problem to do previous one 


now i am just putting my previous project content here 
and pasting my previous README.txt file here
10.52
﻿2023/10/23
3:41
1 create a Mvc project for assignment 2 by name of LovepreetBookStore
then 
open my github 
create a public repositary same a project name
push my project 
3.43
add a new file README.txt
and commit
new i am going to test it in college i comment the ssl 
27/10/2023
10.45
examine all code in visiual studio 
and also know about how beakpoint 
at idex and privacy 
then run it 
and hit continue 
sooooooo
it show welcome massage page
then i click on privacy 
it runs back to visual studio 
then i hit continue 
i can see privacy 
then i took a break 
11.20am
i return back and 
i fogot to register them i tried to resister
but i was  doing login 
it return in valid password 
then i register and set password
it shows exception 
and its because of i have not applied migration 
then i applied migration from brower
...
../
/
/
now iam tring to login my resiter account
let's go
11.26
 first i was unable because of breake points 
 then i remove and test it 
 its good to go
yup 
i did it......
now its time to do 1.3 bootstrap
I CHOOSE FLATY THEME AND DOWNLOAD BOOTSTRAP.CSS
then.....
i took break and enjoy the outside view 
then return to work
1:09 pm
i clone repo on my own computer 
remove comment from ssl
the run it
it was good to go ahead
rename exiting site.css file and add new site.css which is provided by Andrew
modify layout.css and also 
rename the bootstrap and add new bootstrap add to layout.cshtml 
1:33pm and also
//
/
modify layoutpartial.css
then run it 
yupppp......
 i did it 
 i did not understand the next i took a break
after long break
10.21am 
28/10/2023
first i added contentMangemet in navigation bar
then i did
alot of struggle to add drop down item 
after long search i add it i took little bit help from youtube 
actually i a following a channel coding ninja where i found this method
first i changed nav-item to class="nav-item dropdown
this is css style
then 
<a> modify toggles the dropdown menu
class="nav-link dropdown-toggle" classes the styling of the link,  function as a dropdown toggle.
href="#": The href attribute is set to # to make the link clickable but not direct to any actual page.

placeceholder href attributes, usually for JavaScript-enabled functionality. Replace # with actual URLs as needed.
same day
evening
6.06
i started work again on my assignment afetr setting up the phpstrom for assignment 
i test it again 
i can,t believe on my eyes 
its working without any mistake
now......................................
i am going to satrt 1.4 part
at 6.08
first create 3 more project as previous one
upssssssssssssssssssss.......
i created wrong one as previous mvc
now i delete all create project 
then search for claass library i found it 
i create its on another name 
them also delete
4.00 23/10/2023
i found right one now i am going to create it with class library
and insatall two commands 
but i was unable.......
then i create first project LvepreetBook.DataAccess
them addd Data folder to it And 
then install relational comand
then i delete migration folder

and insatall command
then sqlserver
again i did same thing for Mondel and utility
them i copied Model folder to LovepreetBook.models
And i got three error 
thn i read definition and solve it them
them i provide rference
now i am ready to go forward
5.30 create static class in LovepreetBook.Utility project
then modify the properties of sd class to public
then 
5.37 going to add Project references to Main project
also add roject references to DataAccess project 
.37 going to add Project references to Main project
also add roject references to DataAccess project 
5.52
I add new mvc area By name Customer
first i was enable them i remove error add it again
6.12 
i changed routes in satrtup file to customr
then i moved homeController.cs to area- customer- controler
and delete model,Data folder
Edit homecontroller [Area("Customer")]
them rum it it gave me masssage local host is not found 
uppppppppppppppppppppp.............................................
then i add pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}"); to satrtup file 
and run it 
yupppppppppppp it wil work
30/10/2023
9.47
i startrd again 
and test it it worked proper
but bootstrap and css is not working
then i followed toturial slides again 
copied _viewImports.cshtml and _viewStart.cshtml to Cutomer area and
Changed path in _ViewStart.cshtml 
And then test it
yupppppppppppppppppppppp
its working
and New mvc Admin area to area and delete Data Model Folder
10.06
Delete the Controller from Area Folder
Finally
I cant believe its Completed 
yuuup
Lets dance ......................
At last i edit dropdown menu
references:
https://getbootstrap.com/docs/4.4/components/dropdowns/
then edit in to 
Man Love preet
5/11/2023
i start project again 
**************
Now i have done part one of project now its time to move part 2



27/11/2023
1.45aam
12.41
update appsetting.json to  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=LovepreetBookStore;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
i run command AddDefualtMigration 
first i tried it at LovepreetBookStore
as folow toturial 
i run it in side LovepreetBook.DataAccess project i
it succed
*********20231127084224_AddDefaultIdentityMigration**********
1.01pm 
run update-database command
yuppp 
it run succed
then after some time it run Add-migration AddCategory file but it was first time successful 
second i add calass category.cs
bthen update aaaaa applicationDbCotext.cs 
then again run Categories migrataion file 
after analysing i solve tehe problem get data in migration file.
2.58 i run update-Database commmand finally i did it 
20231127085203_AddCategoryToDb
***********************************************************
finaaly its time to go ahead 
and i am at 2.2 repositary

add folder name as Repository in .DataAccess 
and by Repository folder add IRepository folder under folder add 
item namedby IRepository.cs

 modifing file to do through all crud operations...........

3.05
Add new class Repository.cs in Repository folder
then 
i add  use statement and potential fixes to remove errors
after
Modify create the constructors 
3.30
i add an indivdual repos for category named CategoryRepository.cs 
and ICategoryRepository.cs 
modify CategoryRepository.cs
while fixing i got errors and solve them using potential errors like adding name spaces
also using statements

4.03
add interface folder named by ISP_Call.cs 
which extends IDisposable
then 
i install the NuGet Package for 'Dapper' as shown in potential fixing eroor solution
then i add it in using statement


4.15
add class sp_call.cs in Repository folder
implementing ISP_Call.cs interface
then i add database connection

8.12
updating  ISP_Call.cs interface

then i got a email in my inbox tomorrow class is cancel
and i left my all assignment and take breake

8/11/2023
11.23
add interface class name IUnitOfWork.cs in IRepository folder 
and update it as shown in pptx
after............
i add UnitOfWork.cs class in Repository 

and services in startup.cs 
its time to satrt

********************* part 2.3
12.10
create a CategoryController in Areas-Admin-Controller 
create a CategoryController in Areas-Admin-Controller 
and update.................

then
add index view html file in Areas-View a
modify with code which is provided Assignment2- files folder( Category Index View.txt.....)
then link it in layout page
run the app
is good to go


12.30
add the icons in the Category through Font Awesome 4
and confirm by run the appliction
in wwwroot-js folder name as category.js
add @section call to the category.js 


12.45
appling activate  'Edit' and 'Delete' buttons and 
using the Upsert action....
copy and paste the code from Category Upsert View.txt 
after
create partial
_CreateAndBackToListButton.cshtml file 
in View-Shared fold
 _EditAndBookToListButton and add @model razor statement 


1.00
i update Upsert.cshtml 
then run application
added @section call to Scripts in Upsert.cshtml file

13/11/2023
at last------------------
i added the API to call for HTTPDelete in the CategoryController
delete funtion in category with including the onclick 
I completed  part2 
but create button not working...........

14/11/2023
comment
ssl
 //"sslPort": 44308 to run on local
 i tried to run 
 but no output found then i aplied migration 
 now its good to go a head


 its Time to go a head 
 part 3 Section 1 ***********************
 i create new class named coverType same as crud type way
 10.30
 i was trying to create it 
 
 
create CoverType.cs in LovepreetBook.Model project 
Then
add id and name 
then
i added CoverTypeRepository in Repository folder 
and ICoverTypeRepository interface to IRepository folder
then add CoverType to UnitOfWork class and IUnitOfWork interface

20-11-2023
 then i open ApplicationDbContext.cs file and write 
  public DbSet<CoverType> Covertypes { get; set; }
  ***********************
  then save it and run it i got 
  migration in my account
  the name is 
  ***********20231121004220_AddCoverTypeToDb********
  then update data base
  8.02
  i add new covertype cotroller
  then added some important method like upert, delete, get all, remove, delete 
  then i remove all the errors through potential solutions 
  8.34
  Then i added new folder CoverType in Areas/Views
  then i added new view Index.cshtml
  then i added new view Upsert.cshtml
  Also i add coverType.js file in www.root/js
  and create delete and upsert method also 
  call api to delete and edit method
  11.07pm
  add new migration toproduct
  888888888888****20231121040447_AddProductToDb*******8888888888888
them update data base
i applied Required method  "Title", "ISBN" and "Author", 
create add migration "AddValidationToProduc
*****************20231121054215_addValidationToProduct*************
then
Update-database

1.52
i create ProductRepository to Repository 
IProductRepository to IRepository 
the ProductRepository.cs file......
then create ProductContoller, js, 
index and upsert view same as the coverType 
and add into UnitOfWork And IUnitOfWork
3.42
***************************part-3.2 ******************************
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


3.50
run the application to test
yupppppppppppp 
its working

its time to move Forword
than 8.09 pm
27/11/2023
i tried two to do 3.3 part
then i move ahesd and i
addd tinyCloud and
then comment Assignment2 in projectController
and 
i add a folder name products i wwwroot-images
i uncomment method again
hey i foreget to add jawascriptfile for product
i add this in js

10.51
part-4  
i compare my code with repositary that is provided by you
and 
i up date 
SD.cs 
CoverTypeController.cs
Upsert file in CoverType View
28/11/2023 10:30
Comment ssl to run on pc

05/12/2023
1.58
i had problem in covertype
local host is not found
https 500

then i review my cover type controller, index and upsert for covertype
also CoverType.js
i updated all these files
but its not working
then i review repositary and iRepositary file 
all methodes are prefectly define
then..............
 i added           
edited index home page 
so taht it loads images on home page for me 
 then i tried to load data
 but i was un able
 i do not know why is not working 
 i think because of js files are not working
 2.16
 then i create new product 
 prouduct added success but images can not see on  home screen


 my previous project is not working because of too many exceptions
 the new migrations are:-
 20231127084224_AddDefaultIdentityMigration
 20231127085203_AddCategoryToDb
 20231127220156_AddCoverTypeToDb
 20231127230502_AddProductToDb
 20231127230704_addValidationToProduct
 20231127230704_addValidationToProduct

