#WIP

##Role Playing Game

###Članovi tima:

1. Subašić Adi
2. Murselović Lejla
3. Solak Naida
4. Muratagić Amer

###Opis Teme

Cilj projekta je napraviti video igru koja pripada RPG žanru(tačnije JRPG).
Ona se sastoji od niza sistema sa kojima korisnik može istraživati svijet, 
boriti se protiv određenih protivnika, nadograđivati lika nad kojim upravlja,
sve u kontekstu narativa same igra. Privlačnost ovog žanra i leži u priči, na
koju korisnik može u određenoj mjeri uticati, bilo interakcijom ili komunikacijom
sa ostalim likovima. Ovaj projekat nema neku praktičnu aplikaciju, više je "zabavnog" 
karaktera.

Igra bi se sastojala od mape koju korisnik može istraživati koristeći tastaturu
za upravljanje karaktera na ekranu po navedenoj mapi. Prilikom ovog kretanja može
doći do susreta sa određenim neprijateljima prilikom čega igra prelazi na borbeni
ekran. Ovjde korisnik bira napade ili sposobnosti koji će njegov karakter izvršiti
s ciljem da porazi protivnika, nakon čega će on uraditi isto. Borba se završava
ili kada svi suparnici, ili korisnikom upravljani karakter izgube sav *Health.
Nakon toga ako je korisnik pobijedio njegov karakter će dobiti iskustvo( *EXP) i
možda neke resurse, u suprotnom on biva vraćen na prethodno spašenu lokaciju.
Nakon određenog broja borbi on dobiva *LVL, te može birati neki novi napad ili
sposobnost za korištenje u narednim susretima. Također korisnik može na tačno
određenim mjestima ili u razgovoru sa nekim *NPC-jevima kupovati određenu opremu
pomoću resursa koje je našao prilikom istraživanja, te time dalje nadograditi lika.
Iskustvo će biti usmjereno dizajnom mape, za razliku od postojanja *Questline-a.
Narativ će biti prezentiran kroz komunikaciju sa ostalim karakterima.

*Health - arbitrarna mjera koja govori koliko je karakter "živ" ili zdrav  
*EXP - Expirience - arbitrarna mjera progresije karaktera služi kao uslov za *levelovanje  
*Levelovanje - proces "jačanja" karaktera  
*Spašena lokacija - Checkpoint - stanje igre sačuvano u memoriji  
*LVL - Level - arbitrarna mjera "snage" karaktera, utiče na druge atribute  
*NPC - Non Playable Character - u suštini svi likovi osim korisničkog  
*Questline - niz *Quest-ova koji vode ka razvoju narativa  
*Quest - specifičan zadatak koji korisnik treba izvršiti (npr. idi od A do B, nađi x, 
eliminiši t, ...)


###Procesi

######Proces započinjanja igre

Korisniku se pojavi interfejs na kojem može izabrati da li će započeti novu igru ili nastaviti
sačuvanu igru. Ukoliko započinje novu igru pokrenut će se proces kreiranja novog karaktera u 
kojem unosi željeno ime. Nakon toga na ekranu se prikaže mapa i kreirani lik.

######Proces kretanja po mapi

Korisnik korištenjem tastature može da mijenja poziciju svog karaktera na mapi. To radi pomoću
strelica koje označavaju smijer kretanja. Tokom tog kretanja postoji mogućnost da lik naiđe na 
neprijatelja nakon čega se pokreće proces borbe. 

######Proces borbe

Korisniku se prikazuje intefejs na kojem vidi sliku svog lika i neprijatelja, zajedno sa 
njihovim borbenim statistikama. Korisniku će biti ponuđene mogućnosti odabira napada, 
otvaranja inventara i opciju napuštanja borbe. Ukoliko odabere napad mijenjaju se statistike 
neprijatelja za vrijednost određenu napadom. U slučaju da odabere otvaranje inventara 
otvorit će se odgovarajući interfejs za izbor predmeta, koji uvećava odgovarajuće borbene 
statistike. Pri izboru napuštanja borbe postoji šansa da igrač pobjegne od neprijatelja.
Nakon završenog poteza, neprijatelj bira svoj napad. Proces se odvija ciklično sve dok ili 
igrač ili neprijatelj ne izgube život, osim u slučaju da igrač pobjegne. Ako korisnik 
pobijedi dobiva odredjeni broj iskustva i/ili zlata. U suprotnom pokrenut će se proces 
učitavanja igre sa predhodnog spašenog stanja.

######Proces korištenja menija

Otvaranjem menija pojavljuje se korisnički interfejs koji nudi izbor pregleda osobina karaktera, 
otvaranja inventara gdje možemo vršiti procese odabira opreme i korištenja predmeta, pregleda 
sposobnosti igrača i napuštanja igre. 

######Proces levelovanja

Ukoliko korisnik stekne dovoljno iskustva povećava mu se level, što donosi statističke prednosti.
On također dobiva i određeni broj "skill" poena sa kojima može otključati nove sposobnosti za
korištenje unutar borbi.
 
######Proces kupovine predmeta i opreme

Ako se korisnik nađe u blizini prodavača na mapi, ima mogućnost kupovine novih predmeta i opreme
koji su mu ponuđeni. Predmeti su prikazani u novom korisničkom interfejsu. Za kupovinu se koristi 
zlato stečeno u borbi. Kada kupi predmet, on se prohranjuje u inventar.

######Proces odabira opreme

Unutar inventarskog menija biramo opremu koju karakter može koristiti. 

######Proces korištenja predmeta

Ako korisnik želi iskoristiti predmet iz inventara kojim bi promijenio trenutno stanje igrača, 
odabire odgovarajuću opciju unutar menija.

######Proces bacanja predmeta i opreme

U istom meniju kao i u prethodnom slučaju korisnik može odbaciti neželjene predmete i opremu.

######Proces razgovora sa NPC karakterom

U blizini NPC-a korisnik može započeti razgovor, prilikom čega dobiva uputstva ili informacije o 
svijetu u kojem se odvija igra. Također on može dobiti i neke nagrade od samog NPC-a.

######Proces spašavanja igre

Kada se karakter nađe u blizini objekta za spašavanje igre, nazovimo ga "Checkpoint" on ima mogućnost da
spasi trenutno stanje igre.

######Proces učitavanja igre

Korisnik se može vratiti na početni meni ("Main Meni") odakle može učitati neko od prethodno spašenih stanja
igre. Prilikom povratka na taj meni trenutno stanje igre se briše.

###Funkcionalnosti

- Mogućnost kretanja po mapi
	- Mogućnost ulaska u borbu
- Mogućnost kupovine opreme
- Mogućnost komunikacije sa NPC karakterima
- Mogućnost odabira određene opreme ("Equiping Items")
- Mogućnost korištenja *Consumable Items
- Mogućnost bacanja predmeta iz inventara
- Mogućnost provjere *inventara
- Mogućnost provjere osobina karaktera
- Mogućnost provjere sposobnosti
	- Mogućnost otključavanja novih sposobnosti
- Mogućnost napuštanja igre

*Consumable Items - pružaju trenutno povećanje određenih atributa, nestanu nakon toga  
*Inventory - skladište svih stvari koji karakter može skupiti  

###Akteri

- Korisnik - on je jedini akter u ovom projektu, ima apsolutnu kontrolu nad svim funkcionalnostima

###Dijagrami i scenariji

#####Use Case dijagram

- [Use Case dijagram](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/UseCaseIScenarij/RolePlayingGame.jpg)
	- [Započinjanje igre](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/UseCaseIScenarij/Zapo%C4%8Dinjanje%20igre.jpg)

#####Scenariji
 
* [Započinjanje igre](https://github.com/ooad-2015-2016/WIP/blob/master/UseCaseIScenarij/Zapo%C4%8DinjanjeIgre.pdf)
* [Korištenje mape](https://github.com/ooad-2015-2016/WIP/blob/master/UseCaseIScenarij/Kori%C5%A1tenjeMape.pdf)
	* [Odvijanje borbe](https://github.com/ooad-2015-2016/WIP/blob/master/UseCaseIScenarij/Borba.pdf)
	* [Kupovina Item-a](https://github.com/ooad-2015-2016/WIP/blob/master/UseCaseIScenarij/Kupovina.pdf)
	* [Razgovor sa NPC karakterom](https://github.com/ooad-2015-2016/WIP/blob/master/UseCaseIScenarij/RazgovorSaNPC.pdf)
	* [Spašavanje igre](https://github.com/ooad-2015-2016/WIP/blob/master/UseCaseIScenarij/SpašavanjeIgre.pdf)
* [Korištenje Menija](https://github.com/ooad-2015-2016/WIP/blob/master/UseCaseIScenarij/KoristenjeMenija.pdf)

#####Activity dijagrami

* [Dijagram ukupnog procesa](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/DijagramUkupnogProcesa.jpg)  
	* [Kretanje po mapi](https://github.com/ooad-2015-2016/WIP/blob/master/DijagramAktivnosti/KretanjePoMapi.jpg?raw=true)  
		* [Odvijanje borbe](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/OdvijanjeBorbe.jpg)  
		* [Kupovina opreme](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/KupovinaOpreme.jpg)  
		* [Razgovor sa NPC karakterom](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/RazgovorSaNpcKarakterom.jpg)  
		* [Spasavanje igre](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/SpasavanjeIgre.jpg)  
	* [Korištenje menija](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/KoristenjeMenija.jpg)  
		* [Provjera osobina](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/ProvjeraOsobina.jpg)  
		* [Provjera Inventara](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/ProvjeraInventara.jpg)  
			* [Biranje Opreme](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/BiranjeOpreme.jpg)  
			* [Korištenje Predmeta](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/Kori%C5%A1tenjePredmeta.jpg)  
			* [Bacanje Itema](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/BacanjeItema.jpg)  
		* [Provjera sposobnosti](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramAktivnosti/ProvjeraSposobnosti.jpg)

[]()

###Dijagram Klasa

* [Klase](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramKlasa/Character.jpg)
* [Klase kompresovane](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramKlasa/KlaseCompressed.jpg)

###Dijagram Sekvenci

* [Dijagram sekvenci](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/DijagramSekvenci.png)

###Design pattern-i

* [Strategy pattern](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/StrategyPattern.png)


###Skice Formi

#####Battle Meni

* [Forma 1](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/BattleMeni/1.png)
* [Forma 2](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/BattleMeni/2.png)
* [Forma 3](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/BattleMeni/3.png)
* [Forma 4](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/BattleMeni/4.png)

#####Alternate Battle Meni - vjerovatno bolji

* [Forma 1](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/AlternateBattleMeni/1.png)
* [Forma 2](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/AlternateBattleMeni/2.png)
* [Forma 3](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/AlternateBattleMeni/3.png)
* [Forma 4](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/AlternateBattleMeni/4.png)
* [Forma 5](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/AlternateBattleMeni/5.png)
* [Forma 6](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/AlternateBattleMeni/6.png)
* [Forma 7](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/AlternateBattleMeni/7.png)

#####Battle Meni - XAML

* [XAML implementacija](https://raw.githubusercontent.com/ooad-2015-2016/WIP/master/SkiceFormi/BattleMeniXAML.png)

###Implementacija projekta

Da bi pokrenuli ovaj projekat potrebno je extractovati .rar fajl koji se nalazi u  folderi WIP, te nakon toga u njega kopirati potrebne foldere iz WIP/Projekat.

Projekat u .rar-u nije Update-ovan jer projekat u .7z nije radio kad sam testirao na faks-u. Kada se uradi gore navedeno projekat bi se trebao moći pokrenuti.

Sa implementacijom postoji i mobilni port. Generalono je inferiorniji od izvornog. Borba se vrsi samo s jednim neprijateljem, inventory je ogranicen sa 9 item-a. 

Na nekim menijima ima viska stvari sa strane koji se ne bi trebali vidjeti na mobitelu. Takodjer igra nije testirana na mobitelu zbog nedostatka istog.

Ne bi trebao imati bug-ova ali nije previse testiran. Pokrece se na isti nacin kao i izvorni projekat.

* [Implementacija u video formi - Youtube](https://youtu.be/TnAXd54byJs)
