using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ClassDemo2DLambdaLinq.model
{
    public class MockDataFactory
    {
        private static readonly IList<Bil> biler = new Collection<Bil>()
        {
            new Bil("rød", "AB12345", 345000),
            new Bil("Grå", "AB54321", 245000),
            new Bil("sort", "CD12345", 210000),
            new Bil("lysegrå", "CD54321", 625300),
            new Bil("sort", "KL12345", 280000),
            new Bil("lysegrå", "KL54321", 750300),
            new Bil("sort", "MN12345", 320000),
            new Bil("lysegrå", "MN54321", 370300),
            new Bil("rød", "EF12345", 217000),
            new Bil("Grå", "EF54321", 270000),
            new Bil("sort", "GH12345", 210000),
            new Bil("lysegrå", "GH54321", 625300),
            new Bil("rød", "IJ12345", 198000),
            new Bil("Grå", "IJ54321", 240000),
            new Bil("rød", "OP12345", 180000),
            new Bil("Grå", "OP54321", 260000),
            new Bil("sort", "QR12345", 285000)
        };

        public static ICollection<Bil> GetBiler { get { return new Collection<Bil>(biler); } }
    }
}
