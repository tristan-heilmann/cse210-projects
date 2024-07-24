using System;

class Program
{
    // main
    static void Main(string[] args)
    {
        // calls for the first event
        Address address1 = new Address("901 1st Street", "Hurricane", "Utah", "46871");
        string lectureAddress = address1.DisplayAddressDetails();
        Lecture lecture = new Lecture
        (
            "Lemon Bombs", "I will be teaching you all how to turn the common lemon into an explosive", "1/19/2024", "11:19 PM", $"{lectureAddress}", "Lecture", "Doctor Ooblek",
            "900 seats"
        );
        Console.WriteLine();
        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullLectureDetails();
        Console.WriteLine();
        lecture.ShortDescription();
        Console.WriteLine();

        // calls for the first event
        Address address2 = new Address("3257 Circle Crossing", "Potatoland", "Idaho", "54635");
        string receptionAddress = address1.DisplayAddressDetails();
        Reception reception = new Reception
        (
            "gigachad@gmail.com", "How to Get Swole", "you'll be learning how to get as swole as possible in a 24 hour period", "7/23/2024", "1:00 AM", $"{receptionAddress}",
            "Reception"
        );
        Console.WriteLine();
        reception.StandardDetails();
        Console.WriteLine();
        reception.FullReceptionDetails();
        Console.WriteLine();
        reception.ShortDescription();
        Console.WriteLine();

        // calls for the first event
        Address address3 = new Address("324 C4 Court", "Orlando", "Florida", "37649");
        string gatheringAddress = address3.DisplayAddressDetails();
        OutdoorGathering outdoorGathering = new OutdoorGathering
        (
            "Sunny skies", "How to Fight a Florida Man", "You will be learning how to defend yourself from the legendary Florida Man", "9/23/3071", "3:00 AM",
            $"{gatheringAddress}", "OutdoorGathering"
        );

        Console.WriteLine();
        outdoorGathering.StandardDetails();
        Console.WriteLine();
        outdoorGathering.FullOutdoorGatheringDetails();
        Console.WriteLine();
        outdoorGathering.ShortDescription();
        Console.WriteLine();
    }
}