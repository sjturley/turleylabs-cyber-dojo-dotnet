using System;
using System.Collections.Generic;

class Customer 
{
    private string name;

    public Customer(string name) 
    {
        this.name = name;
    }

    public string GetName() 
    {
        return name;
    }

    public string Statement() 
    {
        double totalAmount = 0;
        int frequentRenterPoints = 0;
        string result = "Rental Record for " + GetName() + "\n";
        foreach (Rental each in RentalService.GetRentals()) 
        {
            double thisAmount = 0;

            //determine amounts for each line
            switch (each.GetMovie().GetPriceCode()) 
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (each.GetDaysRented() > 2)
                    {
                        thisAmount += (each.GetDaysRented() - 2) * 1.5;
                    }
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += each.GetDaysRented() * 3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    if (each.GetDaysRented() > 3)
                    {
                        thisAmount += (each.GetDaysRented() - 3) * 1.5;
                    }
                    break;
            }

            frequentRenterPoints++;
            if ((each.GetMovie().GetPriceCode() == Movie.NEW_RELEASE) &&
                each.GetDaysRented() > 1)
            {
                frequentRenterPoints++;
            }

            result += "\t" + each.GetMovie().GetTitle() + "\t" +
                    thisAmount + "\n";
            totalAmount += thisAmount;

        }
        result += "Amount owed is " + totalAmount + "\n";
        result += "You earned " + frequentRenterPoints +
                " frequent renter points";
        return result;
    }

}
