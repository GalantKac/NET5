using NET5;
using System;
using System.Collections.Generic;


//Console top level calls
Console.WriteLine("Hello World!");


//Nowa inicjalizacja :) short version now
Person person1 = new();


List<Weather> list = new()
{ new() { Date = DateTime.Now, Desc = "NIC", TemperatureC = 30 } };

/// <summary>
/// Wszystjue foreach to przypadki Pattern Matching w switch
/// </summary>
foreach (var weatherItem in list)
{
    weatherItem.Desc = weatherItem.TemperatureC switch
    {
        <= 10 and > 1 => "Ok",
        > 10 or 30 => "More",
        _ => "Deafult" // znak _ znaczy że switch nie znalazł przypadku i wykoanj domyślny
    };

    Console.WriteLine(weatherItem.Desc);
}

var person = new Person(1, "test", 20);
var person2 = new Person(2, "test1", 22);

// wywołujemy deconstruktor klasy person który trzeba zaimplementować 
var (id, name, age) = person;

Console.WriteLine(string.Format("{0} {1} {2}", id, name, age));

// -- POSITIONAL PATTERN
//mozna deconstruktora użyć jako warunki w switchu
List<Person> personList = new() { person, person2 };
foreach (var item in personList)
{
    item.Name = item switch
    {
        (_, _, 22) => "stary ",
        (_, _, var mlodyAge) => $"mlody {mlodyAge}",
        _ => "NWM"
    };
}

Pizza pizza1 = new("pizza pl", true, true) { };
Pizza pizza2 = new("pizza eng", false, true) { };

List<Pizza> pizzaList = new()
{
    pizza1,
    pizza2
};

//TUPLE PATTERN
foreach(var item in pizzaList)
{
    item.Name = (item.HasAnanas, item.HasMeat) switch
    {
        (true,true) => "polisz",
        (false,true) => "brytolska",
        _ => "none"
    };
}

// Type Pattern
List<Test> testList = new() { };
GreenTest greenTest = new() { };
RedTest redTest = new() { };
testList.Add(greenTest);
testList.Add(redTest);

foreach(var item in testList)
{
    string outResult = item switch
    {
        GreenTest => "Green",
        RedTest => "Red",
        _ => "none"
    };

    Console.WriteLine(outResult);
}

//RELATIONAL PATTERN
foreach (var item in testList)
{
    string outResult = item switch
    {
        (<60 *24 * 2, false) => "Nie poprawny test < 2dni",
        GreenTest(> 60 *24, true) => "Pozytywny", // warunek typu i > i to wszystko w decostruct
        _ => "none"
    };

    Console.WriteLine(outResult);
}

/// RECORDY
//Record jest referecyjny jak klasa
// W recordzie wartosdci nie mog byc zmienne (tylko raz moga zostac przypisane)
// jest immutable 
// rekord to klasa inaczej napisana
// rekord z takimi samymi danymi jest sobie rowny equal == true ponieważ ma takie same wartości
// kalsa z takimi samymi danymi jest sobie rowny equal == false ponieważ ma inna referencje
// reference equals == false  dla rekordow poniewaz sa to dwie rozne referencje
// == dziala tak samo jak equals dla rekordów
// get hash code jest taki sam jeśli są te same wartości a recordach
// get hash code nie jest taki sam jeśli są te same wartości a klasach

// dictionary musi mieć record z innymi wartosciami poniewaz klucz jest brany po hashcode a key musi byc unikalny 
// dla klas spoko bo każda ma inny hashcode

// w recordach jest automatycznie destructor

Record1 record = new(1, 2);

// zaimplementowanie nowego rekordu kopiujac dane z innego ale przypisanie poszczegolnycch wlasciowsci mzoe byc po twojemu
Record1 newR = record with
{
    b = 200
};

//metoda zwaracajaca tupleta
var (a, b) = record.ReturnAB();
// recordy moga byc typem generycznym :)
// recordy moga implementowac interfejsy 
// recordy nie moga dziedziczyc po klasach
// dziedziczenie po recordzie spoko moze byc
// recordy moga byc partial
// recordy moga uzyc atrybutów
// recordy moga miec wlasciwosci i metody

//zalety recordów 
// 1 - Krótsza składnia
// 2 - thread-safe - why -> it is immutable
// 3 - łatwe w użyciu

// kiedy użyć rekordów
// 1 - Gdy masz dane które wiesz że mają się nie zmienić
// 2 - Do wywołania API
// 3 - Do przetwarzania danych
// 4 - Gdy masz dane tylko do odczytu

// kiedy nie używać
// 1 - kiedy zmienić dane przy użyciu EF

// _ nazywa się to discard (deafult dla switcha np)


