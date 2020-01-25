using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace INIApplicationDemo.Classes
{
    public class IniFile
    {
        private readonly string _filePath;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);

        public IniFile()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _filePath = Path.Combine(executableLocation ?? throw new ArgumentNullException(nameof(executableLocation)), "app.ini");
        }

        public void Write(string section, string key, string value) => 
            WritePrivateProfileString(section, key, value, _filePath);

        public string Read(string section, string key)
        {
            StringBuilder stringBuilder = new StringBuilder(255);

            var asd = GetPrivateProfileString(section, key, "", stringBuilder, 255, _filePath);

            return stringBuilder.ToString();
        }
    }
}
