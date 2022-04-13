// See https://aka.ms/new-console-template for more information


// 1.uzd.

// 1. Prasam lietotajam ievadit vina vardu 
Console.WriteLine("Kā tevi sauc?");

// 2. Sagaidam lietotaja ievadi
string lietotajaVards = Console.ReadLine();

// 3. Sasveicinamies ar lietotaju, izmantojot vina vardu, paterns : "Sveiks : {vards}" 
Console.WriteLine("Sveiks, " + lietotajaVards);


Console.WriteLine(" ======================================");


// 2.uzd 


Console.WriteLine("Kāds ir Tavs vecums?");

string lietotājaVecums = Console.ReadLine();
int userNumber = int.Parse(lietotājaVecums);

int nextYearAge = userNumber + 1;
Console.WriteLine("Nākamgad Tev paliks " + nextYearAge + ", Tu esi pilngadīgs");

Console.WriteLine(" =========================================");

// 3.uzd


int number1, number2, number3;
Console.WriteLine("Ievadi saitli");

string  ievadītaisSkaitlis = Console.ReadLine();
number1 = int.Parse(ievadītaisSkaitlis);

Console.WriteLine("Ievadi citu saitli");
string ievadītaiscitsSkaitlis = Console.ReadLine();
number2 = int.Parse(ievadītaiscitsSkaitlis);

Console.WriteLine("Ievadi vēl citu saitli");
string ievadītaisvēlcitsSkaitlis = Console.ReadLine();
number3 = int.Parse(ievadītaisvēlcitsSkaitlis);

int biggestnumber1 = Math.Max (number1, number2);
int biggestnumber2 = Math.Max (number2, number3);
int maxNumber = Math.Max(biggestnumber1, biggestnumber2);

Console.WriteLine("Lielakais skaitlis:");
Console.WriteLine(maxNumber);

Console.WriteLine(" ==========================================");


// 4.uzd

int number4, number5, number6;
Console.WriteLine("Ievadi jebkādu saitli");

string skaitlis = Console.ReadLine();
number4 = int.Parse(skaitlis);

Console.WriteLine("Ievadi citu saitli");
string citsSkaitlis = Console.ReadLine();
number5 = int.Parse(citsSkaitlis);

Console.WriteLine("Ievadi vēl citu saitli");
string vēlcitsSkaitlis = Console.ReadLine();
number6 = int.Parse(vēlcitsSkaitlis);

int smallestnumber4 = Math.Min(number4, number5);
int smallestnumber5 = Math.Min(number5, number6);
int minNumber = Math.Min(smallestnumber4, smallestnumber5);

Console.WriteLine("Mazākais skaitlis:");
Console.WriteLine(minNumber);


Console.WriteLine(" =========================================");


// 5.uzd

int x = 8;
int y = 3;

// check 8 / 3 =2.67    2 * 3 = 6     8 - 6 = 2 


int divisionLeft = x % y;

Console.WriteLine(divisionLeft);


Console.WriteLine(" =========================================");


// 6.uzd 

int num1;
Console.WriteLine("Ieraksti skaitli, lai pārbaudītu");

string ierakstītaisSkaitlis = Console.ReadLine();
num1 = int.Parse(ierakstītaisSkaitlis);

//bool isEven = num1 % 2 == 0;
//bool isOdd = num1 != 0;
if (num1 % 2 == 0)
Console.WriteLine("Skaitlis " + num1 + " ir pāra skaitlis" );
else
Console.WriteLine("Skaitlis " + num1 + " ir nepāra skaitlis");


//== salidzinašana , = pieškiršana


Console.WriteLine(" =========================================");


// 7.uzd

double platums;
Console.WriteLine("Taisnstūra platums");
string platumaSkaitlis = Console.ReadLine();
platums = double.Parse(platumaSkaitlis);

double garums;
Console.WriteLine("Taisnstūra garums");
string garumaSkaitlis = Console.ReadLine();
garums = double.Parse(garumaSkaitlis);

//double garums = 7.25;
//double platums = 4.20;

Console.WriteLine("Taisnstūra laukuma aprēķins");

garums *= platums; 
Console.WriteLine(garums);
double roundableNumber = (garums);
double rounded = Math.Round(roundableNumber, 2); //cik ciparu aiz komata atstat, šaja gadijuma 2

Console.WriteLine("Noapaļotais skaitlis: " + rounded);

Console.WriteLine(" =========================================");

// 8.uzd

Console.WriteLine("Taisnleņķa trijstūra laukuma aprēķināšana");

double malasGarums;
Console.WriteLine("Trijstūra sānu malas garums");
string sānuMalasGarums = Console.ReadLine();
malasGarums = double.Parse(sānuMalasGarums);

int dalāmais = 2;

//double garums = 7.25;
//double platums = 4.20;

Console.WriteLine("Trijstūra laukuma aprēķins");

double multiplication = malasGarums * malasGarums;
multiplication /= dalāmais;
Console.WriteLine(multiplication);

Console.WriteLine(" =========================================");


// 9.uzd

Console.WriteLine("Kāds ir Tavs vārds ?");
string tavsVards = Console.ReadLine();


Console.WriteLine("Kāds ir Tavs vecums ?");

string vecums = Console.ReadLine();

string formattedMessage = $"Sveiks {tavsVards}, tavs vecums ir {vecums} .";

Console.WriteLine(formattedMessage);


