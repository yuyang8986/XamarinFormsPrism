using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Commands;
using Prism.Logging;

namespace ShellSamplePrism.ViewModels.Studies
{
    public class ShrineItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public string ItemType { get; set; }

    }

    public class ShrineItemGroup
    {
        public IList<ShrineItem> Items { get; set; }

        public ShrineItem First => Items?.FirstOrDefault();
        public ShrineItem Second => Items?.Skip(1).FirstOrDefault();
        public ShrineItem Third => Items?.Skip(2).FirstOrDefault();

        public int ShowSecond => Second!=null?1:0;

        public int ShowThird => Third != null?1:0;
    }

    public struct CartItemGroup
    {
        public double TotalGroupPrice { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public string Image { get; set; }
       
    }


}