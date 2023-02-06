// See https://aka.ms/new-console-template for more information
using AggregateOperator;

Console.WriteLine("Hello, World!");
AggregateOperators aggregateOperators = new AggregateOperators();
//aggregateOperators.NestedCount();
/*
 * aggregateOperators.CountSyntax();
aggregateOperators.CountConditional();
aggregateOperators.GroupedCount();
aggregateOperators.SumSyntax();
aggregateOperators.SumProjection();
aggregateOperators.SumGrouped();
aggregateOperators.MinEachGroup();
aggregateOperators.MaxSyntax();
aggregateOperators.MaxProjection();
aggregateOperators.MaxGrouped();
aggregateOperators.MaxEachGroup();
aggregateOperators.SeededAggregate();*/



Generators generators= new Generators();
generators.RangeOfIntegers();
generators.RepeatNumber();