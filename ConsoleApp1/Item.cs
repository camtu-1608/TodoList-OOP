using System;
using static ConsoleApp1.Utils;
using System.Globalization;

namespace ConsoleApp1
{
    enum Status
    {
        NotStarted,
        InProcess,
        Skipped,
        Done
    }
    enum LabelType
    {
        Study,
        Homework,
        NormalTask
    }
    class Item
    {
        private int _id;
        private Status _state;
        private String _title;
        private String _description;
        private LabelType _label;
        private DateTime _expriedDay;
        public int ID { get => _id; set => _id = value; }
        public Status State { get => _state; set => _state = value; }
        public String Title { get => _title; set => _title = value; }
        public String Description { get => _description; set => _description = value; }
        public LabelType Lable { get => _label; set => _label = value; }
        
        public Item(int ID, Status state, String title, String description, LabelType label, DateTime expriedDate)
        {
            _id = ID;
            _state = state;
            _title = title;
            _description = description;
            _label = label;
            _expriedDay = expriedDate;
        }
        public void displayItemProperties()
        {
            Console.WriteLine(" #{0} - @{1}\n {2}:\n\t{3}\n\t{4}", _id, _label, _title, _description, _state);
            _expriedDay.ToString("G", DateTimeFormatInfo.InvariantInfo);
            Console.WriteLine(String.Concat("\tDue on: ", _expriedDay.ToString("G", DateTimeFormatInfo.InvariantInfo)));
        }
    }
}
