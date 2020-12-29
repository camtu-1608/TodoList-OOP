using System;
using System.Collections.Generic;
using System.Linq;
using static ConsoleApp1.Utils;
using static ConsoleApp1.Note;

namespace ConsoleApp1
{
    class Program
    {
        static List<Note> session = new List<Note>();
        static string response;
        static string view = "main";

        static void Main(string[] args)
        {
            appInit();

            System.Console.WriteLine("Welcome to TODO. " +
                "What do you want to do?");

            do
            {
                printHomeOptionsPrompt();
                response = input();
                Console.Clear();
                switch (response)
                {
                    case "1":
                        viewNotes();
                        break;
                    case "2":
                        createNote();
                        break;
                    case "3":
                        deleteNote();
                        break;
                    case "4":
                        selectNote();
                        break;
                    default:
                        break;
                }
                
            }
            while (response != "quit");
        }

        private static void selectNote()
        {
            viewNotes();
            Console.SetCursorPosition(startX, startY);
            int index = Int32.Parse(input("Which one, enter number: "));
            Console.Clear();
            view = "note";

            goToNoteView(session[index]);
            

            viewNotes();

        }

        private static Note goToNoteView(Note note)
        {
            do
            {
                note.displayNote();
                
                printNoteOptionsPrompt();
                response = input();
                Console.Clear();
                switch (response)
                {
                    case "1":
                        viewNotes();
                        break;
                    case "2":
                        note.addItem();
                        break;
                    case "3":
                        note.deleteItem();
                        break;
                    case "4":
                        selectNote();
                        break;
                    default:
                        break;
                }
            }
            while (response != "quit");
            return note;
        }

        private static void viewNotes()
        {
            if (session.Count == 0)
            {
                println("No notes yet!");
                return;
            }
            println("___My Notes___");
            foreach (var rowObject in session.Cast<object>().Select((r, i) => new { Row = r, Index = i }))
            {
                //var row = rowObject.Row;
                var i = rowObject.Index;
                
                println("Note #" + i.ToString() + ": " + session[i].Title);
            }

        }

        private static void createNote()
        {
            Note note = new Note();
            
            note.Title = input("Enter title: ");
            Console.Clear();

            session.Add(note);

            viewNotes();
        }

        private static void deleteNote()
        {
            //setCursorAtPromptPosition();

            viewNotes();
            Console.SetCursorPosition(startX, startY);
            int index = Int32.Parse(input("Which one, enter number: "));
            Console.Clear();
            session.RemoveAt(index);

            viewNotes();

        }

        
    }
}
