

type Details =
  { Name: string
    Description: string }

type Item = 
  { Details: Details }

type RoomId =
  | RoomId of string

type Exit =
  | PassableExit of string * destination: RoomId
  | LockedExit of string * key: Item * next: Exit
  | NoExit of string option

and Exits = 
  { North: Exit
    South: Exit
    East: Exit
    West: Exit }

and Room = 
  { Details: Details
    Items: Item list
    Exits: Exits }

type Player =
  { Details: Details
    Location: RoomId
    Inventory: Item list }

type World = 
  { Rooms: Map<RoomId, Room>
    Player: Player }
