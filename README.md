# OData Youtube Videosu Reposu

## Youtube Videsu
https://youtu.be/D5AblIqQ53Y

## OData query params
```bash
$count = true //toplam kayýt sayýsýný göster
$top = 10 //kaç kayýt alýnacaðý
$skip = 0 //kaç kayýt atlanacaðý
$select = Name //hangi alanlarýn alýnacaðý
$orderby = Name //neye göre sýralanacaðý 
$expand = Category // join yapýlacak tablo
```

## Filter ile sorgu örnekleri
```bash
$filter=Name eq 'Domates'
$filter=Price ne 50
$filter=Quantity gt 100
$filter=Quantity ge 100
$filter=Quantity lt 50
$filter=Quantity le 50
$filter=startswith(Name, 'Dom')
$filter=endswith(Name, 'tes')
$filter=contains(Name, 'oma')
$filter=Price add Quantity eq 150
$filter=Price sub 10 eq 40
$filter=Price mul 2 eq 100
$filter=Price div 2 eq 25
$filter=Price mod 3 eq 0
$filter=(Price gt 50) and (Quantity lt 200)
$filter=(Price lt 50) or (Quantity gt 300)
$filter=not (Price eq 50)
$filter=Name eq null
$filter=Name ne null
$filter=Name in ('Domates', 'Biber', 'Patlýcan')
$filter=OrderDate eq 2024-01-01T00:00:00Z
$filter=OrderDate ge 2024-01-01T00:00:00Z
$filter=OrderDate le 2024-12-31T23:59:59Z
$filter=year(OrderDate) eq 2024
$filter=month(OrderDate) eq 12
$filter=day(OrderDate) eq 29
$filter=hour(OrderDate) eq 14
$filter=minute(OrderDate) eq 30
$filter=second(OrderDate) eq 15
$filter=length(Name) eq 7
$filter=indexof(Name, 'oma') eq 1
$filter=substring(Name, 1, 3) eq 'oma'
$filter=tolower(Name) eq 'domates'
$filter=toupper(Name) eq 'DOMATES'
$filter=trim(Name) eq 'Domates'
$filter=concat(Name, ' Fresh') eq 'Domates Fresh'
$filter=contains(tolower(Name), 'dom')
```