using System;
using FightClub.Game.Interfaces;
using FightClub.UI;

namespace FightClub.Game
{
    abstract class AbstractPlayerModel : IPlayerModel
    {
        #region Fields
        readonly Random _rand = new Random();
        private int _hp = PlayerOptions.PlayerHp;
        private int _damage = PlayerOptions.Damage;
        private int _block = 0;
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }
        public int Hp
        {
            get { return _hp; }
        }
        public int Hit { get; set; }
        public int Set { get { return (int)_block; } }
        public string Log { get; set; }
        #endregion

        #region Methods
        public int SetBlock(Part part)
        {
            _block = (int)part;
            return _block;
        }
        public int BonusHp()
        {
            _hp = _hp + PlayerOptions.BonusHp;
            return _hp;
        }
        public void ImproveDmg()
        {
            _damage = _rand.Next(5, 13);
        }
        public int Recovery(bool h)
        {
            if (h)
            {
                _hp = PlayerOptions.PlayerHp;
                return _hp;
            }

            _hp = PlayerOptions.BonusHp + PlayerOptions.PlayerHp;
            return _hp;
        }
        public int GetHit(Part part)
        {
            if ((int)part != _block)
            {
                if (_hp - _damage > 0)
                {
                    _hp -= _damage;
                    if (Wound != null)
                        Wound(this, new GameEventArgs("wounded"));
                }
                else
                {
                    _hp = 0;
                    if (Death != null)
                        Death(this, new GameEventArgs("Died"));
                }
            }
            if (_block == (int)part)
            {
                if (Block != null)
                    Block(this, new GameEventArgs("Blocked"));
            }
            return _hp;
        }
        #endregion

        #region events
        public event GameForceHandler Wound;
        public event GameForceHandler Block;
        public event GameForceHandler Death;
        #endregion
    }
}
