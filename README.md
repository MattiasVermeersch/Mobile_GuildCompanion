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
- ... 
Er kunnen nog opties toegevoegd worden die verband houden met de Native Services die in de app moeten komen. Op dit moment heb ik nog geen idee van welke services ik erin zou willen stoppen. 

#### Characters
Deze pagina toont een lijst van alle characters die de gebruiker heeft. Er kan op een character geklikt worden om de details te zien. Hier zou ik willen afwijken van mijn eigen API en de gegevens van de character oproepen via de API van World of Warcraft. De precieze details moet ik nog uitzoeken maar hier is de link om te starten https://develop.battle.net/

Het is ook mogelijk voor de gebruiker om een character is zijn lijst toe te voegen of te verwijderen.   
TODO: uitzoeken hoe de gebruiker op een makkelijke manier zijn character kan toevoegen aan de lijst via de WoW API.

#### Account
Hier kan de gebruiker de account gegevens raadplegen en aanpassen indien nodig.
Ik speel hier met het idee om een Camera service te gebruiken zodat de gebruiker, indien gewenst, een selfie kan maken om af te beelden op zijn account.

#### Events
Hier kunnen gebruikers op events klikken om te kunnen deelnemen of aanmaken.
Gebruikers die de rol Raidleader of Warlord hebben kunnen raids of battlegrounds aanmaken, alle gebruikers kunnen arena's en dungeon runs aanmaken. 

## Extra info
Plaats hier de nodig informatie om het
project te kunnen uitvoeren:

- API keys of nodige secrets
    * WoW API:
        + Client ID: b5f680d811d44e23b82235f19c01fb94
        + Secret: RjAiMZ2T88I6Dd2RtujqXIcwwfvhn11r
- Logingegevens
- Database configuraties
- ...
