﻿using System;

namespace ClassExample31
{
    public class Cat : Animal
    {
        public sealed override void Eat()
        {
            Console.WriteLine("고양이 사료를 먹습니다.");
        }
    }
}