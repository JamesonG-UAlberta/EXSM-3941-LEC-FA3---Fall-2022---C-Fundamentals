namespace EXSM3941_Test
{
    public class TicTacToe_Tests
    {
        [Theory,
            // Not a number.
            InlineData('A', false),
            InlineData('a', false),
            InlineData(' ', false),
            InlineData('\n', false),
            InlineData('|', false),
            InlineData('-', false),
            InlineData('!', false),
            // A number that is never on the board.
            InlineData('0', false),
            // A number that is typically on the board, but occupied by X.
            InlineData('1', false),
            // A number that is typically on the board, but occupied by O.
            InlineData('3', false),
            // The valid spaces.
            InlineData('2', true),
            InlineData('4', true),
            InlineData('6', true),
            InlineData('7', true),
            InlineData('8', true)]
        public void ValidateSpace_Test_InProgress(char input, bool expectedResult)
        {
            char[] board = new char[] { 'X', '2', 'O', '4', 'X', '6', '7', '8', 'O' };
            Assert.Equal(expectedResult, Program.ValidateSpace(board, input));
        }


        [Theory,
        // Not a number.
        InlineData('A', false),
        InlineData('a', false),
        InlineData(' ', false),
        InlineData('\n', false),
        InlineData('|', false),
        InlineData('-', false),
        InlineData('!', false),
        // A number that is never on the board.
        InlineData('0', false),
        // The valid spaces.
        InlineData('1', true),
        InlineData('2', true),
        InlineData('3', true),
        InlineData('4', true),
        InlineData('5', true),
        InlineData('6', true),
        InlineData('7', true),
        InlineData('8', true),
        InlineData('9', true)]
        public void ValidateSpace_Test_FreshBoard(char input, bool expectedResult)
        {
            char[] board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Assert.Equal(expectedResult, Program.ValidateSpace(board, input));
        }
    }
}