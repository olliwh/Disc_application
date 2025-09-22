﻿using System.Drawing;

namespace Disc_API.Models
{
    public class Department
    {
        private int _id;
        private string _name;
        public Department(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
