int x = 100;
int y = 100;
int[]row = new int [x];
int[]column = new int [y];
Random random = new Random();
char empty = 'O';
char enemy = 'X';
int enemyPosX = random.Next(101);
int enemyPosY = random.Next(101);

for (int h = 0; h < y; h++)
{
    column[h] = h;
    for (int w = 0; w < x; w++)
    {
        if (h == enemyPosY && w == enemyPosX){
            Console.Write(enemy);
        }
        else{
            row[w] = w;
            Console.Write(empty);
        }
        
    }
    Console.WriteLine();
}
Console.WriteLine($"Enemy spawned at:\nRow: {enemyPosY}\nColumn: {enemyPosX}");
