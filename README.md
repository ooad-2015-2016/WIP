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

####Proces započinjanja igre

Korisniku se pojavi interfejs na kojem može izabrati da li će započeti novu igru ili nastaviti
sačuvanu igru. Ukoliko započinje novu igru pokrenut će se proces kreiranja novog karaktera u 
kojem unosi željeno ime. Nakon toga na ekranu se prikaže mapa i kreirani lik.

####Proces kretanja po mapi

Korisnik korištenjem tastature može da mijenja poziciju svog karaktera na mapi. To radi pomoću
strelica koje označavaju smijer kretanja. Tokom tog kretanja postoji mogućnost da lik naiđe na 
neprijatelja nakon čega se pokreće proces borbe. 

####Proces borbe

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

####Proces korištenja menija

Otvaranjem menija pojavljuje se korisnički interfejs koji nudi izbor pregleda osobina karaktera, 
otvaranja inventara gdje možemo vršiti procese odabira opreme i korištenja predmeta, pregleda 
sposobnosti igrača i napuštanja igre. 

####Proces levelovanja

Ukoliko korisnik stekne dovoljno iskustva povećava mu se level, što donosi statističke prednosti.
(Povećavanjem na određene levele otvara se mogućnost odabira novih tipova napada u toku borbi.)

####Proces kupovine predmeta i opreme 

Ako se korisnik nađe u blizini prodavača na mapi, ima mogućnost kupovine novih predmeta i opreme
koji su mu ponuđeni. Predmeti su prikazani u novom korisničkom interfejsu. Za kupovinu se koristi 
zlato stečeno u borbi. Kada kupi predmet, on se prohranjuje u inventar.

####Proces odabira opreme

Unutar inventarskog menija biramo opremu koju karakter može koristiti. 

####Proces korištenja predmeta

Ako korisnik želi iskoristiti predmet iz inventara kojim bi promijenio trenutno stanje igrača, 
odabire odgovarajuću opciju unutar menija.

####Proces razgovora sa NPC karakterom

U blizini NPC-a korisnik može započeti razgovor, prilikom čega dobiva uputstva ili informacije o 
svijetu u kojem se odvija igra.

####Proces spašavanja igre

####Proces učitavanja igre
 



###Funkcionalnosti

- Mogućnost kretanja po mapi
	- Mogućnost ulaska u borbu
- Mogućnost levelovanja
- Mogućnost kupovine opreme
- Mogućnost komunikacije sa NPC karakterima
- Mogućnost pregleda određenih statistika
- Mogućnost odabira određene opreme ("Equiping Items")
- Mogućnost korištenja *Consumable Items
- Mogućnost provjere *inventara

*Consumable Items - pružaju trenutno povećanje određenih atributa, nestanu nakon toga  
*Inventory - skladište svih stvari koji karakter može skupiti  

###Akteri

- Korisnik - on je jedini akter u ovom projektu, ima apsolutnu kontrolu nad svim funkcionalnostima