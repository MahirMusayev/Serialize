using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<string> names = new List<string> { "mahir", "fuat","samir" };
            Serialize(names);
            Add("inara");
            Add("kenan");
            Delete("samir");
            Search("mahir");
            

        }
        public static void Serialize(List<string> names)
        {
            string result = JsonConvert.SerializeObject(names);

            using (StreamWriter sw = new(@"C:\Users\Heydar\Desktop\ConsoleApp2\ConsoleApp2\files\names.json"))
            {
                sw.Write(result);
            }
        }
        public static List<string> Deserialize()
        {
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\Heydar\Desktop\ConsoleApp2\ConsoleApp2\files\names.json"))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine(result);
            return JsonConvert.DeserializeObject<List<string>>(result);
        }
        public static void Add(string name)
        {

            List<string> names = Deserialize();
            names.Add(name);
            Serialize(names);
            Console.WriteLine($"{name} lave edildi");
        }
        public static bool Search(string name)
        {
          
            List<string> names = Deserialize();
            bool exists = names.Any(x => x.Contains(name));
            if (exists)
            {
                Console.WriteLine($"{name} siyahida var");
            }
            else
            {
                Console.WriteLine($"{name} siyahida yoxdu");
            }
            return exists;

        }
        public static void Delete(string name)
        {
            List<string> names = Deserialize();

            if (names.Contains(name))
            {
                names.Remove(name);
                Serialize(names);
                Console.WriteLine($"{name} siyahidan silindi");
            }
            else
            {
                Console.WriteLine($"{name} siyahida tapilmadi");
            }
        }
      

    }

}

