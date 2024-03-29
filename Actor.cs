﻿using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace CoolMathForGames
{
    // is there so i can hold the type for icon for actors or player
    struct Icon
    {
        public char Symbol;
        public ConsoleColor color;
    }
    class Actor
    {
        private Icon _icon;
        private string _name;
        //can make the vector2 because i used the using mathLIbaray;
        private Vector2 _position;
        //made started a bool so we can see if actors is there or not.
        private bool _started;

        public bool Started
        {
            get { return _started; }
        }


        public Vector2 Postion
        {
            get { return _position; }
            set { _position = value; }
        }

        
        // takes the Actor constructor and add the float x and y but takes out y
        
        public Actor(char icon, float x, float y, string name = "Actor", ConsoleColor color = ConsoleColor.Cyan) :
            this(icon, new Vector2 { X = x, Y = y }, name, color)
        { }


        
        // Is a constructor for the actor that hold is definition.
        public Actor(char icon, Vector2 position, string name = "Actor", ConsoleColor color = ConsoleColor.Cyan)
        {
            //updatede the Icon with the struct and made it take a symbol and a color
            _icon = new Icon { Symbol = icon, color = color };
            _position = position;
            _name = name;
        }

        public virtual void Start()
        {
            _started = true;
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            Engine.Render(_icon, _position);
        }

        public void End()
        {

        }
    }
}
