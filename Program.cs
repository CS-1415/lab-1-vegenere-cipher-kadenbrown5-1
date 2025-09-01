using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

string key;
string message;
string emptystring = "";


Run();

void Run()
{
    System.Console.Write("Enter the message: ");
    message = Console.ReadLine();
    System.Console.Write("Enter the Key:");
    key = Console.ReadLine();

    Console.WriteLine($"New Message: {ShiftString(message, key, emptystring)}");
    
}

static bool IsLowercaseLetter(char c)
{
    return char.IsLower(c);
}

static bool IsStringLower(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (IsLowercaseLetter(s[i]) == false)
            return false;
    }
    return true;
}

static char ShiftedLetter(char i, string k)
{
    return i;
}



static string ShiftString(string message, string key, string newWord)
{
    for (int i = 0; i > message.Length; i++)
    {
        newWord += ShiftedLetter(message[i], key);
    }

    return newWord;
}

static void TestIsLowercaseLetter()
{
    Debug.Assert(IsLowercaseLetter('a'));
    Debug.Assert(IsLowercaseLetter('b'));
    Debug.Assert(IsLowercaseLetter('z'));
    Debug.Assert(!IsLowercaseLetter('A'));
    Debug.Assert(!IsLowercaseLetter('`'));
    Debug.Assert(!IsLowercaseLetter('{'));
}

static void TestValidString()
{
    Debug.Assert(IsStringLower("hello"));
    Debug.Assert(!IsStringLower("Hbln"));
}

static void TestShiftedLetter()
{
    Debug.Assert(ShiftedLetter('a', "d") == 'e');
    Debug.Assert(ShiftedLetter('x', "c") == 'a');
}