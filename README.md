# Football League Management System

## Overview
This project is a **Football League Management System** built using **ASP.NET Core** and **Entity Framework Core**. It allows managing football teams, players, coaches, referees, matches, and stadiums with a structured database design.

## Features
- Manage **Teams** (Create, Read, Update, Delete)
- Manage **Players**, **Coaches**, and **Referees**
- Assign **Contracts** to players, coaches, and referees
- Schedule and manage **Matches**
- Handle **Stadiums** and their availability
- Track **Player Actions** (Goals, Assists, Cards, etc.)

## Entities
The project includes the following main **entities**:

- **Action.cs** → Represents in-game actions (goals, assists, fouls, etc.).
- **Coach.cs** → Stores details about coaches.
- **CoachContract.cs** → Manages contracts for coaches.
- **CoachNum.cs** → Keeps track of coach-specific identifiers.
- **Match.cs** → Represents scheduled matches.
- **MatchTeam.cs** → Links teams to matches.
- **Person.cs** → Base entity for shared attributes (name, age, etc.).
- **Player.cs** → Stores player details.
- **PlayerAction.cs** → Tracks player statistics in matches.
- **PlayerContract.cs** → Manages contracts for players.
- **PlayerNum.cs** → Stores unique numbers for players.
- **PlayerPosition.cs** → Manages player positions on the field.
- **Referee.cs** → Stores referee details.
- **RefereeContract.cs** → Manages referee contracts.
- **RefereeNum.cs** → Keeps track of referee-specific identifiers.
- **Stadium.cs** → Stores stadium details.
- **StadiumProhibition.cs** → Manages stadium usage restrictions.
- **Team.cs** → Stores team details.
- **TeamPlayer.cs** → Manages the relationship between teams and players.

## Technologies Used
- **.NET 8** (ASP.NET Core MVC)
- **Entity Framework Core** (EF Core) for ORM
- **SQL Server** for database management
- **LINQ** for querying data
- **Fluent API** for database relationships

## Installation & Setup
### 1. Clone the Repository
```sh
git clone https://github.com/your-username/football-league.git
cd football-league
```

### 2. Configure Database
- Update `appsettings.json` with your SQL Server connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=FootballLeagueDB;Trusted_Connection=True;"
}
```

### 3. Apply Migrations
Run the following commands to create the database:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the Application
```sh
dotnet run
```
Then open `http://localhost:5000` in your browser.

## Contributing
1. Fork the repository.
2. Create a new branch: `git checkout -b feature-name`
3. Commit your changes: `git commit -m "Added a new feature"`
4. Push to the branch: `git push origin feature-name`
5. Submit a pull request!
