using Enums;
using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public abstract class BaseTree : ITree
    {
        protected double deltaHeight;

        #region Properties

        public Color State
        { get; protected set; }

        public Shape Form
        { get; protected set; }

        public double Height
        { get; protected set; }

        public double Age
        { get; protected set; }

        public int Number
        { get; protected set; }

        #endregion

        public BaseTree(int number, double deltaHeight)
        {
            this.deltaHeight = deltaHeight;
            Number = number;
            Nature.changeSeason += Nature_changeSeason;
        }

        private void Nature_changeSeason(object sender, EventArgs e)
        {
            Growth();
        }

        protected virtual void Growth()
        {
            Age += ConstantsLib.DeltaAge;
            Height += deltaHeight;
        }
    }
}
