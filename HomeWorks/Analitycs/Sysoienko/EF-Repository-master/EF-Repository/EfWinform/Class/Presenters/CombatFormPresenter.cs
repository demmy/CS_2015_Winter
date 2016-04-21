using System;
using EfWinform.Class.Services;
using EfWinform.Interface;

namespace EfWinform.Class.Presenters
{
    class CombatFormPresenter
    {
        private readonly ICombatForm _view;
        private readonly Service _service;
        public CombatFormPresenter(ICombatForm view)
        {
            _service = new CombatService();
            _view = view;
            _view.ShowCombatGrid += _view_ShowCombatGrid;
        }
        void _view_ShowCombatGrid(object sender, EventArgs e)
        {
            var combats = _service.Get();
            _view.CombatGrid = combats;
        }
    }
}
