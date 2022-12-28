using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WordleApp.Model;

namespace WordleApp.ViewModel
{
    public partial class GameViewModel : ObservableObject
    {
        int rowIndex;
        int columnIndex;
        char[] correctAnswer;

        [ObservableProperty]
        private WordRow[] rows;

        public GameViewModel()
        {
            rows = new WordRow[6]
            {
                new WordRow(),
                new WordRow(),
                new WordRow(),
                new WordRow(),
                new WordRow(),
                new WordRow()
            };

            correctAnswer = "codes".ToCharArray();
        }

        [ICommand]
        public void Enter()
        {
            if (columnIndex != 5)
                return;

            var valid = true;

            if (valid)
            {
                if (rowIndex == 5)
                {
                    //oyunu bitir
                }
                else
                {
                    rowIndex++;
                    columnIndex = 0;
                }
            }
        }

        [ICommand]
        public void EnterLetter(char letter)
        {
            if (columnIndex == 5)
                return;
        }
    }
}
