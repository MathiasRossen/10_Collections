using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset assetOne, IAsset assetTwo)
        {
            return assetOne.GetName().CompareTo(assetTwo.GetName());
        }
    }
}