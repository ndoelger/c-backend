namespace Datetime;

class Program
{
    static void Main(string[] args)
    {
        //DateTime

        var dateTime = new DateTime(2015, 1, 1);
        // Gets Time
        var now = DateTime.Now;
        // Gets Date
        var today = DateTime.Today;

        Console.WriteLine(now.Hour);
        Console.WriteLine(now.Minute);

        // Immutable—how to modify
        var tomorrow = now.AddDays(1);
        var past = now.AddHours(1);

        //Formatting to string
        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString());
        Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));




        //TimeSpan
        var timeSpan = new TimeSpan(1, 2, 3);
        Console.WriteLine(timeSpan);
        var timeSpan2 = TimeSpan.FromHours(1);
        Console.WriteLine(timeSpan2);
        var duration2 = timeSpan - timeSpan2;
        Console.WriteLine(duration2);

        var start = DateTime.Now;
        Console.WriteLine(start);
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;
        Console.WriteLine(duration);

        // Properties
        Console.WriteLine(timeSpan.Minutes);
        // Converts entire TimeSpan to minutes
        Console.WriteLine(timeSpan.TotalMinutes);

        // Add amnd Subtract
        Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
        Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(8)));

        // String Conversion
        Console.WriteLine(timeSpan.ToString());

        // Parse
        Console.WriteLine(TimeSpan.Parse("01:02:03"));

        // Summarize text
        var sentence = "This is a really really really really really long sentence.";
        var summary = SummerizeText(sentence, 25);
        Console.WriteLine(summary);

    }

    // Summarize function
    static string SummerizeText(string text, int maxLength = 20)
    {

        if (text.Length < maxLength)
            return text;
        
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            var summary = String.Join(" ", summaryWords) + "...";

            return summary;
        
    }

}

