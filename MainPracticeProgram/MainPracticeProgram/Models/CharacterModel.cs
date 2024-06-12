﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPracticeProgram.Models
{
    internal class CharacterModel
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public List<string> Tools { get; set; } = new List<string>();
    }
}
