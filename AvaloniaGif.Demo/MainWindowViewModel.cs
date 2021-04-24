using System.Collections.Generic;
using Avalonia.Media;
using ReactiveUI;

namespace AvaloniaGif.Demo
{
    public class MainWindowViewModel : ReactiveObject
    {
        public MainWindowViewModel()
        {
            Stretches = new List<Stretch>
            {
                Stretch.None, 
                Stretch.Fill,
                Stretch.Uniform,
                Stretch.UniformToFill
            };
            AvailableGifs = new List<string>
            {
                "resm:AvaloniaGif.Demo.Images.laundry.gif",
                "resm:AvaloniaGif.Demo.Images.earth.gif",
                "resm:AvaloniaGif.Demo.Images.rainbow.gif",
                "resm:AvaloniaGif.Demo.Images.newton-cradle.gif",
                "resm:AvaloniaGif.Demo.Images.library_hero.jpg",
                "resm:AvaloniaGif.Demo.Images.app.gif",
                "resm:AvaloniaGif.Demo.Images.app.jpg",
                "resm:AvaloniaGif.Demo.Images.t.gif",
                "resm:AvaloniaGif.Demo.Images.avater_default.png",
                
                // Great shots by Vitaly Silkin, free to use:
                // https://dribbble.com/colder/projects/219798-Loaders
                "resm:AvaloniaGif.Demo.Images.loader.gif", 
                "resm:AvaloniaGif.Demo.Images.evitare-loader.gif", 
                "resm:AvaloniaGif.Demo.Images.c-loader.gif"
            };
        }

        private IReadOnlyList<string> _availableGifs;
        public IReadOnlyList<string> AvailableGifs
        {
            get => _availableGifs;
            set => this.RaiseAndSetIfChanged(ref _availableGifs, value);
        }

        private string _selectedGif;
        public string SelectedGif
        {
            get => _selectedGif;
            set => this.RaiseAndSetIfChanged(ref _selectedGif, value);
        }
        
        private IReadOnlyList<Stretch> _stretches;
        public IReadOnlyList<Stretch> Stretches
        {
            get => _stretches;
            set => this.RaiseAndSetIfChanged(ref _stretches, value);
        }

        private Stretch _stretch = Stretch.None;
        public Stretch Stretch
        {
            get => _stretch;
            set => this.RaiseAndSetIfChanged(ref _stretch, value);
        }
    }
}
