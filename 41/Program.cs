int[] a = {0, 7, 8, -2, -2};
int c = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        c++;
    }
}
Console.WriteLine(c);