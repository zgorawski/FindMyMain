![alt tag](https://raw.githubusercontent.com/zgorawski/FindMyMain/master/FindMyMain/Content/Images/logo.png)


Project created for the Riot API Challenge 2016. It is a game where you are trying to guess who is the main champion of a random player that you have recently played with. By *'Main'* we mean the champion with the highest mastery score.

When you select a non-main champion, they are trying to provide you with additional tips that help you to narrow selection, based on the features the selected and main hero have in common (read more in the **Answer Engine** section below).

# Demo

http://findmymain.azurewebsites.net

(first launch may take a while - Azure has to warm up..)

# Usage

To launch project locally follow those steeps:

- clone repository
- open project in Visual Studio 2015 (developed on Community Edition)
- download dependencies (Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution...)
- create  'RiotAPIKey.config' file in directory ABOVE the cloned project. Copy to it template below and replace {API_KEY} with a real key.

```xml
<appSettings>   
   <add key="APIKey" value="{API_KEY}" />
</appSettings>
```

# Answer Engine

Backbone of this project - each champion is described by a series of tags:

- Role Tag
  * Tank, Fighter, Slayer, Mage, Controller, Marksmen
- Region Tag
  * 12 most common places + Other
- Perk Tag
  * Animal, Shapeshifter, Pet Champion, Health Cost Abilities, Global, Yordle
- Skin Tag
  * 40 most common skin groups (like PROJECT or Blood Moon). Team skins were omited (like SSW or SKT)
  
When the player selects a champion, the Answer Engine makes an intersection of the selected and main champion tag sets and an answer with hint(s) based on the result is prepared. Additionally, several champions have unique quotes, e.g.: selecting *Miss Fortune* when the Main is *Gangplank* results in *"I've defeated him in the GrugMug Grog Slog competition."* quote, which is a reference to the Bilgewater events from the LoL lore.

# Backlog

- provide more unique quotes
- support all skin groups
- make filter input on game screen non-scrollable
- improve style of scrollbars
- improve the 'victory' experience
- allow champion to have more than on Region Tag


# About us

Created by Ethylparaben &amp; Vinidrea - a marriage of Summoners from EUNE.
