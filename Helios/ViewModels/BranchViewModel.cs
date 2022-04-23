using System;
using System.Collections.Generic;
using System.Text;
using Helios.Models;

namespace Helios.ViewModels
{
    class BranchViewModel : ViewModelBase
    {
        private readonly Branch _branch;

        public string Name => _branch.Name;
        public bool Active => _branch.Active;
        public BranchViewModel(Branch Branch)
        {
            this._branch = Branch;
        }
    }
}
