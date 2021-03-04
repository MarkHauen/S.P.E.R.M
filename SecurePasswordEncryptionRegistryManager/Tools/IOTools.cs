using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace SecurePasswordEncryptionRegistryManager.Tools
{
    class IOTools
    {
        public static string 
            dataPathRoot = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SPERM",
            desktopRoot = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\SPERM";
        public string 
            dataPath = $@"{dataPathRoot}\data.txt",
            desktopDataPath = $@"{desktopRoot}\data.txt";


        public string[] getAvailablePasswords() 
        {
            string[] lines = File.ReadAllLines(dataPath);
            string[] enteries = new string[lines.Length];
            for(int i = 0; i < lines.Length; i++)
            {
                enteries[i] = lines[i].Split(':')[0];
            }
            Array.Sort(enteries);
            return enteries;
        }

        public string getEncryptedPassword(string key)
        {
            string[] lines = File.ReadAllLines(dataPath);
            string value = "";
            foreach (string entry in lines)
            {
                if (entry.Split(':')[0].Equals(key))
                {
                    value = entry.Remove(0, key.Length + 1);
                }
            }
            return value;
        }

        internal void safeCopy(string from, string to)
        {
            if (File.Exists(from) && File.Exists(to))
            {
                File.Delete(to);
                File.Copy(from, to);
            } 
            else if (File.Exists(from))
            {
                Directory.CreateDirectory(to);
                File.Copy(from, to);
            }
        }

        internal void DeleteEntry(string entryToDelete)
        {
            string[] lines = File.ReadAllLines(dataPath);
            int indexToRemove = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (entryToDelete.Equals(lines[i].Split(':')[0]))
                {
                    indexToRemove = i;
                    break;
                }
            }
            if (indexToRemove == 0)
            {
                throw new Exception("You shouldn't delete that");
            }
            List<string> linesList = lines.ToList();
            linesList.RemoveAt(indexToRemove);
            File.WriteAllLines(dataPath, linesList.ToArray());
        }
    }
}
