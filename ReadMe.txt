TipoviOperatori
===============


UgrađeniTipoviIL
-----------------
Primjer kojim se može pokazati da svi ugradjeni tipovi osim decimal imaju 
izravne ekvivalente u IL-u.

ZADATAK: Prevesti program te generirani kod pogledati ILDASM-om (IL disassemblerom).


UgrađeniTipoviInicijalizacija
-----------------------------
Primjer koji pokazuje kako se ugrađeni tipovi mogu inicijalizirati samo 
operatorom pridruživanja ili podrazumijevanim konstruktorom.

U Program.Main treba:

ZADATAK 1: Inicijalizirati varijablu tipa int pozivom podrazumijevanog 
           (praznog) konstruktora te ispisati vrijednost varijable.

ZADATAK 2: Inicijalizirati drugu varijablu tipa int pozivom 
           konstruktora koji kao argument prima broj 4. 
		   Provjeriti dozvoljava li to prevoditelj.

ZADATAK 3: Inicijalizirati varijablu tipa string pozivom podrazumijevanog
           konstruktora. Provjeriti dozvoljava li to prevoditelj. 

ZADATAK 4: Napisati kod koji inicijalizira novu varijablu tipa string 
           na vrijednost "string 1".


UgrađeniBrojčaniTipovi
----------------------
Primjer koji pokazuje neka svojstva ugrađenih brojčanih tipova.

U Program.Main treba:

ZADATAK 1: Ispisati najveći i najmanji broj koji se može pohraniti u tip int.

ZADATAK 2: Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue.
           Ispisati vrijednost varijable uvećane za 1.

ZADATAK 3: Ponoviti to isto za varijablu s vrijednošću int.MinValue umanjenom za 1.

ZADATAK 4: Ispišite granične vrijednosti za tip double.

ZADATAK 5: Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog
           decimalnog broja s 0 te negativnog decimalnog broja s 0.

ZADATAK 6: Provjeriti što će se ispisati kao rezultat kada se varijabla
           tipa double s vrijednošću 0 podijeli s 0.


NumeričkaPromocija
------------------
Primjer pokazuje kakvog je tipa rezultat binarne operacije nad dva broja različitih 
tipova.

ZADATAK 1: Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
           Dijeljitelj i dijeljenik odabrati tako da dijeljenje bude s ostatkom.

ZADATAK 2: Definirati jednu varijablu tipa int i jednu tipa double te ih zbrojiti
           te provjeriti kakvog tipa je taj zbroj.


Nulabilni
---------
Primjer korištenja i inicijalizacije nulabilnih tipova.

ZADATAK 1: Dodati u Program.Main naredbu kojom se vrijednost nulabilnog
           tipa double postavlja na null referencu te ispisati nakon toga
		   sadržaj varijable.

ZADATAK 2: Ponoviti to isto za (ne-nulabilnu) varijablu tipa double.

ZADATAK 3: Definirati nulabilnu varijablu korištenjem generičkog tipa
           Nullable<T> te ponoviti postupke iz ZADATKA 1.


Deklaracija var
---------------
Varijabli koja je deklarirana ključnom riječi var će prevoditelj automatski
odrediti tip.

U metodi Program.Main:

ZADATAK 1: Dodati varijablu "i0" tipa var i inicijalizirati ju nekim cijelim 
           brojem.
           Dodati varijablu "d0" tipa var i inicijalizirati ju nekim decimalnim 
		   brojem.
		   Dodati naredbu:
		   i0 = d0;
		   te provjeriti prihvaća li prevoditelj tu naredbu.

ZADATAK 2: Dodati varijablu "i1" tipa int i inicijalizirati ju istim cijelim 
           brojem kao varijablu i0.
		   Dodati varijablu "d1" tipa double i inicijalizirati ju istim cijelim 
           brojem kao varijablu d0.
		   Prevesti kod i usporediti kod naredbi za inicijalizacije varijabli
		   i0 i d0, odnosno i1 i d1.

ZADATAK 3: Deklarirati varijablu "s" tipa var i inicijalizirati ju pozivom
           konstruktora strukture S definirane u istoj datoteci.
		   Napisati naredbe za postavljanje vrijednosti polja a i b
		   u toj strukturi na proizvoljne vrijednosti i provjeriti
		   da li se kod može prevesti.
         

PridruživanjeBazniIzvedeni
--------------------------
Ilustracija dozvoljenih pridruživanja između baznog i izvedenog tipa.

ZADATAK 1: Dodajte u metodu Program.Main pozive svih mogućih metoda nad
           instancama objekata osoba i osobaStudent.

ZADATAK 2: Deklarirajte objekt tipa Student i pokušajte ga instancirati 
           pozivom konstruktora tipa Osoba. Provjerite što prevoditelj 
		   javlja. 
		  

Pretvorba
---------
Ilustracija kada se smije koristiti operator cast.

ZADATAK 1: Provjeriti za koja pridruživanja u metodi Program.Main se smije  
           staviti operator pretvorbe da prevoditelj ne bi prijavio pogrešku
		   a da pri izvođenju ne bude bačena iznimka.

ZADATAK 2: Za svaki objekt dodati pozive svih mogućih metoda.


OperatorIs
----------
Operator is provjerava je li objekt s lijeve strane kompatibilan s tipom na 
desnoj strani (je li instanca tog tipa ili nekog izvedenog tipa).

ZADATAK: U metodu Program.Main dodajte provjere za svaki objekt (janko i
         osoba) jesu li tipa Osoba i tipa Student.


OperatorAs
----------
Operator as omogućava sigurnu pretvorbu: ako se pretvorba ne može provesti
vrijednost objekta će biti null.

ZADATAK: Pokrenuti metodu Program.Main i provjeriti što će se ispisati te
         koja će iznimka biti bačena.


OperatorSizeof
--------------
Operator sizeof vraća veličinu memorijskog prostora kojeg tip zauzima. Moguće 
je tražiti samo za vrijednosne tipove!

ZADATAK 1: Napisati naredbe kojima će se ispisati duljina podatka tipa decimal 
           i podatka tipa double.

ZADATAK 2: Napisati naredbe kojima će se ispisati duljina podatka tipa 
           MojaStruktura (koja ima samo dva polja) i podatka tipa 
		   MojaSloženaStruktura (koja uz dva polja ima i metodu).
           Usporediti rezultate ispisa.

ZADATAK 3: Napisati naredbu kojom će se ispisati duljina podatka tipa 
           MojaKlasa.


OperatorTypeof
--------------
Operator typeof vraća kao rezultat objekt tipa Type koji sadrži sve informacije
o dotičnom tipu.

ZADATAK 1: Napisati petlju koja će za svaki član kojeg vrati metoda GetMembers
           ispisati ime tog člana.

ZADATAK 2: Proširiti tijelo petlje tako da ispis člana sadrži i informaciju
           u kakvom se članu radi

ZADATAK 3: Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods
           ispisati ime metode i povratni tip.

ZADATAK 4: Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni
           parametri (tip i ime parametra).

ZADATAK 5: Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li
           public, protected ili private pravo pristupa.


