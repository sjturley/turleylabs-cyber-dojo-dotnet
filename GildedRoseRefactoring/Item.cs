using System;

public class Item 
{

    public string name;

    public int sellIn;

    public int quality;

    public Item(string name, int sellIn, int quality) 
    {
        this.name = name;
        this.sellIn = sellIn;
        this.quality = quality;
    }

    public string ToString() 
    {
        return "Item{" +
                "name='" + name + '\'' +
                ", sellIn=" + sellIn +
                ", quality=" + quality +
                '}';
    }
}
