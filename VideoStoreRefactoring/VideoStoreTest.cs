using System;

using NUnit.Framework;

using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using ApprovalUtilities;

[TestFixture]
[UseReporter(typeof(QuietReporter))]
public class VideoStoreTest
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        Approvals.RegisterDefaultNamerCreation(() => new CyberDojoNamer());
    }
    
    [Test]
    public void RENAME_ME()
    {
        CombinationApprovals.VerifyAllCombinations(CreateCustomerStatement
                , new int[] {Movie.NEW_RELEASE, Movie.REGULAR, Movie.CHILDRENS}
                , new int[] {1, 2, 3, 4});
    }
    
    private string CreateCustomerStatement(int priceCode, int daysRented) {
        Customer customer = new Customer("Steve");
        Movie movie = new Movie("Star Wars", Movie.REGULAR);
        customer.AddRental (new Rental(movie, daysRented));
        movie.SetPriceCode(priceCode);
        return customer.Statement();
    }
}
