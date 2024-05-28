using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersonModel
{
    public class DatasetAccess
    {
        public static List<Person> LoadData(string filePath) 
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Dataset not found");
            }

            try 
            { 
                var fileContent = File.ReadAllText(filePath);
                var people = JsonSerializer.Deserialize<List<Person>>(fileContent);

                return people;
            }
            catch (Exception ex)
            {
                // Logger.Log(ex.Message)
                Console.WriteLine("Error: " + ex.Message);
                throw ex;
            }
        }
    }
}
