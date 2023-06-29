Console.Clear();
void Input (int N, string [] st)
{
for ( int i = 0; i < N; i++)
    {
        st[i] = Console.ReadLine();
    }
}

void Output(string [] st)
{
    for (int i = 0; i < st.Length-1; i++)
        {
            Console.Write($"{st[i]}, ");
        }
    Console.Write($"{st[st.Length-1]}");
}

string[] Reducting (string [] st)
{
    string [] Final_St = new string [st.Length];
    int n = 0;
    for (int i = 0; i < st.Length; i++)
        {
            if (st[i].Length <= 3)
            {
                Final_St [n] = st[i];
                n++;
            }
        }
    string [] Final_Final_St = new string [n];
    for (int i = 0; i < n; i++)
            Final_Final_St[i] = Final_St[i];
    return Final_Final_St;

}

Console.Write("Введите колличество элементов массива: ");
int N = int.Parse(Console.ReadLine()!);
string [] elements = new string [N];
Input (N, elements);
Console.WriteLine("Изначальный массив: ");
Output (elements);
Console.WriteLine();
Console.WriteLine("Массив элементов длинной меньше трёх знаков:");
elements = Reducting(elements);
Output (elements);
