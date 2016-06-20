﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGranharngn
{
    public class Player : DynamicObject
    {
        public Player() : base() {  }

        public Player(int xPos, int yPos) : base(xPos, yPos) {  }

        public Player(int health, int xPos, int yPos, int width, int height, int speed) : base(health, xPos, yPos, width, height, speed) {
            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    this.data[i, j].symbol = '#';
                    this.data[i, j].symbolColor = ConsoleColor.Green;
                    this.data[i, j].backgroundColor = ConsoleColor.Black;
                }
            }
        }

        private void Move(int x, int y) {
            this.xStartPos += x;
            this.yStartPos += y;
        }

        public void MoveEvent(object sender, KeyEventArgs e)
        {
            switch (e.key)
            {
                case ConsoleKey.DownArrow:
                    Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    Move(1, 0);
                    break;
                case ConsoleKey.UpArrow:
                    Move(0, -1);
                    break;
                default:
                    break;
            }
        }
            public void InteractHandler(object sender, EventArgs e) {
            this.xStartPos = 1;
            this.yStartPos = 1;
            this.Health--;
        }
    }
}