// See https://aka.ms/new-console-template for more information
using ElementOperations;

Console.WriteLine("Hello, World!");
ElementOperation elementOperations = new ElementOperation();
elementOperations.GetProductList();
elementOperations.FirstMatchingElement();
elementOperations.FirstElement();
elementOperations.MaybeFirstElement();
elementOperations.MaybeFirstMatchingElement();
elementOperations.ElementAtPosition();
