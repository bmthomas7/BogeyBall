# BogeyBall
## SchoolApp

### The School WebAPI provides school administrators and staff access to their student and teacher records and links them to courses, extracurricular activities, and discipline records.

#### Table of Contents
1. Description
1. Installation
1. Usage
1. Credits
1. License

#### 1. Description
The Bogey Ball webMVC allows a golfers around the world to be able to keep their scorecards in one central hub. this program will allow a player to create their name, create your local golf clubs, and then be able to enter not only the golf courses strokes per hole, but also be able to enter the players strokes per hole. once the player inputs their information into the three different tables, they will be able to see the handicap that they got on that scorecard.

the Bogey Ball MVC connects three data tables: Player, Course, and ScoreCard

#### 2. Installation 
BogeyBall is a .NET Framework webMVC built using Visual Studio with Entity Framework, Bootstrap, and jquery. It uses C#, Javascript, and HTML.

#### 3. Usage: 
The following endpoints are used to add, update, delete, and retrieve information from the various databases.

* Player Database
  * player/Create - This endpoint creates a new Player. In the body, it requires a Player Name.
  * Player - This endpoint returns a list of all Players and players id
  * Player/Edit/{id} - This endpoint allows the user to change a specific palyers name based on their id
  * Player/Details/{id} - This endpoint allows the user to view a players name and player Id
  * Player/Delete/{id] - This endpoint allows the user to delete a specific player from the table
   
* Course Database
  * Course/Create - This endpoint allows the user to Create a course name, coourse location, and a tee time
  * course - this endpoint allows a user to be able to view all of the courses that have been created.
  * course/edit/{id} - this endpoint allows a user to change the name of the course as well as the tee time
  * course/details/{id} - this endpoint allows the user to view the course id, course name, course location, and the tee time
  
* ScoreCard Database
  * ScoreCard/Create - this end point allows the user to enter the players id, courses id, all of the courses holes (1-18), as well as all 18 of the score holes (1-18), doing this will also automatically calculate the handicap that will be shown elsewhere.
  * ScoreCard - this endpoint will allow the user to view the scorecard id, course, player, the score that the player shot, as well as the handicap
  * scorecard/details/{id} - this endpoint will alow the user to view the scorecard id, player, course, and their score that they shot that round

#### 4. Credits: BogeyBall MVC is built by Ben Thomas in Red Badge of Eleven Fifty Academy.
