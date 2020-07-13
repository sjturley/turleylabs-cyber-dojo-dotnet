using System;
class GildedRose 
{
    public Item[] items;

    public GildedRose(Item[] items) 
    {
        this.items = items;
    }

    public void UpdateItems() 
    {
        for (int i = 0; i < items.Length; i++) 
        {
            if (items[i].name != ("Aged Brie")
                    && items[i].name != ("Backstage passes to a TAFKAL80ETC concert")) 
            {
                if (items[i].quality > 0) 
                {
                    if (items[i].name != ("Sulfuras, Hand of Ragnaros")) 
                    {
                        items[i].quality = items[i].quality - 1;
                    }
                }
            }
            else 
            {
                if (items[i].quality < 50) 
                {
                    items[i].quality = items[i].quality + 1;

                    if (items[i].name != ("Backstage passes to a TAFKAL80ETC concert")) 
                    {
                        if (items[i].sellIn < 11) 
                        {
                            if (items[i].quality < 50) 
                            {
                                items[i].quality = items[i].quality + 1;
                            }
                        }

                        if (items[i].sellIn < 6) 
                        {
                            if (items[i].quality < 50) 
                            {
                                items[i].quality = items[i].quality + 1;
                            }
                        }
                    }
                }
            }

            if (items[i].name != ("Sulfuras, Hand of Ragnaros")) 
            {
                items[i].sellIn = items[i].sellIn - 1;
            }

            if (items[i].sellIn < 0) 
            {
                if (items[i].name != ("Aged Brie")) 
                {
                    if (items[i].name != ("Backstage passes to a TAFKAL80ETC concert")) 
                    {
                        if (items[i].quality > 0) 
                        {
                            if (items[i].name != ("Sulfuras, Hand of Ragnaros")) 
                            {
                                items[i].quality = items[i].quality - 1;
                            }
                        }
                    }
                    else 
                    {
                        items[i].quality = items[i].quality - items[i].quality;
                    }
                } 
                else 
                {
                    if (items[i].quality < 50) 
                    {
                        items[i].quality = items[i].quality + 1;
                    }
                }
            }
        }
    }
}
