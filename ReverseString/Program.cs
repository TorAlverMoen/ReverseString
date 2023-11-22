class Program
{
    static void Main()
    {
        bool exitApp = false;
        string originalString = "";
        string changedString = "";

        while (originalString == "")
        {
            Console.Write("Type in something: ");
            originalString = Console.ReadLine()!;
        }

        do
        {
            Console.WriteLine("Choose action: 1. Reverse, 2. Change to upper case, 3. Change to lower case, 4. Exit");
            string choice = Console.ReadLine()!;

            if (originalString != "" && originalString != null)
            {
                switch (choice)
                {
                    case "1":
                        changedString = ReverseString(originalString);
                        Console.WriteLine("The text in reverse: " + changedString);
                        break;
                    case "2":
                        changedString = ChangeCase(originalString);
                        Console.WriteLine("The upper case text: " + changedString);
                        break;
                    case "3":
                        changedString = ChangeCase(originalString, false);
                        Console.WriteLine("The lower case text: " + changedString);
                        break;
                    case "4":
                        exitApp = true;
                        break;
                    default:
                        Console.WriteLine("Please select a valid choice (1 - 4)");
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

    static string ChangeCase(string str, bool toUpper = true)
    {
        char[] charArray = str.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            switch (toUpper)
            {
                case true:
                    if (char.IsLower(charArray[i]))
                    {
                        charArray[i] = (char)(charArray[i] - 32);
                    }
                    break;
                case false:
                    if (char.IsUpper(charArray[i]))
                    {
                        charArray[i] = (char)(charArray[i] + 32);
                    }
                    break;
            }
        }
        return new string(charArray);
    }
}
