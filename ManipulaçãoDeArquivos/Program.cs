using ManipulaçãoDeArquivos;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        char gender;
        string file;

        Person person1 = CreatePerson();
        Person person2 = CreatePerson();
        WriteFile(person1);
        WriteFile(person2);

        Console.Clear();

        Console.Write("Informe o nome do arquivo a ser lido:");
        file = Console.ReadLine();

        var texto = ReadFile(file);

        Console.WriteLine(texto);

        ReadFile(texto);

        void WriteFile(Person person)
        {
            try
            {
                if (File.Exists("backup.txt"))
                {
                    var temp = ReadFile("backup.txt");

                    StreamWriter sw = new("backup.txt");
                    sw.WriteLine(temp + person.ToString());
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = new("backup.txt");
                    sw.WriteLine(person.ToString());
                    sw.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Registro Gravado com sucesso!");
                Thread.Sleep(1000);
            }
        }

        string ReadFile(string f)
        {
            StreamReader sr = new StreamReader(f);
            string text = "";

            try
            {
                text = sr.ReadToEnd();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sr.Close();
            }
            return text;
        }

        Person CreatePerson()
        {
            Console.Write("Informe o nome da pessoa: ");
            name = Console.ReadLine();
            Console.Write("\nInforme o gênero da pessoa: ");
            gender = char.Parse(Console.ReadLine());

            return new(name, gender);
        }
    }


}