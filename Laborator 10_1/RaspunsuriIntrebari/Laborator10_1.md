# Laborator 10_1

## Tonu Cristian grupa 3131a

Acest fișier Markdown răspunde la întrebările de la finalul laboratorului 10_1.

1.Rolul comenzilor GL.Push() și GL.Pop():
GL.Push() și GL.Pop() sunt comenzi în OpenGL utilizate pentru a gestiona stiva de matrice de transformare. GL.Push() salvează matricea de transformare curentă pe stivă, permițând modificarea acesteia fără a afecta starea matricei de transformare precedentă. GL.Pop() elimină matricea de transformare curentă de pe stivă, revenind la starea anterioară. Aceste comenzi sunt necesare în situații în care se efectuează transformări diferite pentru obiecte diferite sau pentru a păstra o matrice de transformare specifică pentru o anumită parte a scenei.

2.Efectul metodelor GL.Rotate(), GL.Translate() și GL.Scale():
GL.Rotate(angle, x, y, z): Rotirea unui obiect în jurul axei specificate.

GL.Rotate(45.0f, 0.0f, 1.0f, 0.0f); // Rotire de 45 de grade în jurul axei Y GL.Translate(x, y, z): Translatarea unui obiect pe axele specificate.

GL.Translate(2.0f, 0.0f, 0.0f); // Translatare de 2 unități pe axa X GL.Scale(x, y, z): Scalarea unui obiect pe axele specificate.

GL.Scale(2.0f, 1.0f, 1.0f); // Scalare dublă pe axa X Aceste transformări pot fi combinate pentru a obține o varietate de efecte asupra obiectelor în scenă. De exemplu, pentru a crea o cutie rotită și mărită, poți folosi:

GL.Push(); GL.Rotate(45.0f, 0.0f, 1.0f, 0.0f); // Rotire de 45 de grade în jurul axei Y GL.Scale(2.0f, 1.0f, 1.0f); // Scalare dublă pe axa X // Desenează cutia aici GL.Pop();

3.Nivele de manipulări ierarhice:
Numărul de nivele suportate depinde de implementarea specifică și de resursele hardware disponibile. În general, majoritatea implementărilor OpenGL suportă un număr semnificativ de nivele de manipulare ierarhică (Push/Pop). Cu toate acestea, nu există o limită strictă specificată în specificațiile OpenGL. Este important să gestionezi cu atenție Push/Pop pentru a evita depășirea stivei, iar o practică bună este să echilibrezi fiecare apel Push cu un apel corespunzător Pop.
