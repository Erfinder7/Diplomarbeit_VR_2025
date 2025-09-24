# Diplomarbeit_VR_2025
Unsere Diplomarbeit über die Multiuser-Nutzung von VR-Brillen

OK

Dont edit main!!!

Work with new branches (z.B.: Branch: Linus, Vali, Arthur) Danach sprechen wir uns ab und fügen alle 3 branchen gleichzeitig in den main branch

Die Excel bzw. Word-Dateien werden nicht (noch nicht) ins main hinzugefügt!
Gleichzeitiges bearbeiten vom Word geht nicht bitte absprechen
Ihr konnt nun die Stundenliste unter word-excel-Datein finden
Dort unter den selben Namen wieder hochladen ansonsten wird die alte Datei nicht überschrieben (über Web-Github)
Wenn ihr etwas ändern wollt über den PC geht das anders (unter bash):

1. Mit Git auf deinem Computer

Schritt-für-Schritt:

    Wechsle in deinen Repo-Ordner:
    bash

                    1.  cd Pfad/zum/Repo

Stelle sicher, dass du im richtigen Branch bist:
bash

                    2.  git status

(Falls du in einen anderen Branch musst: git checkout branchname)
Füge die geänderte Datei zum Commit hinzu:
bash

                    3.  git add dateiname.docx

(Ersetze dateiname.docx durch den tatsächlichen Dateinamen.)
Committe deine Änderung:
bash

                    4.  git commit -m "Aktualisierte Word/Excel-Datei hochgeladen"

Push die Änderung zu GitHub:
bash

                    5.  git push

Dann sollte es auch funktioniernen
