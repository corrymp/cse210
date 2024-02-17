using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new() // I went with 5 videos with 4 comments each as that covers all the letters in the Alphabet (except X; there are sadly no biblical names that start with it)
        {
            new
            (
                "In the Beginning...",
                "Adam",
                6000,
                new List<Comment>
                {
                    new("Joshua","Good times, good times..."),
                    new("Keturah","So THAT'S how it happened!"),
                    new("Lehi","I feel like I've seen this before"),
                    new("Manasseh","Did you inherit anything?")
                }
            ),

            new
            (
                "Life as the Youngest Brother",
                "Benjamin",
                3518,
                new List<Comment>
                {
                    new("Nathanael","I get the feelings of being forgotten. What matters is that you keep being you!"),
                    new("Obadiah","Don't worry, there is a mountain waiting for you."),
                    new("Philip","@Nathanael Have we met?"),
                    new("Quartus","Hm... Interesting...")
                }
            ),

            new
            (
                "Truth Among Negativity",
                "Caleb",
                136,
                new List<Comment>
                {
                    new("Vajezatha","idk about that chief, lying has always worked for me"),
                    new("Wormwood","Well this is a hard one to swallow"),
                    new("Yoab","I personally would have gone with the other option, but you do you I guess."),
                    new("Zipporah","Oh, I remember this one!")
                }
            ),

            new
            (
                "I beat up a LION!",
                "David",
                1617,
                new List<Comment>
                {
                    new("Frankincense","Wow! What did it smell like?!"),
                    new("Gideon","I bet I could do that."),
                    new("Hannah","Mark my words: There will be songs about this one day."),
                    new("Isaac","You are going places, kid. Keep it up!")
                }
            ),
            
            new
            (
                "What Translation is Like: A True Story",
                "Enoch",
                1824,
                new List<Comment>
                {
                    new("Rebekah","That sounds AMAZING!"),
                    new("Simeon","I've heard of cities vanishing, but this is on a whole other level."),
                    new("Timothy","I wish I could have traveled there!"),
                    new("Uriel","This sounds familiar...")
                }
            )
        };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplay());
            video.ListComments();
        }
    }
}