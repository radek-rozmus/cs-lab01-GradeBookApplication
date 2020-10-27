﻿using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool weighted) : base(name, weighted)
        {
            //Name = name;
            Type = GradeBookType.Standard;
        }
    }
}
