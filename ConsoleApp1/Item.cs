using System;
using static ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class Item
    {
        int _state;
        String _text;
        public Item()
        {

        }
        public Item(string text,int state)
        {
            State = state;
            Text = text;
        }

        public int State { get => _state; set => _state = value; }
        public string Text { get => _text; set => _text = value; }

        public void displayItem()
        {

            switch (State)
            {
                case 1:
                    println(" x | " + Text);
                    break;
                case 2:
                    println(" o | " + Text);
                    break;
            }
        }
    }
}
