//-----------------------------------------------------------------------
// <copyright file="OptionsPanelBase.cs">
//   APL 2.0
// </copyright>
// <license>
//   Copyright 2013 Alexander Jochum
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </license>
//-----------------------------------------------------------------------
namespace MonoDevelop.StyleCop
{
  using System;
  using Gtk;
  using MonoDevelop.Ide;
  using MonoDevelop.Ide.Gui.Dialogs;

  /// <summary>
  /// StyleCop Options panel base class.
  /// </summary>
  [System.ComponentModel.ToolboxItem(false)]
  internal abstract class OptionsPanelBase : Bin, IOptionsPanel
  {
    #region IOptionsPanel implementation

    /// <summary>
    /// Applies the changes.
    /// </summary>
    public virtual void ApplyChanges()
    {
    }

    /// <summary>
    /// Creates the options panel widget.
    /// </summary>
    /// <returns>The options panel widget.</returns>
    public virtual Widget CreatePanelWidget()
    {
      return this;
    }

    /// <summary>
    /// Initializes the OptionsPanel.
    /// </summary>
    /// <param name="dialog">Parent dialog.</param>
    /// <param name="dataObject">Data object.</param>
    public virtual void Initialize(OptionsDialog dialog, object dataObject)
    {
    }

    /// <summary>
    /// Determines whether this instance is visible.
    /// </summary>
    /// <returns><c>true</c> if this instance is visible; otherwise, <c>false</c>.</returns>
    public virtual bool IsVisible()
    {
      return true;
    }

    /// <summary>
    /// Validates the changes.
    /// </summary>
    /// <returns><c>true</c>, if changes was validated, <c>false</c> otherwise.</returns>
    public virtual bool ValidateChanges()
    {
      return true;
    }

    #endregion
  }
}