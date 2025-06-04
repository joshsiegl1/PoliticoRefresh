Politico is a game programmed by Joshua Siegl

The main idea is to build a fun and flexible city building game with support for a whole variety of disasters and positive outcomes. 

Interesting gameplay mechanics include political affects on the city, foreign policy, economic affects and just about anything you can think of that can happen to a real city. 

More expansive goals would be to make it into a Monopoly GO type of experience where the game progresses on a turn-based theme. Pressing the GO button would trigger a Day/Night cycle. Buildings would come up, money would be earned, attacks would commence ect.

This project utilizes Monogame for cross-platform development. Monogame relies on the C# programming language and this project tries to take advantage of OO best practeces to the best of our ability.

The rest of this documentation will be dedicated to technical information regarding the application. 

#Map Data: 
    The Map Data is just a string of numbers that correspond to the [Tile Numbers](#tile-numbers) listed below. 0's can be swapped out with any other number within the [Tile Numbers](#tile-numbers) list to display that type of tile. The tiles are generated using a [Factory Pattern](https://www.codeproject.com/Articles/1131770/Factory-Patterns-Simple-Factory-Pattern)
    with calls to [TileFactory.cs](PoliticoRefresh.Core/Game/Tile/TileFactory.cs) to return the proper tile. 

#Tile Numbers: 
    Tiles are identified by numbers that are set in an abstract function within each of the respective tiles' class. A list of these numbers are as followed. To add a new tile to the game, follow the instructions [here](#create-a-new-tile)

    0: Empty
    1: Grass
    2: Capitol
    3: Road
    4: House
    5: Wind Turbine
    6: Coal Factory
    7: Corporation
    8: Corp Factory? 
    9: Apartment
    10: Condo
    11: Police Station
    12: Fire Station
    13: Water
    14: Tree

    You can see this pattern mimicked in  [TileFactory.cs](PoliticoRefresh.Core/Game/Tile/TileFactory.cs)

#Create a new Tile
    This is a list of things you'll need to do to add a new tile type to the game. 

    Day/Night texture
    Create a new class with the name of the tile
    Come up with a new unique random number for the tile. 
    Decide on the proper overrides (CanBeDestroyed, CanBePlaced, ect.)
    Reference the base Tile class for help