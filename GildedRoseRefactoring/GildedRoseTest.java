import org.approvaltests.combinations.CombinationApprovals;
import org.approvaltests.reporters.QuietReporter;
import org.approvaltests.reporters.UseReporter;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

@UseReporter(QuietReporter.class)
class GildedRoseTest {

    @Test
    void approveGildedRose() {
        String[] names = {"foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros"};
        Integer[] sellins = { -1, 0, 12, 6, 2 };
        Integer[] qualities = { 0, 1, 48, 49, 50 };
        CombinationApprovals.verifyAllCombinations(
                this::runGildedRose,
                names,
                sellins,
                qualities);
    }

    private Item runGildedRose(String name, int sellIn, int quality) {
        Item[] items = new Item[] { new Item(name, sellIn, quality) };
        GildedRose gildedRose = new GildedRose(items);
        gildedRose.updateItems();
        return gildedRose.items[0];
    }

}
