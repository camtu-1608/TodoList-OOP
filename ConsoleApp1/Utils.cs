using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Utils
    {
        public static int startX = 90;
        public static int startY = 0;
        public static int offset = 3;
        public static List<String> optsHome = new List<string>();
        public static List<String> optsNote = new List<string>();

        public static void appInit()
        {
            optsHome.Add("[1] View notes");
            optsHome.Add("[2] Add notes");
            optsHome.Add("[3] Delete notes");
            optsHome.Add("[4] Select note");

            optsNote.Add("[1] ");
            optsNote.Add("[2] Add item");
            optsNote.Add("[3] Delete item");
            optsNote.Add("[4] Check item");
        }
        public static void printHomeOptionsPrompt()
        {
            for (int i = startY; i < optsHome.Count; i++)
            {
                Console.SetCursorPosition(startX, i + offset);
                println(optsHome[i]);
            }

        }
        public static void printNoteOptionsPrompt()
        {
            for (int i = startY; i < optsNote.Count; i++)
            {
                Console.SetCursorPosition(startX, i + offset);
                println(optsNote[i]);
            }
        }
        public static string input()
        {
            return System.Console.ReadLine();
        }
        public static string input(string prompt = "")
        {
            if (prompt == "")
            {
                System.Console.WriteLine(prompt);
                Console.SetCursorPosition(startX, startY + optsHome.Count + offset + 1);
                string res = System.Console.ReadLine();
                Console.Clear();
                return res;
            }
            else
            {
                print(prompt);
                Console.SetCursorPosition(prompt.Length + 1, 20);
                string res = System.Console.ReadLine();
                Console.Clear();
                return res;
            }

        }

        public static void print(string input)
        {
            System.Console.Write(input);
        }
        public static void println(string input)
        {
            System.Console.WriteLine(input);
        }
        public static void setCursorAtPromptPosition()
        {
            Console.SetCursorPosition(startX, startY + optsHome.Count + 1);
        }
    }
}
