using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FileData;

namespace Models
{
    public class FamilyInfo
    {
        public string Address{get; set;}
        public int NumberOfPeople{get; set;}

        private FileContext fileContext;

        public FamilyInfo(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }


        public IList<FamilyInfo> GetInfo()
        {
            IList<FamilyInfo> familyInfos = new Collection<FamilyInfo>();
            IList<Family> families = fileContext.Families;
            FamilyInfo tempFamilyInfo = new FamilyInfo(fileContext);

            foreach (var item in families)
            {
                
                tempFamilyInfo.Address = item.StreetName + item.HouseNumber;
                if (item.Adults.Count != null)
                {
                    tempFamilyInfo.NumberOfPeople += item.Adults.Count;
                }
                // if (item.Children.Count != null)
                // {
                //     tempFamilyInfo.NumberOfPeople += item.Children.Count;
                // }
                
                
                familyInfos.Add(tempFamilyInfo);
            }

            return familyInfos;

        }
    }
    
    
}