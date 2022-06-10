using System;
using System.IO;

namespace LegoDB
{

public class MiniFigure
 {
private string? name;
private string? item;

    public string? Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public string? Item
    {
        get { return item; }
        set { item = value; }
    }
}
}