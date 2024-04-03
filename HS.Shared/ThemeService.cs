using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HS.Shared
{
    public class ThemeService
    {
        private readonly MudTheme _defaultTheme = new() { Palette = new PaletteLight { Primary = "#7210FF" } };
        private MudTheme _currentTheme;

        public event Action ThemeChanged;

        public MudTheme CurrentTheme => _currentTheme ?? _defaultTheme;

        public void ChangeTheme(MudTheme newTheme)
        {
            _currentTheme = newTheme;
            ThemeChanged?.Invoke();
        }

    }
}
