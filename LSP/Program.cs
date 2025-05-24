
using LSP.After;
using LSP.Before;

LSP.Before.Apple apple = new LSP.Before.Orange();

// this should gave red but because we violate the LSP we will get orange
Console.WriteLine(apple.GetColor());

//---------------------------------------

IFruit frute = new LSP.After.Orange();
Console.WriteLine(frute.GetColor()); // orange

frute = new LSP.After.Apple();
Console.WriteLine(frute.GetColor()); // red


