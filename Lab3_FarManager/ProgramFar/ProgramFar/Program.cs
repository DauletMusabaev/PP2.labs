﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramFar
{
    class Program
    {
        static void ShowDirectoryInfo(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            FileSystemInfo[] fileSystemInfos = directory.GetFileSystemInfos();

            for(int index = 0; index < fileSystemInfos.Length; index++)
            {
                FileSystemInfo fileSystemInfo = fileSystemInfos[index];
                if (index == cursor)
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                else
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fileSystemInfo.Name);
            }

        }
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\work\PP2");
            int cursor = 0, n = directoryInfo.GetFileSystemInfos().Length;
            ShowDirectoryInfo(directoryInfo, cursor);


            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.CursorVisible = false;

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                        cursor = n - 1;
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                        cursor = 0;
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (directoryInfo.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        directoryInfo = new DirectoryInfo(directoryInfo.GetFileSystemInfos()[cursor].FullName);
                        cursor = 0;
                        n = directoryInfo.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(directoryInfo.GetFileSystemInfos()[cursor].FullName);
                        string s = sr.ReadToEnd();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                }
                if (keyInfo.Key == ConsoleKey.Escape || keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (directoryInfo.Parent != null)
                    {
                        directoryInfo = directoryInfo.Parent;
                        n = directoryInfo.GetFileSystemInfos().Length;
                        cursor = 0;
                    }
                    else
                        break;
                }
                ShowDirectoryInfo(directoryInfo, cursor);
            }
        }
    }
}
