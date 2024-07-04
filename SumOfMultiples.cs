using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
            multiples.Select(multiple => Enumerable
                .Range(multiple, max > multiple && multiple > 0 ? max - multiple : 0)
                .Where(digit => digit % multiple == 0))
            .SelectMany(digits => digits)
            .Distinct()
            .Sum();
}