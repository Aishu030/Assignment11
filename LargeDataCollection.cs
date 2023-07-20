using System;
using System.Collections.Generic;
//Assignment11
//IDISPOSABLE
namespace Assignment11
{
    class LargeDataCollection : IDisposable
    {
        private List<string> dataCollection;

        public LargeDataCollection(List<string> initialData)
        {
            dataCollection = new List<string>(initialData);
        }

        public void AddElement(string element)
        {
            dataCollection.Add(element);
        }

        public void RemoveElement(string element)
        {
            dataCollection.Remove(element);
        }

        public string GetElementByIndex(int index)
        {
            if (index >= 0 && index < dataCollection.Count)
            {
                return dataCollection[index];
            }
            return null;
        }

        public void DisplayData()
        {
            foreach (var item in dataCollection)
            {
                Console.WriteLine(item);
            }
        }

        public void Dispose()
        {
            dataCollection.Clear();
            dataCollection = null;
        }
    }
}






























