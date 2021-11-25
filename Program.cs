//Batalla naval
public class Program
{
    public static void Main(string[] args)
    {
        int[,] tablero = new int[10, 10];
        int[,] tablero2 = new int[10, 10];


    }
    static void crearTablero(int[,] tablero)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                tablero[i, j] = 0;
            }
        }
    }
    static void crearTablero2(int[,] tablero2)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                tablero2[i, j] = 0;
            }
        }
    }
    static void dibujarTablero(int[,] tablero)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
    static void dibujarTablero2(int[,] tablero2)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablero2[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
    static void ponerBarcos(int[,] tablero)
    {
        int x, y;
        int barcos = 0;
        while (barcos < 5)
        {
            Console.WriteLine("Pon un barco");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            if (tablero[x, y] == 0)
            {
                tablero[x, y] = 1;
                barcos++;
            }
            else
            {
                Console.WriteLine("Ya hay un barco en esa posicion");
            }
        }

    }
    static void ponerBarcos2(int[,] tablero2)
    {
        int x, y;
        int barcos = 0;
        while (barcos < 5)
        {
            Console.WriteLine("Pon un barco");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            if (tablero2[x, y] == 0)
            {
                tablero2[x, y] = 1;
                barcos++;
            }
            else
            {
                Console.WriteLine("Ya hay un barco en esa posicion");
            }
        }

    }
    static void disparar(int[,] tablero, int[,] tablero2)
    {
        int x, y;
        int barcos = 0;
        while (barcos < 5)
        {
            Console.WriteLine("Dispara");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            if (tablero[x, y] == 1)
            {
                tablero[x, y] = 2;
                barcos++;
            }
            else
            {
                Console.WriteLine("Agua");
            }
        }

    }
    static void disparar2(int[,] tablero, int[,] tablero2)
    {
        int x, y;
        int barcos = 0;
        while (barcos < 5)
        {
            
            Console.WriteLine("Dispara");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            if (tablero2[x, y] == 1)
            {
                tablero2[x, y] = 2;
                barcos++;
            }
            else
            {
                Console.WriteLine("Agua");
            }
        }
    }
    static void ganador()
    {
        int x=0 , y=0;
        int[,] tablero = new int[10, 10];
        int[,] tablero2 = new int[10, 10];
        crearTablero(tablero);
        crearTablero2(tablero2);
        ponerBarcos(tablero);
        ponerBarcos2(tablero2);
        dibujarTablero(tablero);
        dibujarTablero2(tablero2);
        disparar(tablero, tablero2);
        disparar2(tablero, tablero2);
        dibujarTablero(tablero);
        dibujarTablero2(tablero2);
        if (tablero[x, y] == 1)
        {
            Console.WriteLine("Gana el jugador 1");
        }
        else
        {
            Console.WriteLine("Gana el jugador 2");
        }

    }


}









