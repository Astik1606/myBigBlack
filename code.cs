






array1[] myFantasy = new string[5] {"27", "564", "big", "black", "coc", "hi"};
array2[] myFantasy1 = new string[myFantasy.Length];
void susy (array1[] myFantasy, array2[] myFantasy1)
{
    int count = 0;
    for (int i = 0; i < myFantasy.Length; i++)
    
    {
    if(myFantasy[i].Length <= 3)
        {
        myFantasy1[count] = myFantasy[i];
        count++;
        }
    }
}
void pokasy (array[] cun)
{
    for (int i = 0; i < cun.Length; i++)
    {
        Console.Write($"{cun[i]} ");
    }
    Console.WriteLine();
}
susy(myFantasy, myFantasy1);
pokasy(myFantasy1);
