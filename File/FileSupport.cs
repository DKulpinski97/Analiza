using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Analiza.File
{
    class FileSupport
    {
        public bool CheckPath(string Readpath)
        {
            if (Readpath != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nie wybrano ścieżki");
                return false;
            }
        }

        public bool CheckExtension(string Readpath)
        {

            string extension = null;
            for (int i = Readpath.Length - 1; i > 0; i--)
            {
                if (Readpath[i] == '.')
                {
                    break;
                }
                else
                {
                    extension += Readpath[i];
                }
            }
            //Odwracanie strniga
            extension = ReviersArryCharToString(extension);
            if (extension == "csv")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Odczytywany plik nie ma rozszerzenia csv");
                return false;
            }
        }


        string ReviersArryCharToString(string str)
        {


            char[] charExtension = str.ToCharArray();
            Array.Reverse(charExtension);
            return new string(charExtension);

        }

        public string[] Read(string path)
        {
            try
            {
                return System.IO.File.ReadAllLines(path);
            }
            catch
            {
                MessageBox.Show("Plik jest otwarty lub nie istnieje");
            }
            return null;
        }

        public void CreataFile(string path)
        {

            System.IO.File.AppendAllText(path, "Kod klawisza;Czy duza litera;Stan Num lock;" +
                "Stan P Alt;Czas miedzy poprzednim a aktulalnym kliknieciem;Fokus\n");

        }
        public void AddLineToFile(string path,List<List<Code>> AllWordSelekted)
        {
            string word = "";
            for(int i=0;i<AllWordSelekted.Count;i++)
            {
                for (int j = 0; j < AllWordSelekted[i].Count; j++)
                {
                    word = AllWordSelekted[i][j].code.ToString() + ";"  + AllWordSelekted[i][j].bigLiter + ";" + AllWordSelekted[i][j].numLock.ToString() + ";"
                         + AllWordSelekted[i][j].PAlt.ToString() +";"+AllWordSelekted[i][j].milisekend.ToString() + ";" + AllWordSelekted[i][j].focus+"\n";
                    System.IO.File.AppendAllText(path, word);
                    word = "";
                }
                System.IO.File.AppendAllText(path, "\n");
            }

        }

        public void DeliteAndCreateNewFile(string path)
        {
            
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
                StreamWriter sw;
            try
                {
                sw = System.IO.File.CreateText(path);
                sw.Close();
                }
            catch
                {
                MessageBox.Show("Nie udało się utworzyć pliku");
                }
        }


    }
}
