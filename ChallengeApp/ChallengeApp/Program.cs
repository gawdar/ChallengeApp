int number = 4594; //deklaracja liczby
string numberAsString = number.ToString(); //Zmienia liczby na tekst
char[] digits = numberAsString.ToArray();   //Tworzy tabblicę znaków

int digit0 = 0;
int digit1 = 0;
int digit2 = 0;
int digit3 = 0;
int digit4 = 0;
int digit5 = 0;
int digit6 = 0;
int digit7 = 0;
int digit8 = 0;
int digit9 = 0;

foreach (char digit in digits)
{
    if (digit == '0')
    {
        digit0++;
    }
    else if(digit == '1')
    {
        digit1++;
    }
    else if(digit == '2')
    {
        digit2++;
    }
    else if (digit == '3')
    {
        digit3++;
    }
    else if(digit == '4')
    {
        digit4++;
    }
    else if(digit == '5')
    {
        digit5++;
    }
    else if(digit == '6')
    {  
        digit6++;
    }
    else if( digit == '7')
    {
        digit7++;
    }
    else if(digit == '8')
    {
        digit8++;
    }
    else if(digit == '9')
    {
        digit9++;
    }
}


Console.WriteLine("Number to count : " + number);
Console.WriteLine("Digits 0 is : " + digit0);
Console.WriteLine("Digits 1 is : " + digit1);
Console.WriteLine("Digits 2 is : " + digit2);
Console.WriteLine("Digits 3 is : " + digit3);
Console.WriteLine("Digits 4 is : " + digit4);
Console.WriteLine("Digits 5 is : " + digit5);
Console.WriteLine("Digits 6 is : " + digit6);
Console.WriteLine("Digits 7 is : " + digit7);
Console.WriteLine("Digits 8 is : " + digit8);
Console.WriteLine("Digits 9 is : " + digit9);
