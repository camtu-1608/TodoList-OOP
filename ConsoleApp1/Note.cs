using System;
using System.Collections.Generic;
using static ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class Note
    {
        DateTime _date;
        String _title;
        List<String> _tags;
        List<Item> _items ;

        public Note() 
        {
            Title = "Enter title here";
            Items = new List<Item>();
            Tags = new List<string>();
        }

        public Note(DateTime date, string title, List<string> tags, List<Item> items)
        {
            _date = date;
            _title = title;
            _tags = tags;
            _items = items;
        }

        public DateTime Date { get => _date; set => _date = value; }
        public string Title { get => _title; set => _title = value; }
        public List<string> Tags { get => _tags; set => _tags = value; }
        internal List<Item> Items { get => _items; set => _items = value; }

        
        public void displayNote()
        {
            println(Title);
            println("_____________________");
            Items.ForEach(item => item.displayItem());
            
        }
        
        public void addItem()
        {
            Console.Clear();
            displayNote();
            print(" o | ");
            //string item = input();
            this.Items.Add(new Item(input()));
            
            Console.Clear();

        }
        public void reorderItem()
        {

        }
        public void deleteItem()
        {

        }

    }
}
