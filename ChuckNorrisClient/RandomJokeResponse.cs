﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisClient
{
    public class Value
    {
        /// <summary>
        /// The unique ID of the joke
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The text of the joke
        /// </summary>
        public string joke { get; set; }

        /// <summary>
        /// Categories the joke belongs to
        /// </summary>
        public List<string> categories { get; set; }
    }

    public class RandJokeResponse
    {
        public string type { get; set; }
        public Value value { get; set; }
    }
}
