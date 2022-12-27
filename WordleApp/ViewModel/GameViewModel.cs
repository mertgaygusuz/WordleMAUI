using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WordleApp.Model;

namespace WordleApp.ViewModel
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private WordRow[] rows;

        [ICommand]
        public void Enter()
        {

        }
    }
}
