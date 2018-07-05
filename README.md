#  Shop Site
## Technologies used
* Webforms - I learnt and used webforms as well as I could given the timeframe. It felt familiar, a lot of the same ideas are used in Microsoft Access which I have spent a lot of time in.
* CSharp - 	I considered using VB but given the timeframe I would have risked not finishing the project at all. However I did spend time comparing looking at VB and again I found the language very familiar. I have spent a lot of time working with VBA and so the syntax is the same.
* Bootstrap - I don't normally use Bootstrap but it was straight forward to pick. I tried to use it as much I can without resorting to custom classes.
* Less.css - I've never used less before so I didn't have time to take full advantage of its uses. I mostly used the variables feature which was useful.
* No ORM - It was stated on the requirements not to use Entity Framework. I took this to mean no ORM whatsoever. Instead I have used simple SQL queries to pull data from the database	
* SQL scripts - I have stored the database file under App_Data. All scripts can be found in the .mdf file but they are very straight forward. I used a view to join the tables and a stored procedure to pull the data.
## Architecture
* Due to my inexperience with webforms I wasn't completely sure where to keep the classes and decided upon the App_Code folder. This may be the wrong place but didn't have enough time to do the research on best practices. I would normally separate the Data repositories and Business logic into separate projects but  I chose to keep everything in one self contained project for simplicity.
* I made sure to use the separation of concerns design principle to separate the data access layer, the business logic and the front end. I have used a data repository to get the data, service layer for business logic and leaving the Asp pages to only handle the client logic. I have also used two models - a database model to describe the database and data transfer objects to describe how the views should be modelled. In this particular exercise the two models happen to be same.
## Site Functionality
### Site
* Header and footer included even though not required
* Header logo redirects to main page
### Home page
* Resposive grid layout of images
* Animations of panels on hover
* Click on image to direct to the details of that particular product
* Doesn't show description as is too much information
### Details page
* Navigated to via main page. Shows a single product based on the queryString used.
* Shows description
* Back button
## What I would have done given more time
* The image is stretched in the details page when the window is resized
* Missing prices in details page
* Prevent the details page from being navigated to without a queryString included
* Limit the number of products per page and build in pagination