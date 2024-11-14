internal class Program
{
    static int[] valores = new int[6];
    private static int totalvalores = valores.Length;
    private static void Main(string[] args)
    {
        string[] valores = { "uno", "dos", "tres", "cuatro", "cinco", "seis" };

        System.Out.println(Arrays.Tostring(valores));
        removeindex(valores, 0);
        System.Out.println(Arrays.Tostring(valores));
    }

    private static void removeindex(string[] array, int index)
    {
        int i = index;
        for (; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[i] = null;
    }
}