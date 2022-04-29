

using IniParser.Model;

var lines = File.ReadAllLines(@"Mazes\Basic.txt");
var maze = new char[lines[0].Length, lines.Length];

const char Path = ' ';
const char End = '♦';
const char Smile = '☻';
const char Wall = '▓';
var smileCol = 0;
var smileRow = 0;
var endCol = 0;
var endRow = 0;
var row = 0;

foreach (var line in lines)
{
    
var col = 0;
    foreach(var c in line)
    {
        if(c == 'X')
        {
            maze[col, row] = Wall;
        } 
        else if(c == 'S')
        {
            maze[col, row] = Smile;
            smileCol = col;
            smileRow = row;
        }
        else if(c == 'E')
        {
            maze[col, row] = End;
            endCol = col;
            endRow = row;
        }
        else
        {
            maze[col, row] = c;
        }
        col++;
    }
   row++;
}  


void Print()
{
    Console.SetCursorPosition(0, 0);
    Console.CursorVisible = false;
    for (row = 0; row < maze.GetLength(1); row++)
    {
        for (var col = 0; col < maze.GetLength(0); col++)
        {
            Console.Write(maze[col, row]);
        }
        Console.WriteLine();
    }
}




do
{
    Print();
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.LeftArrow)
    {
        MoveLeft();
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        MoveRight();
    }
    if (key.Key == ConsoleKey.UpArrow)
    {
        MoveUp();
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        MoveDown();
    }
    if (endCol == smileCol && endRow == smileRow)
    {  
        Console.WriteLine("YOU WIN!!");
        break;
    }
} while (true);



void MoveRight()
{
        
    var col = smileCol + 1;
    var row = smileRow;
    if (0 > col || 0 > row || maze.GetLength(0) <= col || maze.GetLength(1) <= row || maze[col, row] == Wall)
    {
        return;
    }
    maze[smileCol, smileRow] = Path;
    maze[col, row] = Smile;
    smileCol = col;
    smileRow = row;
}
void MoveLeft()
{
    var col = smileCol - 1;
    var row = smileRow;
    if (0 > col || 0 > row || maze.GetLength(0) <= col || maze.GetLength(1) <= row || maze[col, row] == Wall)
    {
        return;
    }
    maze[smileCol, smileRow] = Path;
    maze[col, row] = Smile;
    smileCol = col;
    smileRow = row;
}
void MoveUp()
{
    var col = smileCol ;
    var row = smileRow - 1;
    if (0 > col || 0 > row || maze.GetLength(0) <= col || maze.GetLength(1) <= row || maze[col, row] == Wall)
    {
        return;
    }
    maze[smileCol, smileRow] = Path;
    maze[col, row] = Smile;
    smileCol = col;
    smileRow = row;
}
void MoveDown()
{
    var col = smileCol;
    var row = smileRow + 1;
    if (0 > col || 0 > row || maze.GetLength(0) <= col || maze.GetLength(1) <= row || maze[col, row] == Wall)
    {
        return;
    }
    maze[smileCol, smileRow] = Path;
    maze[col, row] = Smile;
    smileCol = col;
    smileRow = row;
}
  


//Do while loop readkey

Console.WriteLine();
//private static 
//private static Point location;
//private static Point exit;
//Console.Clear();
//Console.CursorVisible = false;
//var key = Console.ReadKey(true);
//maze.GetLength(0)
//maze.GetLength(1)
//Console.SetCursorPosition(0, 0);
//Console.Write(maze[x, y]);
//File.ReadAllLines(@"Mazes\Basic.txt");
//

