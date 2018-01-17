 Ping Lokalizacji - Program który łączy się z określonym adresem sieciowym <br />
 Przykladowo : 192.168.0.1 lub www.onet.pl i sprawdza czy dany serwer jest osiągalny.<br />
 Dane wynikowe zapisują się w tabeli ze statusem: <br />
 Serwer: 192.168.0.1 odpowiada<br />
 Serwer: 192.168.0.1 nie odpowiada.<br />
 Po sprawdzeniu wszystkich interesujących połączeń wygenerowaną listę serwerów możemy wysłać na określony adres e-mail.<br />
 Dane konfiguracyjne klienta pocztowego znajdują się w pliku : App.config i wyglądają następująco: <br />
<br />
 email - Adres email z którego wysyłamy powiadomienia<br />
 smtp_server - serwer smtp usługodawcy pocztowego<br />
 smtp_port - port z jakiego wysyłamy powiadomienia<br />
 ssl - szyfrowanie true / false<br />
 autoryzacja - czy serwer wymaga autoryzacji użytkownika true / false<br />
 user - użytkownik serwera pocztowego<br />
 password - hasło do serwera pocztowego<br />
 subject - temat z jakim wiadomość ma być wysłana<br /><br />

 W zakładce SQL znjduje się moduł, który weryfikuje połączenie do bazy danych SQL <br />
 Jeżeli połączenie do bazy danych po skonfigurowaniu parametrów przez użytkownika powiedzie się : <br />
 Program pobierze strukture tabeli którą, którą zdefiniował użytkownik i zapisze ją do pliku baza.xml w katalogu programu.<br />
 Przed rozpoczęciem eksportu warto spradzić poprawność połączenia za pomocą przyciska Połącz<br /><br />
 
 Przyklad połączenia<br />
 IP : 192.168.0.20 - adres bazy danych<br />
 Baza : WSB - nazwa bazy danych<br />
 Tabela : K22 - Tabela bazy danych<br />
 Login : Patryk<br />
 Hasło : Borys<br />

