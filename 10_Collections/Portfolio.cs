using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace _10_Collections
{
    internal class Portfolio
    {
        List<IAsset> assetList;
        public Portfolio()
        {
            assetList = new List<IAsset>();
        }

        public Portfolio(List<IAsset> assetList)
        {
            this.assetList = assetList;
        }

        public double GetTotalValue()
        {
            double value = 0;

            foreach(IAsset asset in assetList)
            {
                value += asset.GetValue();
            }

            return value;
        }

        public void AddAsset(IAsset asset)
        {
            assetList.Add(asset);
        }

        public IList<IAsset> GetAssets()
        {
            IReadOnlyList<IAsset> readOnly = new ReadOnlyCollection<IAsset>(assetList);
            return (IList<IAsset>)readOnly;
        }

        public IAsset GetAssetByName(string name)
        {
            for(int i = 0; i < assetList.Count; i++)
            {
                if(assetList[i].GetName() == name)
                    return assetList[i];
            }

            return null;
        }

        public List<IAsset> GetAssetsSortedByName()
        {
            IComparer<IAsset> comparer = new StockNameComparator();
            assetList.Sort(comparer);
            return assetList;
        }

        public List<IAsset> GetAssetsSortedByValue()
        {
            IComparer<IAsset> comparer = new StockValueComparator();
            assetList.Sort(comparer);
            return assetList;
        }
    }
}