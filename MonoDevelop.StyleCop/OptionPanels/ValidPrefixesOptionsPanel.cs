//-----------------------------------------------------------------------
// <copyright file="ValidPrefixesOptionsPanel.cs">
//   APL 2.0
// </copyright>
// <license>
//   Copyright 2013-2014 Alexander Jochum
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
  using MonoDevelop.Components;
  using global::StyleCop;

  /// <summary>
  /// StyleCop valid prefixes options panel.
  /// </summary>
  internal partial class ValidPrefixesOptionsPanel : ProjectOptionsPanelBase
  {
    #region Private Fields

    /// <summary>
    /// The analyzer that this settings page is attached to.
    /// </summary>
    private readonly SourceAnalyzer analyzer;

    #endregion Private Fields

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="MonoDevelop.StyleCop.ValidPrefixesOptionsPanel"/> class.
    /// </summary>
    public ValidPrefixesOptionsPanel()
    {
      this.Build();

      this.analyzer = ProjectUtilities.Instance.Core.GetAnalyzer("StyleCop.CSharp.NamingRules");
    }

    #endregion Constructor

    #region Public Override Methods

    /// <summary>
    /// Initializes the options panel values just before the panel is shown to user for the first time.
    /// </summary>
    /// <returns>The options panel widget.</returns>
    /// <remarks>Will only be called if the user really gets to see the options panel.</remarks>
    public override Control CreatePanelWidget()
    {
      return base.CreatePanelWidget();
    }

    #endregion Public Override Methods

    #region Protected Signal Methods

    /// <summary>
    /// Called when the addPrefixButton is clicked.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments.</param>
    protected void AddPrefixButtonClicked(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// Called when the removePrefixButton is clicked.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments.</param>
    protected void RemovePrefixButtonClicked(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    #endregion Protected Signal Methods
  }
}