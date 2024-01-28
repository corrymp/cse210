/* In addition to the base requirments, the program randomly chooses from a list of 5 scriptures to display each time. */

using System;

class Program
{
    static void Main(string[] args)
    {
        bool allHidden;
        string quit;

        List<Reference> options = new()
        {
            new("Proverbs",3,5,6),
            new("Isaiah",41,10),
            new("Psalms",23,1,6),
            new("3 Nephi",11,10,11),
            new("Proverbs",3,5,6)
        };

        List<string> verses = new()
        {
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
            "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness.",
            "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters. He restoreth my soul: he leadeth me in the paths of righteousness for his name’s sake. Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me. Thou preparest a table before me in the presence of mine enemies: thou anointest my head with oil; my cup runneth over. Surely goodness and mercy shall follow me all the days of my life: and I will dwell in the house of the Lord for ever.",
            "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.",
            "For behold, this is my work and my glory — to bring to pass the immortality and eternal life of man."
        };
        
        Random random = new Random();
        int rand = random.Next(0,options.Count());  
        Scripture scripture = new(options[rand],verses[rand]);

        do
        {
            allHidden = scripture.IsCompletelyHidden();

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            scripture.HideRandomWord(random.Next(1,3));

            quit = Input("\nPress enter to continue or type 'quit' to finish:\n");

        } while (quit != "quit" && allHidden == false);
    }
    
    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}