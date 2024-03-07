string str = "Hello, world!";
Console.WriteLine("String original: " + str);

char[] chars = str.ToCharArray();
int i = 0;
int j = chars.Length - 1;

while (i < j)
{
    char temp = chars[i];
    chars[i] = chars[j];
    chars[j] = temp;
    i++;
    j--;
}

string reversedStr = new string(chars);
Console.WriteLine("String invertida: " + reversedStr);