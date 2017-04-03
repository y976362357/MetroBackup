﻿using Palmmedia.BackUp.UI.Wpf.Common;

namespace Palmmedia.BackUp.UI.Wpf.ViewModels
{
    /// <summary>
    /// ViewModel presenting a view indicating that no files have been selected for synchronization.
    /// </summary>
    public class SynchronizeNoFilesViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronizeNoFilesViewModel"/> class.
        /// </summary>
        public SynchronizeNoFilesViewModel()
        {
            this.OkCommand = new FlowCommand();
        }

        #region Properties

        /// <summary>
        /// Gets the ok command.
        /// </summary>
        /// <value>The ok command.</value>
        public IFlowCommand OkCommand { get; private set; }

        #endregion
    }
}
