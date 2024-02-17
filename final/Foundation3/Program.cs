using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new()
        {
            new LectureEvent("Firm in the Faith: How to Thrive in a Shakey World", "Come learn how to stay strong and sure up your foundations.", "Sep 29, 2024", "3:45 PM", new Address("Hall 2, 408 Smore Street","Anywhere","Zion"), "Tim Timeson", 45),
            new ReceptionEvent("John & Rose", "Celebrating the union of John Dough and Rose Toast.", "February Twenty-Nineth, Two Thousand Twenty-Four", "at Six Thirty in the Evening", new Address("123 Baker Road", "Breadmonton", "North Carolina"), "johnandrose@eletter.mail"),
            new GatheringEvent("Jacobson Family Reunion", "It is time for the 197th Annual Jacobson Family Renunion! (Please show up this time)", "07/27/24", "at Noon", new Address("Western Park", "Baltimon", "East Arkanolina"), "Bright and warm")
        };

        foreach (Event whyCantIUseEventAsTheName in events)
        {
            Console.WriteLine($"\n{whyCantIUseEventAsTheName.GetSummary()}\n{whyCantIUseEventAsTheName.GetDetails()}\n{whyCantIUseEventAsTheName.GetFullDetails()}\n");
        }
    }
}