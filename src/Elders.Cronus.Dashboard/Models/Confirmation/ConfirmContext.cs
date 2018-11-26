﻿namespace Elders.Cronus.Dashboard.Models.Confirmation
{
    /// <summary>
    /// Confirmation dialog state.
    /// </summary>
    public abstract class ConfirmContext
    {
        /// <summary>
        /// Gets a text representation of <see cref="Model"/>.
        /// </summary>
        public string Message { get; protected set; }

        /// <summary>
        /// Gets a <c>true</c> when dialog should be visible; otherwise <c>false</c>.
        /// </summary>
        public virtual bool IsVisible { get; set; }

        public abstract void OnConfirmed();
    }
}
