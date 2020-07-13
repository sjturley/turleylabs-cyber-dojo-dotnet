using NUnit.Framework;
using System;

using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using ApprovalUtilities;

[TestFixture]
[UseReporter(typeof(QuietReporter))]
public class GildedRoseTest
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        Approvals.RegisterDefaultNamerCreation(() => new CyberDojoNamer());
    }
    
    [Test]
    public void ApproveGildedRose()
    {
    }
    
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
