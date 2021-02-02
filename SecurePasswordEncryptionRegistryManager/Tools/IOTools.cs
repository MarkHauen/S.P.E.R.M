using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePasswordEncryptionRegistryManager.Tools
{
    class IOTools
    {
        public static string dataPathRoot = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SPERM";
        public string dataPath = $@"{dataPathRoot}\data.txt";


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
    }
}
