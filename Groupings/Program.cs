// See https://aka.ms/new-console-template for more information
using Groupings;

Console.WriteLine("Hello, World!");
Grouping grouping = new Grouping();
grouping.GroupingSyntax();
grouping.GroupByProperty();
grouping.GroupByCategory();
grouping.NestedGrouBy();
grouping.GroupByCustomComparer();
grouping.NestedGroupByCustom();