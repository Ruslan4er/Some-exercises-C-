using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Operators
{
    class Block
    {
        private int _upSide;
        private int _downSide;
        private int _rightSide;
        private int _leftSide;


        public int UpSide
        {
            get { return _upSide; }
            set { _upSide = value; }
        }

        public int DownSide
        {
            get { return _downSide; }
            set { _downSide = value; }
        }

        public int RightSide
        {
            get { return _rightSide; }
            set { _rightSide = value; }
        }

        public int LeftSide
        {
            get { return _leftSide; }
            set { _leftSide = value; }
        }


        public Block()
        {
            _upSide = 12;
            _downSide = 22;
            _rightSide = 33;
            _leftSide = 11;
        }

        public Block(int up, int down, int right, int left)
        {
            _upSide = up;
            _downSide = down;
            _rightSide = right;
            _leftSide = left;
        }

        public override bool Equals(object obj)
        {

            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block b = (Block)obj;

            return (b.UpSide == UpSide) && (b.DownSide == DownSide) && (b.LeftSide == LeftSide)
                && (b.RightSide == RightSide);
        }


        public override string ToString()
        {
            return "Блок со сторонами:" + UpSide + "," + DownSide + "," +
                RightSide + "," + LeftSide + ";";
        }
    }
}
