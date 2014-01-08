//-----------------------------------------------------------------------
// <copyright file="SpellingOptionsPanel.cs">
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

  /// <summary>
  /// StyleCop spelling options panel.
  /// </summary>
  internal partial class SpellingOptionsPanel : ProjectOptionsPanelBase
  {
    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="MonoDevelop.StyleCop.SpellingOptionsPanel"/> class.
    /// </summary>
    public SpellingOptionsPanel()
    {
      this.Build();
    }

    #endregion Constructor
  }
}