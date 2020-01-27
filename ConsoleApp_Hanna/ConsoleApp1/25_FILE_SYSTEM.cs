using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace FILE_SYSTEM_NAM
{
    public class FILE_SYSTEM
    {
        public void FILE_SYSTEM_M()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Disk name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Disk volume: {drive.TotalSize}");
                    Console.WriteLine($"Free space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Label: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }

            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Sub-directories:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Files:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Program.CheckReturnToContent();
        }
    }
}
    

