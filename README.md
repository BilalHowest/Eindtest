# Continuous Integration Basics
## Eindevaluatie
### HowestShop

In deze opdracht ga je aan de slag met de Howest Shop. In deze shop kunnen we enkel producten toevoegen en verwijderen. Wanneer alles correct ingevuld wordt bij het toevoegen van een product (klikken op de knop _Voeg toe_) wordt het product toegevoegd en wordt de listbox aangepast. Men kan ook producten verwijderen uit de lijst door op de knop _Verwijder product_ te klikken.

Voor elke opdracht geldt dat de gemaakte **afspraken** en **best practices** moeten gevolgd worden.
Commits mogen gemaakt worden vanuit TeamExplorer in Visual Studio. Mocht je gebruik maken van Git Bash, vergeet dan niet eerst alle bestanden op te slaan alvorens je een commit uitvoert! Anders worden de wijzigingen niet meegenomen in deze commit!

Maak voor opdracht 1 & 2 **PER** opdracht een nieuwe branch aan. Voer een Pull Request uit via GitHub naar de branch **dev** wanneer je klaar bent met een opdracht. Daarna pull je de branch **dev** naar je lokale computer.
Als afwerking zorg je ervoor dat **ALLE OPLOSSINGEN** gebundeld worden in de branch **master**. Hiervoor zal je terug met een Pull Request aan de slag moeten.

**Enkel de branch master zal verbeterd worden!**

## Opdracht 1
In de WPF applicatie zijn 2 **bugs** in de layout geslopen. Bij twee labels staan er rare tekens.

- Maak een branch **dev** aan op basis van de branch master
- Maak een branch **wpfbugs** aan op basis van de branch **dev**
- Pas de bugs aan in de code en doe hiervoor **passende commits**
- maak een pull request aan naar de branch **dev**, voer deze uit.
- Zorg ervoor dat je lokaal over de bijgewerkte branch **dev** beschikt

## Opdracht 2

Bij het toevoegen van een product kunnen voorlopig lege waarden (naam, categorie en prijs) toegevoegd worden.  Dit kan zorgen voor een inconsistentie van de data van onze producten of zelfs voor exceptions kan zorgen.

Door middel van het schrijven van unit tests is het de bedoeling dat alle **foute en correcte** scenario's  getest worden.


- Maak vanuit de branch **dev** een branch **unittest** aan
- Voeg hiervoor een **xUnit Test Project (.NET Core)** project toe in de solution. 
Geef dit project **CIB.Exam.HowestShop.Tests** als naam. 
- Voeg een testklasse toe met de naam `ShopServiceTest` en voeg hierin uw eigen geschreven testmethodes toe
- Test minstens deze scenario's:
    - Name of new product is required
    - Category of new product is required
    - Price of new product is required
    - Price of a product cannot be zero
    - Price of a product cannot be less than zero
    - Price of a product cannot be more than 5000
    - Productlist must be updated when a new product is added
    - Productlist must be updated when a product is removed
    - Show warning when user wants to remove a product when no product is selected

- Om foute scenario's op te vangen pas je de code aan in de methodes `AddNewProduct()` en `DeleteProduct()` in de `ShopService` klasse van het CIB_EE_HowestShop.Lib project. Enkel en alleen in deze methodes mag code aangepast worden voor deze opdracht.
Je mag foute scenario's kenbaar maken door het gooien van Exceptions die opgevangen worden in het CIB_EE_HowestShop.WPF project. De exception messages zullen getoond worden door middel van een MessageBox. De code hiervoor is reeds voorzien.

- Maak **per afgewerkte test** een passende **commit** en plaats online.
Denk hierbij aan de best practices in verband met unit testing!
- Maak na het het afwerken van alle tests een pull request aan naar de branch **dev**, voer deze uit.
- Zorg ervoor dat je ook lokaal over de bijgewerkte branch **dev** beschikt


## Opdracht 3

- Maak vanuit de branch **dev** een branch **visualize** aan
- Ga naar [https://git-school.github.io/visualizing-git/](https://git-school.github.io/visualizing-git/) en maak de onderstaande git flow na. Om je scherm leeg te maken kan je gebruik maken van het commando `clear`. Wens je een stap terug te keren? Maak dan gebruik van het commando `undo`. Bij deze opdracht hoef je geen titel toe te voegen aan je commits. Het `git commit` commando is voldoende voor deze opdracht.
- Wanneer je klaar bent maak je een screenshot van je volledig scherm, inclusief browser en zichtbare taakbalk van Windows. Je moet de afbeelding niet bijsnijden. Je voegt deze afbeelding toe in de map **Opdracht3** in deze online repository.

![image](/Opdracht3/git-flow-opdracht.png)

- Commit de wijzigingen en plaats online
- Maak een pull request aan naar de branch **dev**, voer deze uit.
- Zorg ervoor dat je lokaal over de bijgewerkte branch **dev** beschikt

## Afwerking
- Maak een laatste **Pull Request** van de **dev** branch naar de **master** branch
- Vergeet deze niet volledig af te werken (denk aan approve en merge)
- **CONTROLEER DE BRANCH master ONLINE VIA DE WEBSITE VAN GITHUB: dit is jouw volledige oplossing**

## Afspraken

- Elke vorm van **fraude (kopiëren van code/opdracht, ...)** wordt bestraft met een nulscore.
- Raadpleeg gerust je mag de cursus, oefeningen en PE-opdrachten raadplegen
- Gebruik van internet is toegestaan, al is dit niet aan te raden, alles wat nodig is werd gezien in de lessen en is aanwezig in de cursus.
- De versie die voor verstrijken van de deadline op GitHub Classrooms staat zal gebruikt worden om te verbeteren. Controleer dus zeker als alle commits en Pull Requests aanwezig zijn. 
- Je komt je uitwerking vervolgens op de ingeplande dag even verduidelijken.

