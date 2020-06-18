import org.approvaltests.combinations.CombinationApprovals;
import org.approvaltests.reporters.QuietReporter;
import org.approvaltests.reporters.UseReporter;
import org.junit.Test;

@UseReporter(QuietReporter.class)
public class VideoStoreTest {
    @Test
    public void approveCustomerStatement() {
        CombinationApprovals.verifyAllCombinations(this::createCustomerStatement
                , new Integer[] {Movie.NEW_RELEASE, Movie.REGULAR, Movie.CHILDRENS}
                , new Integer[] {1, 2, 3, 4});
    }

    private String createCustomerStatement(int priceCode, int daysRented) {
        Customer customer = new Customer("Steve");
        Movie movie = new Movie("Star Wars", Movie.REGULAR);
        customer.addRental (new Rental(movie, daysRented));
        movie.setPriceCode(priceCode);
        return customer.statement();
    }
}
