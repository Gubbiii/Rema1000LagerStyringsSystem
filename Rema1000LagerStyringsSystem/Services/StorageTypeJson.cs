using System.Collections.Generic;
using System.Linq;

namespace Rema1000LagerStyringsSystem
{
    //public class StorageTypeJson : IStorageType
    //{
    //    string fileName = @"C:\Users\lucas\OneDrive\Datamatiker\Software konstruktion\1. Semester\Afsluttende projektopgave\Rema1000\Rema1000LagerStyringsSystem\Data\jsonStorageTypes.json";
    //    public void AddStorageType(StorageType StorageType)
    //    {
    //        List<StorageType> storageTypes = GetAllStorageTypes();
    //        if (!(storageTypes.Contains(StorageType)))
    //            storageTypes.Add(StorageType);
    //        jsonFileWriterStorageType.WriteToJson(storageTypes, fileName);
    //    }
    //    public List<StorageType> FilterStorageType(string filter)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //    public List<StorageType> GetAllStorageTypes()
    //    {
    //        return jsonFileReaderStorageType.ReadJson(fileName);
    //    }
    //    public StorageType GetStorageType(int id)
    //    {
    //        foreach (StorageType storageType in GetAllStorageTypes())
    //        {
    //            if (storageType.Id == id)
    //                return storageType;
    //        }
    //        return new StorageType();
    //    }
    //    public StorageType RemoveStorageType(int id)
    //    {
    //        List<StorageType> StorageTypes = GetAllStorageTypes();
    //        foreach (StorageType storageType in StorageTypes.ToList())
    //        {
    //            if (storageType.Id == id)
    //                StorageTypes.Remove(storageType);
    //            jsonFileWriterStorageType.WriteToJson(StorageTypes, fileName);
    //        }
    //        return new StorageType();
    //    }
    //    public void UpdateStorageType(StorageType StorageType)
    //    {
    //        List<StorageType> StorageTypes = GetAllStorageTypes();
    //        foreach (StorageType storageType in StorageTypes.ToList())
    //        {
    //            if (storageType.Id == StorageType.Id)
    //            {
    //                storageType.Id = StorageType.Id;
    //                storageType.Name = StorageType.Name;

    //                jsonFileWriterStorageType.WriteToJson(StorageTypes,fileName);
    //            }
    //        }
    //    }


    //}
}
