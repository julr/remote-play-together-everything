# Remote Play Together Everything
> A small tool to play games together via Steams Remote Play Together that don't officially support this feature.
> The game does not even have to be a steam game.

## Prerequisites
This tool needs the [.NET Desktop Runtime Framework](https://dotnet.microsoft.com/download/dotnet/5.0) to be installed.

## Installation
- Install a game via Steam that supports Remote Play Together (search for free games in the Steam store)
- Replace the games EXE File with RPTE.exe

## Usage (UI)
Launch the game installed earlier via Steam.\
Everything is controlled via the right click context menu.\
Games can also be launched via a double click.

## Usage (Command Line)
Games can be launched without involving the UI via the command line parameter. This can either be
- the number of the game in the list (starting with 0) e.g. `RPTE.exe 0`
- the name of the game in the list e.g. `RPTE.exe "My Game"`

This can be set in the game properties in Steam of the game installed earlier or launched directly 
e.g. via a steam link `steam://rungameid/12345//My Game` or by directly calling Steam e.g. `Steam.exe -applaunch 12345 "My Game"`.\
Of course `12345` has to be replaces with the id of the game installed earlier.