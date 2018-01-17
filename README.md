 Ping Lokalizacji - Program który łączy się z określonym adresem sieciowym 
 Przykladowo : 192.168.0.1 lub www.onet.pl i sprawdza czy dany serwer jest osiągalny.
 Dane wynikowe zapisują się w tabeli ze statusem: 
 Serwer: 192.168.0.1 odpowiada
 Serwer: 192.168.0.1 nie odpowiada.
 Po sprawdzeniu wszystkich interesujących połączeń wygenerowaną listę serwerów możemy wysłać na określony adres e-mail.
 Dane konfiguracyjne klienta pocztowego znajdują się w pliku : App.config i wyglądają następująco: 

 email - Adres email z którego wysyłamy powiadomienia
 smtp_server - serwer smtp usługodawcy pocztowego
 smtp_port - port z jakiego wysyłamy powiadomienia
 ssl - szyfrowanie true / false
 autoryzacja - czy serwer wymaga autoryzacji użytkownika true / false
 user - użytkownik serwera pocztowego
 password - hasło do serwera pocztowego
 subject - temat z jakim wiadomość ma być wysłana

 W zakładce SQL znjduje się moduł, który weryfikuje połączenie do bazy danych SQL 
 Jeżeli połączenie do bazy danych po skonfigurowaniu parametrów przez użytkownika powiedzie się : 
 Program pobierze strukture tabeli którą, którą zdefiniował użytkownik i zapisze ją do pliku baza.xml w katalogu programu.
 Przed rozpoczęciem eksportu warto spradzić poprawność połączenia za pomocą przyciska Połącz
 
 Przyklad połączenia
 IP : 192.168.0.20 - adres bazy danych
 Baza : WSB - nazwa bazy danych
 Tabela : K22 - Tabela bazy danych
 Login : Patryk
 Hasło : Borys

