﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WordleApp.Model;

namespace WordleApp.ViewModel
{
    public partial class GameViewModel : ObservableObject
    {
        int rowIndex;
        int columnIndex;
        char[] correctAnswer;
        public char[] KeyboardRow1 { get; }
        public char[] KeyboardRow2 { get; }
        public char[] KeyboardRow3 { get; }

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

            correctAnswer = "CODES".ToCharArray();
            KeyboardRow1 = "QWERTYUIOP".ToCharArray();
            KeyboardRow2 = "ASDFGHJKL".ToCharArray();
            KeyboardRow3 = "<ZXCVBNM>".ToCharArray();
        }

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
            if(letter == '<')
            {
                Enter();
                return;
            }

            if(letter == '>')
            {
                return;
            }

            if (columnIndex == 5)
                return;

            Rows[rowIndex].Letters[columnIndex].İnput = letter;
            columnIndex++;
        }
    }
}
