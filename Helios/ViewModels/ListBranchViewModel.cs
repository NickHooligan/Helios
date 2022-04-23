using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Helios.Models;

namespace Helios.ViewModels
{
	public class ListBranchViewModel : ViewModelBase
	{
		private readonly ObservableCollection<BranchViewModel> _branches;
		//public IEnumerable<BranchViewModel> Branches => _branches;
        public string CurrentBranch
        {
			get { return Branch.GetCurrentActiveBranch(); }

        }

		public ListBranchViewModel()
		{
			this._branches = new ObservableCollection<BranchViewModel>();
		}
	}
}
