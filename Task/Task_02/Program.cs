
int a_x = 3;
int a_y = 6;
int a_z = 8;
int b_x = 2;
int b_y = 1;
int b_z = -7;

double result = Math.Sqrt(Math.Pow(a_x - b_x, 2)
                + Math.Pow(a_y - b_y, 2)
                + Math.Pow(a_z - b_z, 2));
Console.WriteLine(result);
