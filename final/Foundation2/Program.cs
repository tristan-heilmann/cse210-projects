using System;

class Program

{
    static void Main(string[] args)

    {
        Address address1 = new Address("9033 Space Elevator", "Yeetland", "Missuri", "USA");
        Customer customer = new Customer();

        address1.DisplayAddressDetails();
        customer.CustomerLocation();
    }
}