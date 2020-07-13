using NUnit.Framework;
using System;

using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Combinations;
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
        string[] names = {"foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros"};
        int[] sellins = { -1, 0, 12, 6, 2 };
        int[] qualities = { 0, 1, 48, 49, 50 };
        CombinationApprovals.VerifyAllCombinations(
                UpdateItems,
                names,
                sellins,
                qualities);
    }

    private static Item UpdateItems(String name, int sellIn, int quality) {
        Item[] items = new Item[] { new Item(name, sellIn, quality) };
        GildedRose gildedRose = new GildedRose(items);
        gildedRose.UpdateItems();
        return gildedRose.items[0];
    }
}
