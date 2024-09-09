using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Autohook
{
    internal static class OfficeLoader
    {
        internal struct Office
        {
            public Office(string year, string name, string key)
            {
                this.year = year;
                this.name = name;
                this.key = key;
            }
            public string year;
            public string name;
            public string key;
        }

        public static List<Office> data;

        public static void Load()
        {
            // Получаем поток ресурса
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "Autohook.Resources.OfficesData"; // Замените на ваш фактический namespace и имя файла

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                data = new List<Office>();

                // Чтение данных
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');

                    string year = values[0].Trim();
                    string name = values[1].Trim();
                    string key = values[2].Trim();

                    Office office = new Office(year, name, key);
                    data.Add(office);
                }
            }
        }

        public static List<Office> GetOfficesByYear(string year)
        {
            List<Office> offices = new List<Office>();
            foreach (Office office in data)
            {
                if (office.year == year)
                {
                    offices.Add(office);
                }
            }

            return offices;
        }
    }
}
