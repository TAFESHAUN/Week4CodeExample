using CsvHelper;
using System.Globalization;
using System.Reflection;
using Week4CodeExample.Model;

namespace Week4CodeExample.Libs
{
    internal class ImportCSV
    {
        public static List<Product> ReadProductsFromCsv(string filePath)
        {
            //Lets make sure we get the filepath == our chosen application build
            string filePathGo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), filePath);

            //Treats it as TEXT and OPEN CLOSE
            using (var reader = new StreamReader(filePathGo))
            {
                //Treats it as CSV to OPEN AND CLOSE -> USES TEXT READER
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<Product>().ToList();
                }
            }
        }
    }
}
