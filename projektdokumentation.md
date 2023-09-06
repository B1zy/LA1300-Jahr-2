# Projekt-Dokumentation



Bielski

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|16.08.2023 | 0.0.0  | Punkten 1.1,1.4,1.2,2,1.3 bearbeitet. |
| 23.09.2023     | 0.0.1     |      Random Zahlen generieren, tiefer/höher, Anzahl versuche angezeigt   |        
|30.09.2023|0.0.2|    Konsole  farbig gemacht,  Neustart ohne die Konsole zu schliessen              |
| 06.09.2023| 0.0.3 | Rangliste ausprobiert, Portfolibeitrag erstellt |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Number guessing game

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ      | Beschreibung                       |
| ---- | --------------- | ----     | ---------------------------------- |
|  1  | muss  | Funktion | Als Benutzer will ich, dass der Computer zufällig eine Zahl zwischen 1 und 100 auswählt und sie speichert, damit es immer spannend bleibt
|  2  | muss  | Funktion | Als Benutzer will ich, dass der Computer erkennt, ob ich 'x' eingegeben habe, damit ich weiss, ob ich das Spiel gewonnen habe oder nicht
|  3  | kann  | Funktion | Als Benutzer will ich, dass der Computer erkennt, ob ich eine Zahl eingegeben habe, die grösser als 'x' ist, damit ich nächstes Mal genauer versuchen kann
|  4  | kann  | Funktion | Als Benutzer will ich, dass der Computer erkennt, ob ich eine Zahl eingegeben habe, die kleiner als 'x' ist, damit ich nächstes Mal genauer versuchen kann
|  5  | muss  | Funktion  | Als Benutzer will ich, dass der Computer die Anzahl Versuche anzeigt, nachdem die Zahl erraten wurde, damit ich meine Resultate mit anderen vergleichen könnte
|  6  | kann  | Funktion  | Als Benutzer will ich, dass der Computer erkennt, wenn ein Wort anstatt eine Zahl eingegeben wurde, damit es nicht abstürtzt|
|  7  | muss  | Funktion  | Als Benutzer will ich, dass das Spiel sich nochmal startet, wenn ich 'Ja' antworte, damit ich es nochmal spielen kann
|8|kann|Funktion|Als Benutzer will ich, dass das Spiel farbig ist, damit es nicht so monoton aussieht|
| 9 | kann | Funktion     | Als Benutzer möchte ich, dass eine Rangliste sich anzeigt, damit ich die Scores von anderen sehen kann |



### 1.3 Testfälle

| TC-№ | Ausgangslage                             | Eingabe | Erwartete Ausgabe |
| ---- | ------------                             |     ------    |   ---------                 |
|   2.1  | Programm gestartet, zufällige Zahl generiert | 'x'    |  '"Richtig, Sie haben die Zahl erraten"'      |
|   2.2  | Programm gestartet, zufällige Zahl generiert | nicht 'x'                       |       '"Falsch, probieren Sie nochmal"'       |
|   3.1  | Programm gestartet, zufällige zahl generiert | eine Zahl die grösser als 'x' ist| '"Zu hoch probieren Sie tiefer nächstes Mal"' |
|   4.1  | Programm gestartet, zufällige zahl generiert | eine Zahl, die kleiner als 'x' ist| '"Zu tief probieren Sie höher nächstes Mal"' |
|   5.1  | Programm gestartet, zufällige Zahl generiert, Zahl erraten|'x'                 |     '"Sie haben 'y' Versuchen gebraucht"'     |

|   6.1  | Programm gestartet, zufällige Zahl generiert | ein                             |'"Falsche eingabe"' |
|7.1| Programm gestartet, zufällige Zahl generiert und erraten, "Wollen sie noch einmal Spielen?"|'ja'|'"Eine zufällige Zahl zwischen 1-100 wurde generiert"'|
|8.1| Programm gestartet, zufällige Zahl generiert und erraten, "Wollen sie noch einmal Spielen?"|'nein'|'"Spiel wird abgefahren"'|
|   9.1  | Programm gestartet, zufällige Zahl generiert, Zahl erraten, versuche angezeigt|              |     Rangliste     |



### 1.4 Diagramme

![BIld1](https://i.imgur.com/TvR56mP.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   13.06.2023  |   Kamil   |                             Zahl zwischen 1 und 100 generieren                        |45min|
| 2.A  |   ''   |   Kamil   |                   erkennen, ob ich 'x' oder etwas anderes eingegeben habe          |45min|
| 3.A  |   ''|   Kamil   | Programm soll erkennen, ob zahl grösser als 'x' ist und dann es den Benutzer sagen |45min|
| 4.A  |   ''  |   Kamil   | Programm soll erkennen, ob zahl kleiner als 'x' ist und dann es den Benutzer sagen |45min|
| 5.A  |   ''  |   Kamil   |wenn 'x'erraten wurde, sollte das Programm sagen, wie viele versuche es gebraucht hat|45min|
| 6.A  |   ''  |   Kamil   |        Das Programm soll erkennen, ob ich ein Wort oder eine Zahl eingegeben habe   |45min|
| 7.A  |   ''  |   Kamil   |              Das Spiel sollte nochmals anfangen, wenn 'ja' geantwortet wurde           |45min|
|8.A|''|Kamil|Konsole sollte farbig sein|20|
Total: 335min

## 3 Entscheiden

Ich habe mich entschieden einen Jump statement für den Neuanfang zu benutzten, und leider die Rangliste nicht zu implementieren, da es mir zu kompliziert war.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  16.08.2023     |      ja     |    45min           |    20min               |
| 2.A  | ''      |    ''      |         ''     |       30min            |
| 3.A| ''|''|''|5min|
|4.A|23.08.2023|''|''|5min|
|5.A|"|''|''|20min|
|7.A|30.08.2023|"|45min|20min|
|8.A|''|''|''|10min|
Total:  110min


### 5 Kontrollieren
| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   06.09.2023    |   Funktioniert       |    Kamil Bielski    |
| 2.1  |    ''   |  Funktioniert        |  Kamil Bielski      |
|3.1|''|Funktioniert| Kamil Bielski|
|4.1|''|Funktioniert|Kamil Bielski|
|5.1|'' |Funktioniert|Kamil Bielski|
|6.1|''|Funktioniert |Kamil Bielski|
|7.1|''|Funktioniert|Kamil Bielski|
|8.1|''|Funktioniert|Kamil Bielski|
|9.1|''|Funktioniert nicht|Kamil Bielski|




