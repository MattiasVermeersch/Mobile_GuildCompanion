# World of Warcraft: Guild Companion

## Project
### Inleiding
Voor mobile development wil ik mijn WoW events API gebruiken van vorig jaar. Gebruikers kunnen events aanmaken zoals Arena matches en Dungeon runs. Er kunnen ook Raid runs en Battleground matches aangemaakt worden maar dit kan enkel door Raidleaders en Warlords respectievelijk. 

### De app
De eerste page is een Flyout Page waarin een oplijsting staat van opkomende events. Ik zou eventueel met een Tabbed Page werken zodat de gebruiker kan kiezen tussen PvE en PvP events. 
In het menu van de Flyout kan de gebruiker een aantal opties zien:
- Characters
- Account
- Events
- Logout

###Native Services
1. Camera Service
Gebruikers kunnen de camera van hun smartphone gebruiken om een foto te maken voor hun profiel. 

2. Notification Service 
Wanneer een gebruiker inlogt krijgt hij/zij een notification wanneer een event waar hij/zij zich voor ingeschreven heeft op de dag van inloggen plaatvindt. In de notificatie moet te zijn wat de event is en om hoe laat die plaats vindt.
Voorbeeld: "U heeft een Dungeon run vandaag om 20:00h".

3. Lokale dataopslag Service
Te gebruiken in combinatie met de Camera Service zodat de gebruiker zijn/haar profiel foto's lokaal op te slaan en eventueel kan switchen in meerdere foto's die gemaakt werden. Er moet dan ook een optie voorzien worden om foto's op te slaan en te verwijderen. 
De lokale dataopslag moet misschien ook aangesproken worden bij het opslaan van de API URL's voor het ophalen van Character data.

#### Characters
Deze pagina toont een lijst van alle characters die de gebruiker heeft. Er kan op een character geklikt worden om de details te zien. Hier zou ik willen afwijken van mijn eigen API en de gegevens van de character oproepen via de API van World of Warcraft. De precieze details moet ik nog uitzoeken maar hier is de link om te starten https://develop.battle.net/ 
De info van een character gaat over:
- Gear
- Health
- Resource power
- Main Stat
- Stamina
- Secondary stats:
	+ Critical Strike
	+ Haste
	+ Mastery
	+ Versatility

PvE stats:
- Dungeon stats
- Raid stats

PvP stats:
- Honor
- Honorable Kills
- Arena ratings
- Battleground ratings

Het is ook mogelijk voor de gebruiker om een character is zijn lijst toe te voegen of te verwijderen.   
TODO: uitzoeken hoe de gebruiker op een makkelijke manier zijn character kan toevoegen aan de lijst via de WoW API.

#### Account
Hier kan de gebruiker de account gegevens raadplegen en aanpassen indien nodig.
Gegevens die nodig zijn voor het account zijn:
- Email - Required
- Birthday - Required
- FullName - Required; Kan aangepast worden naar een "AccountName".
- Address
- City

De guild maakt ook hevig gebruik van Discord en zou ook een Discord Id willen toevoegen.


#### Events
Hier kunnen gebruikers op events klikken om te kunnen deelnemen of aanmaken.
Gebruikers die de rol Raidleader of Warlord hebben kunnen raids of battlegrounds aanmaken, alle gebruikers kunnen arena's en dungeon runs aanmaken. 

## Extra info
Plaats hier de nodig informatie om het
project te kunnen uitvoeren:

- API keys of nodige secrets
    * WoW API
    * Eigen API
- Logingegevens
- Database configuraties
- ...
