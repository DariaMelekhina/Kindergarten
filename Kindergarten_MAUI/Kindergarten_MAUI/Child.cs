using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Java.Util.Jar.Attributes;

namespace Kindergarten_MAUI
{
    public class Child
    {
        public List<Club> Clubs = new List<Club>();
        public string Name { get; private set; }
        public string IdChild { get; private set; }
        public Child(string name, string idChild) 
        {
            this.Name = name;
            IdChild = idChild;
            ClubParser();
        }

        private void ClubParser()
        {
            // Запрос на кружки
            //foreach
            //clubs.Add();
        }

        public class Club
        {
            public string Name { get; private set; }
            public string Teacher { get; private set; }
            public string Time { get; private set; }
            public bool IsActive { 
                get
                { 
                    return IsActive; 
                }
                set
                {
                    _isActive = value;
                    ChangeActiveInDatabase();
                }
            }
            private bool _isActive;
            public Club(string name, string teacher, string time, bool isActive) 
            {
                Name = name;
                Teacher = teacher;
                Time = time;
                IsActive = isActive;
            }

            private void ChangeActiveInDatabase()
            {
                // TODO: запрос меняющий состояние кружка для ребёнка в базе
            }
        }
    }
}
