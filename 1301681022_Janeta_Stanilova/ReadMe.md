Моля следвайте инструкциите:

1 - Стартирайте Microsoft Visual Studio

2 - Кликнете на File -> Open -> Project/Solution и намерете файла CRUDAccessConsole.sln, когато го намерите кликнете на него, и след това кликнете на Open

3 - Свържете конзолата с базата данни Users:
- Кликнете на Tools -> Connect to Database
- Ако се отвори прозорец Add Connection кликнете на Change където пише Data source
- Ще се отвори прозорец Change Data Source, там в списъка Data source кликнете на Microsoft Access Database File и след това кликнете OK
- Отново ще се отвори прозореца Add Connection, но този път кликнете на Browse, където пише Database file name и намерете файла Users.accdb, когато го намерите кликнете на него, и след това кликнете на Open
- След това отново в прозореца Add Connection кликнете на Test Connection и ако ви излезе нов прозорец с текст: Test 
connection succeeded. кликнете на OK
- После пак в прозореца Add Connection кликнете на OK
- Кликнете на View -> Server Explorer, за да ви отвори прозореца Server Explorer, ако не е вече отоворен
- Кликнете на View -> Properties Window, за да ви отвори прозореца Properties, ако не е вече отоворен
- От прозореца Server Explorer кликнете на Users.accdb и след това в прозореца Properties копирайте текста на Connection String-а:

примерен текст: Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\1301681022_Janeta_Stanilova\Users.accdb

- Копираният вече текст от Connection String-а поставете в следния код, намиращ се още в началото на програмния код:
aConnection =
    new OleDbConnection(@"ПОСТАВТЕ ТУК КОПИРАНОТО");

пример: aConnection =
            new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\1301681022_Janeta_Stanilova\Users.accdb");

Вече конзолата е свързана към базата данни Users!

4 - Стартирайте конзолата като кликнете на Debug -> Start Without Debugging

5- Във вече стартираната конзола ще видите:
- Меню, което ще ви пита дали сте регистрирани или не
- Ако не сте регистриран, ще ви регистрира
- Ако сте регистриран, ще ви накара да се логнете
- Ако сте регистриран като Member, ще ви покаже базата данни
- Ако сте регистриран като Admin, ще ви пита за паролата на админа, която е: adminpassword, след като я напишете ще ви покаже друго меню, от което ще можете да видите базата данни, да добавяте нови потребители, да ъпдейтнете името, паролата, имейла или ролята(Member/Admin) на даден потребител, да триете потребители, или да излезете от апликацията

6 - Когато приключите затворете Microsoft Visual Studio