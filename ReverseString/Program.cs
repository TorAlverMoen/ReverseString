class Program
{
    static void Main()
    {
        bool exitApp = false;

        do
        {
            Console.Write("Type in something: ");
            string originalString = Console.ReadLine()!;
            string reversedString = "";
            string upperCaseString = "";
            string lowerCaseString = "";

            Console.WriteLine("Choose action: 1. Reverse, 2. Change to upper case, 3. Change to lower case, 4. Exit");
            string choice = Console.ReadLine()!;

            if (originalString != "" && originalString != null)
            {
                switch (choice)
                {
                    case "1":
                        reversedString = ReverseString(originalString);
                        Console.WriteLine("The text in reverse: " + reversedString);
                        break;
                    case "2":
                        upperCaseString = ToUpperCase(originalString);
                        Console.WriteLine("The upper case text: " + upperCaseString);
                        break;
                    case "3":
                        lowerCaseString = ToLowerCase(originalString);
                        Console.WriteLine("The lower case text: " + lowerCaseString);
                        break;
                    case "4":
                        exitApp = true;
                        break;
                    default:
                        Console.WriteLine("Something went wring!");
                        break;
                }
            }

        } while (!exitApp);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        int start = 0;
        int end = str.Length - 1;

        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            start++;
            end--;
        }

        return new string(charArray);
    }

    static string ToUpperCase(string str)
    {
        char[] charArray = str.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
            {
                charArray[i] = (char)(charArray[i] - 32);
            }
        }
        return new string(charArray);
    }

    static string ToLowerCase(string str)
    {
        char[] charArray = str.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = (char)(charArray[i] + 32);
            }
        }
        return new string(charArray);
    }

}
