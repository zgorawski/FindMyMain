![alt tag](https://raw.githubusercontent.com/zgorawski/FindMyMain/master/FindMyMain/Content/Images/logo.png)


Project created for Riot API Challenge 2016. It's a game where you are trying to guess who is the main champion of random player that you recently played with. By 'Main' we understand champion with highest mastery score.

When you select non-main champion he is trying to provide you with additional tips that helps you to narrow selection, based on common points of selected and main hero (read more in **Answer Engine** section below).

# Demo

http://findmymain.azurewebsites.net
(first launch may take a while - Azure has to warm up..)

# Usage

To launch project locally follow those steeps:

- clone repository
- open project in Visual Studio 2015 (developed on Community Edition)
- download dependencies (Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution...)
- create  'RiotAPIKey.config' in directory ABOVE cloned project. Copy to it template below and replace {API_KEY} with a real key.

```xml
<appSettings>   
   <add key="APIKey" value="{API_KEY}" />
</appSettings>
```

# About us

Created by Ethylparaben &amp; Vinidrea - a marriage of Summoners from EUNE.

# Answer Engine

Backbone of this project - each champion is described by series of tags:

- Role Tag
  * Tank, Fighter, Slayer, Mage, Controller, Marksmen
- Region Tag
  * 12 most common places + Other
- Perk Tag
  * Animal, Shapeshifter, Pet Champion, Health Cost Abilities, Global, Yordle
- Skin Tag
  * 40 most common skin groups (like PROJECT or Blood Moon). Team skins were omited (like SSW or SKT)
  
when player selects champion, Answer Engine is making intersection of selected and main champion tag sets and based on result an answer with hit(s) is prepared. Additionaly several champions have unique quotes, eg: selecting *Miss Fortune* when Main is *Gankplank* results in *"I've defeated him in the GrugMug Grog Slog competition."* quote, which is reference to Bilgwater events from LoL lore.

# Backlog

- provide more unique quotes
- support all skin groups
- make filter input on game screen non-scrollable
- improve style of scrollbars
- improve 'victory' experience
- allow champion to have more than on Region Tag
