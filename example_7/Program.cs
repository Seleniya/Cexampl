int A = 1;
int B = 3;
int C = 8;
int D = 9;


int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;
if (D > max) max = D;

Console.Write("max = ");
Console.WriteLine(max);
