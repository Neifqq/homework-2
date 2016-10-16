using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Text = { DateTime.UtcNow.ToString(),
                   Directory.GetCurrentDirectory(),
                   Path.GetFileName(Application.ExecutablePath) };
            // Создаю массив строк с нужными выходными данными (Дата/время, путь, имя).
            string Dir = Directory.GetCurrentDirectory() + @"\Task.txt";
            // Создаю путь, по которому создастся файл.
            File.WriteAllLines(Dir, Text);
            // Создаю файл по заданному пути и записываю в него заданный массив.
        }
    }
}
