﻿using System;
using digital.Models;

namespace digital.ViewModels
{
    public class DetailsViewModel
    {
        public Monkey Monkey { get; set; }
        public DetailsViewModel(Monkey monkey)
        {
            Monkey = monkey;
        }
    }
}

