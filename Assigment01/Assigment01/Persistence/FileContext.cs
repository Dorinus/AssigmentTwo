using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace FileData
{
    public class FileContext
    {
        public static IList<Family> Families { get; private set; }
        public IList<Adult> Adults { get; private set; }

        private readonly string familiesFile = "families.json";
        private readonly string adultsFile = "adults.json";

        public FileContext()
        {
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }


        public void AddNewFamily(Family family)
        {
            int max = Families.Max(family => family.Id);
            family.Id = (++max);
            Families.Add(family);
            SaveChanges();
        }

        public void AddAdult(Adult adult, Family family)
        {
            int currentFamily = Families.IndexOf(family);


            int max = Adults.Max(adult => adult.Id);
            adult.Id = (++max);

            Families.ElementAt(currentFamily).Adults.Add(adult);
            Adults.Add(adult);
            SaveChanges();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }


        public void SaveChanges()
        {
            // storing families
            string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }

            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }


        public void RemoveAdult(int FamilyId, int AdultId)
        {
            Family familyFromToRemove = Families.First(f => f.Id == FamilyId);
            Adult adultToRemove = familyFromToRemove.Adults.First(a => a.Id == AdultId);

            int familyIndex = Families.IndexOf(familyFromToRemove);

            Families[familyIndex].Adults.Remove(adultToRemove);

            SaveChanges();
        }

        public async static Task<IList<Adult>> getAllAdultsFromFamilies()
        {
            
                
            


            IList<Adult> adults = new List<Adult>();
            
            foreach (var item in Families)
            {
                if (item.Adults != null)
                {
                    foreach (var adult in item.Adults)
                    {
                        adults.Add(adult);
                    }
                }
            }
            
            return adults;
        }
    }
}