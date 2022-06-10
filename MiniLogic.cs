using System;
using System.IO;

namespace LegoDB
{

public delegate void miniFigDel(string arg1, string arg2);
public class MiniLogic
{   
        MiniFigure d = new MiniFigure();
        public void Logic(string Name, string Item)
    {   
        d.Name = Name;
        d.Item = Item;

        string path = Directory.GetCurrentDirectory();

//TODO: legge til rarity
//TODO: bedre brukeropplevelse
//TODO: mulighet for å printe tekstfilen i terminal
        if (!File.Exists(path + @"\Lego.txt"))
        {
            using (StreamWriter sw = File.CreateText(path + @"\Lego.txt"))
            {
                sw.WriteLine(Name);
                sw.WriteLine(Item);
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(path + @"\Lego.txt"))
            {
                sw.WriteLine(Name);
                sw.WriteLine(Item);
            }
        }
    }
}
}