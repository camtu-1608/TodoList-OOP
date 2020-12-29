﻿using System;
using System.Collections.Generic;
//using System.Linq;
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
            Item item = new Item();
            item.Text = input("Text: ");
            item.State= Int32.Parse(input("Completed ?\n1-Yes or 2-No:"));  
            Items.Add(item);
            //print(" o | ");
            //string item = input();
            //this.Items.Add(new Item(input("Text: ")));
            
            Console.Clear();

        }
        public void reorderItem()
        {

        }
        public void deleteItem()
        {
            int index = Int32.Parse(input("Which one, enter number: "));
            Console.Clear();
            this.Items.RemoveAt(index);
        }

    }
}
