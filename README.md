# 📚 BibliotekaApp  
Desktop aplikacija za upravljanje bibliotekom (C#, .NET, WinForms, SQL Server)

BibliotekaApp je desktop rješenje razvijeno u C# i WinForms okruženju, povezano sa Microsoft SQL Server bazom podataka.  
Aplikacija omogućava bibliotekarima jednostavno upravljanje knjigama, korisnicima, autorima i izdavanjem knjiga.

---

## 🔧 Tehnologije

- **C#**
- **.NET Framework / WinForms**
- **Microsoft SQL Server (SSMS)**
- ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)
- CRUD operacije nad više povezanih tabela

---

## 🗄️ Struktura baze podataka

Aplikacija je povezana sa SQL Server bazom **Biblioteka**, koja sadrži sljedeće tabele:

- `AUTORI`
- `BIBLIOTEKAR`
- `IZDAVACI`
- `IZDAVANJE`
- `KNJIGE`
- `KORISNIK`
- `MJESTO`
- `ZANR`

Svaka tabela je međusobno logički povezana u 3NF radi omogućavanja dodavanja, izmjena i brisanja podataka.

---

## ✨ Funkcionalnosti aplikacije

### 🔐 1. Login i registracija
- Bibliotekar se može **ulogovati** sa korisničkim imenom i lozinkom.
- Novi bibliotekar se može **registrovati** preko posebne forme.
- Nakon logovanja otvara se **Početna forma**.

---

### 🏠 2. Početna forma
Sa početne forme dostupni su sledeći moduli:

- 📖 **Pregled knjiga**
- 👤 **Pregled korisnika**
- 👔 **Pregled zaposlenih**
- ✍️ **Pregled autora**
- 📕 **Izdavanje knjiga**
- 🏷️ **Pregled izdavača**

---

### 📘 3. Upravljanje knjigama
- Dodavanje nove knjige  
- Izmjena postojećih podataka o knjizi  
- Brisanje knjige  
- Povezivanje knjige sa autorom, žanrom i izdavačem  
- Prikaz broja dostupnih primjeraka  
- Brza pretraga knjiga po nazivu
- Dodavanje autora, žanra i izdavača kroz vezu sa tabelom `AUTORI`, `ZANR`, `IZDAVACI`
- Automatsko popunjavanje combobox-a u formama pomoću ADO.NET upita

---

### 🧑‍💼 4. Upravljanje korisnicima
- Dodavanje korisnika  
- Izmjena i brisanje korisnika  
- Pretraga korisnika  
- Dodavanje mjesta rođenja kroz vezu sa tabelom `MJESTO`
- Automatsko popunjavanje combobox-a u formama pomoću ADO.NET upita

---

### ✍️ 5. Upravljanje autorima
- Dodavanje autora  
- Izmjena autora  
- Brisanje autora  
- Pretraga autora
- Automatsko popunjavanje combobox-a u formama pomoću ADO.NET upita

---

### 🏷️ 6. Upravljanje žanrovima i izdavačima
- Dodavanje, izmjena i brisanje  
- Automatsko popunjavanje combobox-a u formama pomoću ADO.NET upita  

---

### 📚 7. Izdavanje knjiga
- Pregled dostupnih knjiga  
- Evidencija o tome ko je iznajmio koju knjigu  
- Automatsko smanjivanje broja dostupnih primjeraka putem SQL trigera 

---

## 🔍 Brza pretraga

U svim prikazima (knjige, korisnici, autori…) postoji polje za **real-time pretragu**.

---

## 📸 Screenshots
![image alt](https://github.com/coricmarko2001-ship-it/BibliotekaApp/blob/035bacffb66b9fecd46e7a43002bb39c02230129/Login.png)
![image alt](https://github.com/coricmarko2001-ship-it/BibliotekaApp/blob/372b7f1a2c1412c88101e55180be164d452ce26d/Pocetna.png)
![image alt](https://github.com/coricmarko2001-ship-it/BibliotekaApp/blob/9d703d63951a0bf8b285feea95e45eeedbf36ac4/Pregled%20knjiga.png)
![image alt](https://github.com/coricmarko2001-ship-it/BibliotekaApp/blob/1b5bca5f6049b9098d039817a3b03973b24fb295/Dodavanje%20knjige.png)
![image alt]()
![image alt]()
![image alt]()


