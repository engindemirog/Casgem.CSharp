// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//camelCasing
string header = "Haberler";
int activeUserCount = 350;
//naming conventions

double unitPrice = 65.99;
bool isLoggedIn = true;//true

if (isLoggedIn)
{
    Console.WriteLine("Hoşgeldin Engin!");
    //<label>Hoş geldin engin</label>
}
else 
{
    Console.WriteLine("Giriş Yap");
    //<button>Giriş yap</button>
}

double dolarDun = 13.52;
double dolarBugun = 13.52;

if (dolarBugun > dolarDun)
{
    Console.WriteLine("Dolar artmış");
} 
else if (dolarBugun==dolarDun) 
{
    Console.WriteLine("Dolar eşit");
}
else
{
    Console.WriteLine("Dolar azalmış");
}

//Üç adet sayısal değişken oluşturunuz.
//bu sayılardan en büyük, en küçük ve ortanca sayıları ekrana yazdırınız.

int sayi1 = 10;
int sayi2 = 20;
int sayi3 = 5;

int enKucuk = 0;
int enBuyuk = 0;
int ortanca = 0;

if (sayi1>sayi2 && sayi1>sayi3)
{
    enBuyuk = sayi1;
}

if (sayi2 > sayi1 && sayi2 > sayi3)
{
    enBuyuk = sayi2;
}

if (sayi3 > sayi1 && sayi3 > sayi2)
{
    enBuyuk = sayi3;
}


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}




for (int i = 10; i > 0; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//int bir değişken tanımlayınız.
//bu sayı asal mıdır? buulan programı yazınız.




string[] cities2 = new string[] {"Ankara","İstanbul","İzmir"};

string firstName = "Engin";
char[] firstName1 = new char[] { 'E', 'n', 'g', 'i', 'n' };

Console.WriteLine(firstName[0]);


//Bugün hava çok güzel!
//bu metni tersten yazan programı yazınız.

string metin = "Bugün hava çok güzel!";

for (int i = metin.Length-1; i >= 0; i--)
{
    Console.Write(metin[i]);
}

string[] cities = new string[3];
cities[0] = "Ankara";
cities[1] = "İstanbul";
cities[2] = "İzmir";


cities = new string[4];
cities[3] = "Adana";

foreach (var item in cities)
{
    Console.WriteLine(item);
}

List<string> cities3 = new List<string>();
cities3.Add("Bursa");
cities3.Add("Manisa");
cities3.Add("Burdur");
cities3.Add("Van");
cities3.Add("Diyarbakır");
cities3.Remove("Van");
cities3.RemoveAt(0);
cities3[1] = "Tokat";
Console.WriteLine(cities3.Count);
foreach (var item in cities3)
{
    Console.WriteLine(item);
}

//sayısal loto oyunu için kolon üretici yazmak istiyoruz
//1-49



//Ekrana oyunu yazdırınız
//1.Kolon : 2,6,8,45,7,49
//2.Kolon : .....

//Kural: bir kolonda aynı sayı tekrar edemez.



//Kolonları koleksiyonda/dizide tutunuz.

int kolonAdedi = 8;

List<List<int>> columns = new List<List<int>>();

Random rand = new Random();

for (int i = 0; i < kolonAdedi; i++)
{
    var column = new List<int>();
    for (int j = 0; j < 6; j++)
    {
        var randomNumber = rand.Next(1, 49);
        if (column.Contains(randomNumber))
        {
            j--;
            continue;
        }
        else
        {
            column.Add(randomNumber);
        }
        
    }
    columns.Add(column);
}


foreach (var item in columns)
{
    string result = "Kolon : ";
    foreach (var number in item)
    {
        result = result + number + ",";
    }
    Console.WriteLine(result);
}