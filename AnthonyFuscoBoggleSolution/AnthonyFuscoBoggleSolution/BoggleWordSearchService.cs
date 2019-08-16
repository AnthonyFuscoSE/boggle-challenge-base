using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AnthonyFuscoBoggleSolution.Models;

namespace AnthonyFuscoBoggleSolution
{
    public interface IBoggleWordSearchService
    {
        HashSet<string> FindWordsInBoggle(string boggleBoard, int numberOfColumns, int numberofRows);
    }

    public class BoggleWordSearchService : IBoggleWordSearchService
    {
        private readonly ITrieBuilder _trieBuilder;
        private HashSet<string> _foundWords = new HashSet<string>();

        public BoggleWordSearchService(ITrieBuilder trieBuilder)
        {
            _trieBuilder = trieBuilder ?? throw new ArgumentNullException(nameof(trieBuilder));
        }

        public HashSet<string> FindWordsInBoggle(string boggleBoard, int numberOfColumns, int numberofRows)
        {
            //Build Main Trie
            List<ITrie> mainTrie = _trieBuilder.BuildTrie();

            //build array of boggle board based on string / params
            char[,] boardArray = CreateBoggleBoard(boggleBoard, numberOfColumns, numberofRows);

            //create depth first search
            for (int row = 0; row < boardArray.GetLength(0); row++)
            {

                for (int col = 0; col < boardArray.GetLength(1); col++)
                {
                    FindWords(row, col, "", new List<string>(), mainTrie, boardArray);
                }
            }

            return _foundWords;
        }

        private void FindWords(int row, int col, string builtWord, List<string> visitedLocations, List<ITrie> currentNode, char[,] boardArray)
        {
            if(visitedLocations.Contains($"{row},{col}"))
            {
                return;
            }

            visitedLocations.Add($"{row},{col}");

            char letter = boardArray[row, col];

            builtWord += letter;

            var foundNode = currentNode.FirstOrDefault(x => x.Value == letter);
            
            if (foundNode == null)
            {
                visitedLocations.Remove($"{row},{col}");
                return;
            }

            if (foundNode.ValidWord)
            {
                _foundWords.Add(builtWord);
            }

            List<Tuple<int, int>> nextLocation = GetAvailableCoordinates(row, col, boardArray.GetLength(0), boardArray.GetLength(1));

            foreach (Tuple<int, int> coordinate in nextLocation)
            {
               FindWords(coordinate.Item1, coordinate.Item2, builtWord, visitedLocations, foundNode?.Children, boardArray); 
            }

            visitedLocations.Remove($"{row},{col}");
        }

        internal char[,] CreateBoggleBoard(string boggleBoard, int numberOfColumns, int numberofRows)
        {
            
            if (!IsValidBoggleBoard(boggleBoard, numberOfColumns, numberofRows))
            {
                throw new ArgumentException($"{boggleBoard} does not make a valid boggle board");
            }

            var boggleBoardUpper = boggleBoard.ToUpper();

            var board = new char[numberofRows, numberOfColumns];

            int currentCol = 0;
            int currentRow = 0;

            for (int i = 0; i < boggleBoardUpper.Length; i++)
            {
                board[currentRow, currentCol] = boggleBoardUpper[i];
                currentCol++;
                if (currentCol > numberOfColumns - 1)
                {
                    currentRow++;
                    currentCol = 0;
                }
            }

            return board;
        }

        internal bool IsValidBoggleBoard(string board, int numberOfColumns, int numberOfRows)
        {
            if (string.IsNullOrWhiteSpace(board))
            {
                return false;
            }

            if (numberOfColumns <= 1 || numberOfRows <= 1)
            {
                return false;
            }

            if (board.Length != numberOfColumns * numberOfRows)
            {
                return false;
            }

            Regex r = new Regex("[^A-Z]");
            if (r.IsMatch(board.ToUpper()))
            {
                return false;
            }

            return true;
        }

        internal List<Tuple<int, int>> GetAvailableCoordinates(int curRow, int curCol, int maxRow, int maxCol)
        {
            var nextToTry = new List<Tuple<int, int>>();

            foreach (Tuple<int, int> direction in PossibleDirections())
            {
                var newRow = curRow + direction.Item1;
                var newCol = curCol + direction.Item2;

                if (newRow >= maxRow || newCol >= maxCol || newRow < 0 || newCol < 0)
                {
                    continue;
                }
                nextToTry.Add(new Tuple<int, int>(newRow, newCol));
            }

            return nextToTry;
        }

        internal List<Tuple<int,int>> PossibleDirections()
        {
            var possibleLocations = new List<Tuple<int,int>>();
            possibleLocations.Add(new Tuple<int, int>(-1,-1)); //upperLeft
            possibleLocations.Add(new Tuple<int, int>(-1, 0)); //Up
            possibleLocations.Add(new Tuple<int, int>(-1, 1)); //UpperRight
            possibleLocations.Add(new Tuple<int, int>(0, -1)); //left
            possibleLocations.Add(new Tuple<int, int>(0, 1)); //right
            possibleLocations.Add(new Tuple<int, int>(1, -1)); //bottomLeft
            possibleLocations.Add(new Tuple<int, int>(1, 0)); //down
            possibleLocations.Add(new Tuple<int, int>(1, 1)); //bottomRight

            return possibleLocations;
        }
    }
}
