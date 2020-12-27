using System;
using static ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class Item
    {
        Boolean _state;
        String _text;

        public Item(string text)
        {
            State = false;
            Text = text;
        }

        public bool State { get => _state; set => _state = value; }
        public string Text { get => _text; set => _text = value; }

        public void displayItem()
        {
            switch (State)
            {
                case true:
                    println(" x | " + Text);
                    break;
                case false:
                    println(" o | " + Text);
                    break;
            }
        }
    }
}
