using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset assetOne, IAsset assetTwo)
        {
            return assetTwo.GetValue().CompareTo(assetOne.GetValue());
        }
    }
}