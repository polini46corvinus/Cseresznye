# Cherry Picking pontozólap🍒
Név: `Simon Patrik`  
Neptun: `I3GYZP`

## Projekt rövid leírása:
Ez egy autóalkatrész kereskedés adatbázisához kapcsolódó `WinForms` és `Web API` alkalmazás melyben lehetőség van a termékek, ügyfelek és rendelések kezelésére.

![image](https://github.com/user-attachments/assets/33a0cefc-f7fc-441c-8b00-dfd5a34f97d1)

## Hozott anyagok:
Készítettem egy SQL adatbázist melyet a [portal.azure.com](http://portal.azure.com/)-on hostoltam.  
> Elérési út: autoalkatresz.database.windows.net

![image](https://github.com/user-attachments/assets/4ee58dcd-7b90-4d77-8fe1-fdd105f0bbe8)

Az adatbázis táblái a következők:
- `CIM` > az ügyfelek rendelési címei
- `RENDELES` > a megrendelések, és azon kulcsinformáció
- `RENDELES_TETEL` > az egyes megrendelések tételei, a tételek árai stb.
- `TERMEK` > a termékekkel kapcsolatos információk
- `TERMEK_KATEGORIA` > a termékkategóriák
- `UGYFEL` > az ügyfelek adatai, kapcsolattartás

![image](https://github.com/user-attachments/assets/0123218e-0678-402f-aa5d-450912198741)

# Pontozás

## Windows Forms Application
## User Interface
-	`1x2p` Az alkalmazásból a kilépés csak megerősítő kérdés után lehetséges.

> ![image](https://github.com/user-attachments/assets/bdc200c8-77fe-48dd-ad5f-b24b569a7c32)

-	`3x2p` Olyan alkalmazás elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckuonlalitással rendelkező UserControl-t tölt be.

> ![image](https://github.com/user-attachments/assets/ac4e9a86-3970-4db2-a7ac-53200dcf92b6)
![image](https://github.com/user-attachments/assets/708a2861-4d7c-4ac0-850d-6dca98317d9d)
![image](https://github.com/user-attachments/assets/c7c34a10-ca22-4599-b200-605656e5f084)

-	`3x1p` Többablakos alkalmazás legalább két felugró ablakkal. Minden Form-nak saját osztályon kell alapulnia, és funcionalitással kell rendelkeznie. Az ablakok nyílhatnak gombokkal vagy felső menüből is.
> Ebből az elsőt két módon is felhasználom. Új termék létrehozására, illetve az osztály átadásával a termék szerkesztésére is, tehát két külön ablak van rá.

> ![image](https://github.com/user-attachments/assets/70d2c783-3b54-4a50-a7c0-e55e93765344) ![image](https://github.com/user-attachments/assets/76cd126c-3dd8-4d45-8c24-51a5267bd7ea)

-	`1x2p` Anchorok alkalmazása: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.
> Ezt sima liba :)

## Tábla adatainak megjelenítése ListBox-ban.
- `1x2p` Adatok megjelenítése
- `2x2p` Ha az adatok tetszőleges módszerrel, pl. TextBox-on keresztül szűrhetőek.

![image](https://github.com/user-attachments/assets/0413a2d6-7deb-4f1c-9754-6be2aef93314)
![image](https://github.com/user-attachments/assets/5bf8e5c4-981a-49c7-a4a6-f46185dfd482)

## Tábla adatainak megjelenítése DataGridView-ban
- `1x2p` Adatok megjelenítése
- `1x2p` Ha a tábla idegen kulcsot is tartalmaz, melynek megjelenítése DataGridViewComboBoxColumn-on keresztül történik.

![image](https://github.com/user-attachments/assets/9de7abf5-aa94-4c76-a9cb-3b186d7449a9)

- `1x2p` Ha a tábla adatforrása saját osztály.

![image](https://github.com/user-attachments/assets/197c2773-3454-4e5c-9f9c-e1743f3366d7)

## Adatkötés BindingSource-on keresztül
- `1x2p` Működő BindingSource
- `3x1p` Egy BindingSource-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint TextBox, DateTimePicker, ComboBox idegen kulcs értékének beállítására, stb. (itt csak 1p van (Termekek dgv utolsó combobox oszlopa))

![image](https://github.com/user-attachments/assets/2a6d3c31-33c8-4178-ac23-9be6a2315cec)

## Új rekord rögzítése
A pontok összeadódnak.
- `2x2p` master-detail reláció detail táblájába ÉS/VAGY több-a-több kapcsolatban álló táblák kapcsolótáblájába
- `1x1p` Ha legalább egy nem kulcs mező, pl. Mennyiség is fel van véve
- `1x2p` Felugró ablakon keresztül történik Ok és Mégse gombbal
- `1x2p` Ha az űrlap legördülő dobozon vagy listán keresztül beállítható idegen kulcsot is tartalmaz `naná hogy a termékkategória mezőt csináltam meg így 👀`

## Rekord törlése
- `1x2p` Sikeres törlés
- `1x2p` Megerősítéshez kötött törlés

![image](https://github.com/user-attachments/assets/c289a315-5ec1-435f-9774-e648714defd3)

# ASP.NET
	Minden müx, trust me

## ASP .NET alkalmazás, melyet lehet a Forms alapú projekttel közös solution-ben létrehozni.
- `1x2p` program.cs beállítása `wwwroot` mappában tárolt statikus tartalmak megosztására
> yes of course, bár semmit nem raktam bele csak egy Hello World-ös html-t, de ez ilyen low hanging fruit you know..👀

## API végpontok
- `1x3p` Teljes SQL tábla adatainak szolgáltatása API végponton keresztül
- `2x2p` SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül (ügyfél és termékek tábla külön!)
- `1x3p` SQL tábla egy választható rekordjának törlése
- `1x5p` Új rekord felvétele HttpPost metóduson keresztül SQL táblába

![image](https://github.com/user-attachments/assets/2fc35829-7a17-46f9-9508-173f2f55aedc)

# Saját Adatbázis

## SQL script formájában, de legjobb Azure SQL szerveren hosztolni
- `3x1p` Az alkalmazásban használt táblánként pont
- `1x2p` Az adatbázis saját Azure SQL szerveren van

> lásd fentebb

## Egyéb, extra
	Scaffold-DbContext "Data Source=autoalkatresz.database.windows.net;Initial Catalog=autoalkatresz;User ID=hallgato;Password=Password123;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Data -Context AlkatreszDbContext -DataAnnotations -Force -NoPluralize
- `2x1p` Scaffold-DbContext használata (ajándék)

# Ha mindent összeadunk:

![image](https://github.com/user-attachments/assets/264039e4-b367-479c-9e8e-a03fef21c9d2)
