#Solid principi

###1. Single Responsibility Principle - Princip pojedinačne odgovornosti

**Klasa bi trebala imati samo jedan razlog za promjenu.**

U suštini ovaj princip nam ograničava odgovornost klasa. Klase trebaju imati jedinstvenu odgovornost kako bi se 
smanjila zavisnost pri promjenama u klasi. Ovaj princip nije u potpunosti ispunjen jer postoje klase koje imaju 
više odgovornosti poput klase "Battle". Većina ima uglavnom gettere, settere, te odgovarajuće manipulatore. 
Nismo naginjali ka ispunjenju ovog principa jer će promjene većinskog broja klasa biti postignute inteface-om.

###2. Open Closed Principle - Otvoreno zatvoren princip

**Entiteti softvera trebali bi biti otvoreni za nadogradnju, ali zatvoreni za modifikacije.**

U slučaju promjene ili dodavanja metoda na višim klasama nećemo poremetiti klase ispod njih. Dok ako napravimo
promjenu na nižem nivou ona će utjecati na rad viših klasa, pa je time ispunjen i ovaj princip.

###3. Liskov Substitution Principle -Liskov princip zamjene

**Podtipovi moraju biti zamjenljivi osnovnim tipovima.**

Liskov princip je ispunjen za sve klase. Možemo vidjeti primjer kod podtipova klase "Item" koji sadrže metode 
i atribute svoje nadklase, te su zamjenjene klasom Item.

###4. Dependency Inversion Principle - Princip inverzije ovisnosti

**Moduli visokog nivoa ne bi trebali ovisiti od modula niskog nivoa, oba bi trebala da ovise od apstrakcija.
Moduli ne bi trebali ovisiti od detalja. Detalji bi trebali biti ovisni od apstrakcija.**

Ovaj princip je zadovoljen. Sve klase nižih nivoa zavise od onih viših. Njih opet upravljaju odgovarajući
interfejsi. A i oni imaju više i niže nivoe, gdje oni viši pozivaju niže. Uglavnom sve promjene kreću od
interfejsa idu preko neke veće klase pa do nekeih manjih detalja.

###5. Interface Segregation Principle - Princip izoliranja interfejsa

**Klijenti ne treba da ovise o metodama koje neće upotrebljavati.**

Sam korisnik aplikacije će striktno koristiti interfejse aplikacije, te promjene koje izvrši će mu biti vizuelno
prikazane. Njega neće mnogo zanimati neke interne metode niti šta se dešava unutar klasa.

Što se tiče korisnika biblioteke klasa njemu vidljive metode bi trebale biti korisne, a i razumljive. Uglavnom se
interfejsi klasa sastoje od get, set funkcija te nekih specifičnih metoda koje su samoobjašnjive. Čak se i za
komplikovanje metode može naslutiti šta rade (BeginTurn(), ChooseTarget() iz BattleMeni klase). Uglavnom ovaj
princip je zadovoljen.