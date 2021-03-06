﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPatterns
{
    /// <summary>
    /// Латы.
    /// </summary>
    class KnightUnitArmorDecorator : KnightUnitBaseDecorator
    {
        public KnightUnitArmorDecorator(KnightUnit knight) : base(knight) { }

        public override string Name
        {
            get
            {
                return base.Name + " в латах";
            }
        }

        public override Int32 Attack
        {
            get
            {
                return base.Attack - 2;
            }
        }

        public override Int32 Defence
        {
            get
            {
                return base.Defence + 3;
            }
        }

        public override Unit CloneModifiedUnit(Int32 healthPoints)
        {
            return new KnightUnitArmorDecorator((KnightUnit)_knight.CloneModifiedUnit(healthPoints));
        }
    }
}
