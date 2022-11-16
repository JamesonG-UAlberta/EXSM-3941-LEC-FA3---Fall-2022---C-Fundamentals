namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Represents our 3x3 game board.
            char[] board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            int[][] winCombos = new int[][]
            {
                // Top row
                new int[] { 0, 1, 2 },
                // Mid row
                new int[] { 3, 4, 5 },
                // Bottom row
                new int[] { 6, 7, 8 },
                // Left col
                new int[] { 0, 3, 6 },
                // Mid col
                new int[] { 1, 4, 7 },
                // Right col
                new int[] { 2, 5, 8 },
                // NW-SE diag
                new int[] { 0, 4, 8 },
                // NE-SW diag
                new int[] { 2, 4, 6 }
            };
            bool gameOver = false;
            char playerTurn = 'X';
            char playerSelection = ' ';


            do
            {
                // Clear the console to make it look pretty.
                Console.Clear();
                // Display the game board.
                Console.WriteLine($"Current Turn: Player {playerTurn}");
                DisplayGameBoard(board);

                // Prompt the player for square input.
                playerSelection = GetValidSpace(board);
                // Replace the selected space with the current player's token.
                board[Array.IndexOf(board, playerSelection)] = playerTurn;

                // Check to see if the game is over.
                foreach (int[] winCondition in winCombos) if (board[winCondition[0]] == playerTurn && board[winCondition[1]] == playerTurn && board[winCondition[2]] == playerTurn) gameOver = true;

                // Invert the player turn.
                if (!gameOver) playerTurn = playerTurn == 'X' ? 'O' : 'X';
            } while (!gameOver);
            Console.Clear();
            // Display the final winning state.
            DisplayGameBoard(board);
            Console.WriteLine($"Game Over! {playerTurn} Wins!");
        }

        static void DisplayGameBoard(char[] board)
        {
            /*
                -------
                |@|@|@|
                -------
                |@|@|@|
                -------
                |@|@|@|
                -------
            */

            Console.WriteLine($"-------\n|{board[0]}|{board[1]}|{board[2]}|\n-------\n|{board[3]}|{board[4]}|{board[5]}|\n-------\n|{board[6]}|{board[7]}|{board[8]}|\n-------");
        }

        public static char GetValidSpace(char[] board)
        {
            char toReturn = '!';
            bool valid = false;
            do
            {
                Console.Write("Please select a space: ");
                // Try to get a character.
                valid = char.TryParse(Console.ReadLine(), out toReturn);
                // Validate that the charater is a number, and that the number is available on the board.
                if (valid) valid = ValidateSpace(board, toReturn);
                // Show an error message if appropriate.
                if (!valid) Console.WriteLine("Invalid input detected, please try again.");
            } while (!valid);
            return toReturn;
        }

        public static bool ValidateSpace(char[] board, char input) => char.IsNumber(input) && board.Contains(input);

    }
}