using System.Windows.Media;

namespace Wpf.Ui.Appearance;

/// <summary>
/// Event triggered when system theme is updated.
/// </summary>
/// <param name="currentTheme">Current application <see cref="ThemeType"/>.</param>
/// <param name="systemAccent">Current base system accent <see cref="Color"/>.</param>
public delegate void SystemThemeChangedEvent(ThemeType currentTheme, Color systemAccent);


